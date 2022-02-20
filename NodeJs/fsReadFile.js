//导入fs模块
const fs = require('fs')
//读取文件
fs.readFile('./files/1.txt','utf8',function(err, dataStr){
    if(err){
        console.log(err)
    }
    console.log('---------')
    console.log(dataStr)
})

