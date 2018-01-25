const INPUT_PATH = './inputjs';
const OUTPUT_PATH = './outputjs';
const fs = require('fs');
var util = require('util');
var obfucating = function (inputContent) {
    var obfuscationResult = JavaScriptObfuscator.obfuscate(
        inputContent,
        {
            compact: false,
            controlFlowFlattening: true
        }
    );
    // console.log(obfuscationResult.getObfuscatedCode());
    return obfuscationResult.getObfuscatedCode();
}


fs.readdir(INPUT_PATH, function (err, files) {
    files.forEach(function (file) {
        if(file.endsWith("-obfuscated.js")){
            var is = fs.createReadStream(INPUT_PATH+"/"+file);
           var os = fs.createWriteStream(OUTPUT_PATH+"/"+file.split("-obfuscated")[0]+".js");

            is.pipe(os);
            is.on('end', function() {
                console.log("Done "+file);
                fs.unlinkSync('./inputjs/'+file);
            });
            is.on('error', function(err) {
                console.log(err);
            });
        }
        // console.log(file);


    });
})
