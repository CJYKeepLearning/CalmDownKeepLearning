const express = require('express')
const qs = require('querystring')


const app = express()

app.use(express.json())

app.use(express.urlencoded({ extended: false }))

app.use((req,res,next)=>{
    console.log(req.body)
    let str = ' '
    //监听req的data事件
    req.on('data',(chunk)=>{
        str += chunk
    })
    //监听req的end事件

    req.on('end',()=>{
    //把查询字符串解析为对象
    const body = qs.parse(str)
    //将对象挂载在req.body上
    req.body = body
    })
})

app.post('/user',(req,res)=>{
   res.send('OK') 
})
app.listen(80,()=>{
    console.log("http://127.0.0.1")
})