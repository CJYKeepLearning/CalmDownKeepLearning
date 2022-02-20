const fs = require('fs')

const path = require('path')

//匹配正则表达式，分别匹配<style></style> 和 <script></script>
//\s 表示匹配空白 \S表示匹配任意字符  *表示可以重复多次
const regStyle = /<style>[\s\S]*<\/style>/

const regScript = /<script>[\s\S]*<\/script>/

fs.readFile(path.join(__dirname,'./index.html'),'utf8',function(err,dataStr){
    if(err){
        return console.log('读取html失败')
    }
    //读取成功后 拆解出css,js,html三个文件
    resolveCSS(dataStr)
    resolveJS(dataStr)
    resolveHTML(dataStr)
})
//处理CSS样式的方法
function resolveCSS(htmlStr){
    //使用正则提取需要的内容
    const r1 = regStyle.exec(htmlStr)

    const newCSS = r1[0].replace('<style>','').replace('</style>','')

    fs.writeFile(path.join(__dirname,'./index.css'), newCSS, function(err){
        if(err) return console.log('写入css 样式失败!' + err.message)
        console.log('写入CSS成功')
    })
}
//处理JS脚本的方法
function resolveJS(htmlStr){
    const r2 = regScript.exec(htmlStr)
    const newJS = r2[0].replace('<script>','').replace('</script>','')
    fs.writeFile(path.join(__dirname,'./index.js'),newJS,function(err){
        if(err) return console.log('写入js 失败!' + err.message)
        console.log('写入js成功')
    })
}
function resolveHTML(htmlStr){
    //处理HTML文件，将内嵌的<style> 和 <script> 标签 替换为外联的<link>和<script>标签
    const newHTML = htmlStr
    .replace(regStyle,'<link rel="stylesheet" href="./index.css"/>')
    .replace(regScript,'<script src="./index.js"></script>')
    //将替换后的HTML写入到index.html中
    fs.writeFile(path.join(__dirname,'./index.html'),newHTML,err =>{
        if(err) return console.log('写入html 失败!' + err.message)
        console.log('写入html成功')
    })
}