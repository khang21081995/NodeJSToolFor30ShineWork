var mysql = require('mysql');
var fs = require('fs');

// var Ajax = require('simple-ajax');
var http = require('http');
const ESInfo = {
    host: "192.168.1.12",
    port: "28000",
}

var con = mysql.createConnection({
    host: "192.168.1.12",
    user: "root",
    password: "test",
    connectTimeout: 180000,
    port: 3307,
    insecureAuth: true
});

const defaultTmp = {
    template: "*",
    settings: {},
    mappings: {
        _default_: {
            _all: {
                enabled: true
            },
            properties: {}
        }
    }
}

var request = require('request');
var putRequest = function (jsonData, indexName) {
    var url = getLinkAPIupdateTemplate(indexName);
    request.put(url, {json: true, body: jsonData}, function (err, res, body) {
        console.log(res.statusCode + ":" + url);
        if (!err && res.statusCode === 200) {

        }else{
            console.log(err);
        }
    });

}

var addField = function (field, jsonObj) {
    jsonObj.mappings._default_.properties[field] = {
        type: "keyword",
        fields: {
            keyword: {
                ignore_above: 256,
                type: "keyword"
            }
        }
    }
}


var getLinkAPIupdateTemplate = function (indexName) {
    return "http://" + ESInfo.host + ":" + ESInfo.port + "/es/_template/" + indexName;
}

var getIndexName = function (tbName, dbName) {
    return dbName + "__" + tbName;
}

var genJson = function (con, tableName, dbName) {
    con.query("SHOW COLUMNS FROM " + dbName + "." + tableName, function (err, result) {
        var json = JSON.parse(JSON.stringify(defaultTmp));
        // console.log(JSON.stringify(defaultTmp));
        json.template = getIndexName(tableName, dbName);
        if (!err) {
            result.forEach(function (value, index) {

                var field = value.Field;
                if (!field.includes("uid")) return;
                addField(field, json);
            });
            putRequest(json, (getIndexName(tableName, dbName)));
            fs.writeFile("./TemplateJson/" + getIndexName(tableName, dbName) + '.json', JSON.stringify(json), {
                encoding: 'utf8',
                flag: 'w+'
            }, function (err, data) {
                if (err) console.log(err);
                else
                    console.log("Successfully Written to File " + getIndexName(tableName, dbName) + '.json');
            });

        }
    });
}


con.connect(function (err) {
        if (err) {
            console.log("bye bye");
            return;
        }
        console.log("Connected!");
        con.query("SHOW DATABASES", function (err, result) {
            if (err) throw err;

            result.forEach(function (element) {
                    var dbname = element.Database;
                    if (dbname.includes("db30shine_")) {
                        con.query("SHOW TABLES FROM " + dbname + "", function (err, result) {
                            if (!err) {
                                result.forEach(function (value, index) {
                                    var tableName = value["Tables_in_" + dbname];
                                    genJson(con, tableName, dbname);
                                });
                            }
                        });
                    }
                }
            );

        });
    }
);

//var a = Object.assign({}, defaultTmp);
