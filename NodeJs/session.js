const session = require('express-session')

const express = require('express')

const app = express()
//注册中间件
app.use(session({
    secret: 'itfoling',
    resave: false,
    saveUninitialized: true,
}))
//req.session 使用session  注册中间件后才可使用   
app.post('/api/login',(req,res)=>{
    if(req.body.name !== 'admin' || req.body.age !== '10'){
        return res.send({status: 1, msg: '登陆失败'})
    }
//将用户的信息存储到session中
    req.session.user = req.body   
    req.session.isLogin = true

    res.send({
        status:0,
        msg:'登陆成功'
    })
})
//获取session信息
app.get('/api/name',(req,res)=>{
    if(!req.session.isLogin){
        return res.send({status: 1, msg: '登陆失败'})
    }
    res.send({
        status:0,
        msg:'登陆成功',
        name: req.session.user.name,
    })
})

//清空session信息
app.post('/api/logout',(req,res)=>{
//只清除当前用户的session
    req.session.destroy()
    res.send({
        status:0,
        msg:'退出成功'
    })
})