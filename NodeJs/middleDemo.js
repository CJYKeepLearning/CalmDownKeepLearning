const express = require('express')
const app = express()

const mw = function(req,res,next){
    console.log('这是一个中间件函数')
    next()
}
app.use((req,res)=>{
    const time = Date.now()
    //为req对象挂载time属性，方便之后的中间件或者路由使用
    req.startTime = time
})
app.get('/',(req,res)=>{
    res.send('req为同一个:'+req.startTime)
})
app.listen(80,()=>{
    console.log('http://127.0.0.1')
})
