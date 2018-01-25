// var mysql = require('mysql');
// var fs = require('fs');
//
//
// var conn = mysql.createConnection({
//     host: "192.168.1.12",
//     user: "root",
//     password: "test",
//     connectTimeout: 180000,
//     port: 3307,
//     insecureAuth: true
// });
//
//
// conn.connect(function (err) {
//     if (err) throw err;
//     console.log("Connected");
//
//     conn.query("SHOW DATABASES", function (err, dbInfo) {
//         if (err) throw err;
//         dbInfo.forEach(function (value) {
//             var dbName = value.Database;
//             if (dbName.includes("db30shine_")) {
//                 genSql(dbName);
//             }
//         })
//     })
// });
//
// function cb(sql) {
//
// }
//
// var genSql = function (dbName) {
//     conn.query(`SHOW TABLES FROM ${dbName}`, function (err, tableInfo) {
//         if (err) throw err;
//         var sql = {sql:`create database  ${dbName};\r\nUse ${dbName};\r\n`};
//         tableInfo.forEach(function (value) {
//             var tableName = value["Tables_in_" + dbName];
//             genSql2(dbName, tableName,sql);
//         });
//         // console.log(sql.sql)
//     });
//     // console.log(sql)
// }
//
// var genSql2 = function (dbName, tableName, currentSql) {
//     var sql = `SHOW CREATE TABLE ${dbName}.${tableName}`;
//     conn.query(sql, function (err, val) {
//         var sqlCreateTable = val[0]["Create Table"].replace(/ AUTO_INCREMENT=\d+/);
//         currentSql.sql += sqlCreateTable;
//     })
//     console.log(currentSql.sql);
// }


function a(callback) {
    callback(1);
    console.log("A");

    return b();
}

function b() {
    console.log("B");
    return "b";
}

function c(a,b) {

}

c(a(b),a)