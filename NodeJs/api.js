const express = require('express')
const r = require('./router')

const app = express()
app.use(express.urlencoded({extended:false}))

app.use('/api',r)

app.listen(80,()=>{
    console.log('.....')
})