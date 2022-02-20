const express = require('express')
//创建web服务器
const app = express()
//启动web服务器
app.listen(80,()=>{
    console.log('expree启动服务器')
})
//监听get请求
app.get('/user',(req,res)=>{
    //res.send()向客户端响应一个JSON对象
    res.send({
        name:'zs',
        age:20,
        sex:'男'
    })
})
//监听post请求
app.post('/user',(req,res)=>{
    res.send('请求成功')
})
//req.query获取到客户端发来的 查询参数
//GET方法：http://127.0.0.1/?name-zs&age=20
app.get('/',(req,res)=>{
    res.send(req.query)
})
//req.params时动态匹配到的URL参数，默认也是空对象
//  :id   返回的时候名称即为id “：”后面可进行更改
app.get('/user/:id',(req,res)=>{
    res.send(req.params)
})
//多个动态参数
app.get('/user/:id/:name',(req,res)=>{
    res.send(req.params)
})