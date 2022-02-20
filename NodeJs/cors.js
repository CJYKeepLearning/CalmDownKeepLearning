//解决跨域问题
const express = require('express')
const r = require('./router')

const app = express()


app.use(express.urlencoded({extended:false}))
//在路由之前配置cors中间件，解决跨域问题
const cors = require('cors')
app.use(cors())

app.use('/api',r)

app.listen(80,()=>{
    console.log('.....')
})