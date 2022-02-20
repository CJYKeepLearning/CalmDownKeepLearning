// 1. 导入express模块
const express = require('express')
// 2.创建路由对象
const router = express.Router()


// 3. 挂载具体的路由
router.get('/get',(req,res)=>{
    const query = req.query
    res.send({
        status:0,
        msg:'GET qingqiuchenggong',
        data: query

    })
})
router.post('/post',(req,res)=>{
    const body = req.body
    res.send({
        status:0,
        msg:'Post成功',
        data:body
    })
})

// 4.暴露路由
module.exports= router