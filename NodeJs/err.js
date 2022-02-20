const express = require('express')
const app =express()

app.get('/',(req,res)=>{
    throw new Error('服务器错误')
    res.send('Home Page')
})
app.use((err,req,res,next)=>{
    console.log('发生了错误'+err.message)
    res.send('Error:'+err.message)
})
app.listen(80,()=>{

})