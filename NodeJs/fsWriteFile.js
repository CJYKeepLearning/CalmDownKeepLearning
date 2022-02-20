const fs = require('fs')
fs.writeFile('./files/2.txt','Hello,NodeJs',function(err){
    console.log(err)
})