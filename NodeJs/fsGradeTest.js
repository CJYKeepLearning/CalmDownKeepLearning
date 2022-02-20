const fs = require('fs')
const arrNew = []
fs.readFile('./files/成绩.txt','utf8',function(err,dataStr){
    if(err){
        console.log(err)
    }
    console.log(dataStr)
    const arrOld = dataStr.split(' ');
    console.log('arrOld:'+arrOld)
    arrOld.forEach(item => {
        arrNew.push(item.replace('=',': '))
    })
    const newStr = arrNew.join('\n')
    fs.writeFile('./files/成绩-ok.txt',newStr,function(err){
        if(err){
            console.log(err)
        }
    })
})