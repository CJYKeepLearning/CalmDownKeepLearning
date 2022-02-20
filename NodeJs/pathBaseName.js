const path = require('path')

const fpath = '/a/c/index.html'
//path.basename() 获取到文件的名称部分
const name = path.basename(fpath)
console.log(name) //index.html

//path.basename(,'.html') 移除扩展名  
const name = path.basename(fpath,'.html')
console.log(name) //index

//path.extname() 获取路径的扩展名部分
const name = path.extname(fpath)
console.log(name) //.html