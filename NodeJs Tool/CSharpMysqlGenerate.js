var mysql = require('mysql');
var fs = require('fs');

var nameSpace = "Models.ES";
var nameSpaceES = "API30Shine.Models.ESModels";
var nameSpaceWorker = "ThirtyShine.Conductor.Model";
//var ignoreCol = ["uid", "id", "is_delete", "create_time", "create_at", "modify_time", "modify_at"];
var ignoreCol = [];
var ignoreCol2 = ["create_at", "modify_at"];

var con = mysql.createConnection({
    host: "192.168.1.12",
    user: "root",
    password: "test",
    connectTimeout: 180000,
    port: 3307,
    insecureAuth: true
});


var toCamel = function (input) {
    var tmp = input.split("_");
    var ret = "";
    tmp.forEach(function (value, index) {
        ret += value.substr(0, 1).toUpperCase() + value.substr(1).toLowerCase();
    });
    return ret;
}

var getCsharpType = function (input) {
    input = input.toLowerCase();

    if (input.includes("char") || input.includes("text")) {
        return "string";
    }
    if (input.includes("float")) {
        return "float";
    }
    if (input.includes("bigint")) {
        return "long";
    }
    if (input.includes("int")) {
        return "int";
    }
    if (input.includes("date")) {
        return "DateTime";
    }
    if (input.includes("time")) {
        return "TimeSpan";
    }
}


var getCsharpTypeWorker = function (input) {
    input = input.toLowerCase();

    if (input.includes("char") || input.includes("text")) {
        return "string";
    }
    if (input.includes("float")) {
        return "float?";
    }
    if (input.includes("bigint")) {
        return "long?";
    }
    if (input.includes("int")) {
        return "int?";
    }
    if (input.includes("date")) {
        return "DateTime?";
    }
    if (input.includes("time")) {
        return "TimeSpan?";
    }
}

var getClassContentByTableName = function (con, tableName, dbName) {

    con.query("SHOW COLUMNS FROM " + dbName + "." + tableName, function (err, result) {
        if (!err) {
            var ret = "";
            var ret2 = "";
            var ret3 = "";
            result.forEach(function (value, index) {
                var field = value.Field;
                var type = value.Type;
                var isNull = value.Null.toUpperCase() == "NO" ? false : true;
                var cSharpType = getCsharpType(type);
                var cSharpWorkerType = getCsharpTypeWorker(type);
                var tm = "\t\tpublic " + cSharpType + " " + toCamel(field) + " {get; set;} \r\n";
                var tm2 = "\t\tpublic " + cSharpWorkerType + " " + toCamel(field) + " {get; set;}\r\n";

                if (!(ignoreCol2.indexOf(field.toLowerCase()) >= 0))
                    ret3 += "\n\t\t[Text(Name=\"" + field + "\")]\r\n\t\t[JsonProperty(\"" + field + "\")]\r\n" + tm2;

                if (ignoreCol.indexOf(field.toLowerCase()) >= 0) {
                    return;
                }

                ret += tm
                ret2 += "\n\t\t[Text(Name=\"" + field + "\")]\r\n" + tm;
            });
            var normalClass = ("namespace " + nameSpace + " \r\n{\r\n\tpublic class " + toCamel(tableName) + "\r\n{\r\n\t" + ret + "\r\n}\r\n}");
            var WorkerClass = ("using Nest;\r\nusing MobileTech.SQLGenerateLibrary;\r\nusing Newtonsoft.Json;\r\nusing System;\r\nnamespace " + nameSpaceWorker + " \r\n{\r\n\tpublic class "
                + toCamel(tableName) + ": TableInfo\r\n{\r\n\t" + ret3 + "\r\n" +
                "\t\tpublic override string TableName() { return \"" + tableName + "\"; }\r\n" +
                "\t\tpublic static string GetIndexName() { return \"" + dbName + "__" + tableName + "\"; }" +
                "\r\n}\r\n}");
            var esClass = ("using Nest;\r\n\r\nnamespace " + nameSpaceES + " \r\n{\r\n\tpublic class " + toCamel(tableName) + "ES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel\r\n\t{\r\n" + ret2 + "\r\n\t}\r\n}");

            fs.writeFile("./normalClass/" + toCamel(tableName) + '.cs', normalClass, {
                encoding: 'utf8',
                flag: 'w+'
            }, function (err, data) {
                if (err) console.log(err);
                else
                    console.log("Successfully Written to File " + toCamel(tableName) + ".cs");
            });

            fs.writeFile("./EsClass/" + toCamel(tableName) + 'ES.cs', esClass, {
                encoding: 'utf8',
                flag: 'w+'
            }, function (err, data) {
                if (err) console.log(err);
                else console.log("Successfully Written to File " + toCamel(tableName) + "ES.cs");
            });
            fs.writeFile("./WorkerClass/" + toCamel(tableName) + '.cs', WorkerClass, {
                encoding: 'utf8',
                flag: 'w+'
            }, function (err, data) {
                if (err) console.log(err);
                else console.log("Successfully Written to File Worker " + toCamel(tableName) + ".cs");
            });
        }

    });
}


con.connect(function (err) {
    if (err) {
        console.log("bye bye");
        return;
    }
    // console.log("Connected!");
    con.query("SHOW DATABASES", function (err, result) {
        if (err) throw err;

        result.forEach(function (element) {
                var dbname = element.Database;
                if (dbname.includes("db30shine_")) {
                    con.query("SHOW TABLES FROM " + dbname + "", function (err, result) {
                        if (!err) {
                            result.forEach(function (value, index) {
                                var tableName = value["Tables_in_" + dbname];
                                getClassContentByTableName(con, tableName, dbname);
                            });
                        }
                    });
                }
            }
        );

    });
});
