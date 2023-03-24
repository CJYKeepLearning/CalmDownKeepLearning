const express = require('express')
const app = express()

//1. 导入路由模块
const router = require('./router')

//2.注册路由模块
app.arguments(router)

app.listen(80,()=>{
    console.log('http://127.0.0.1')
})