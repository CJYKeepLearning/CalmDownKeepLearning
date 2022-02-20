const express = require('express')

const app = express()
//对外提供静态资源
app.use(express.static('../clock'))     //http://127.0.0.1/index.html
//挂载前置路径
app.use('public',express.static('../clock')) //http://127.0.0.1/public/index.html
app.listen(80,()=>{
    console.log('express server')
})