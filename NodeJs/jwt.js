const jwt = require('jsonwebtoken')
const expressJWT = require('express-jwt')
const express = require('express')
const app = express()

//注册将jwt解析成json对象的中间件
//配置成功 expressJwt 中间件后，就可以把解析出来的用户信息，挂载到 req.user 属性上
app.use(expressJWT({secret: secretKey}).unless({path: [/^\/api\//]}))  //unless中的path不需要访问权限
//定义secret密钥
const secretKey = 'hhhooll'

app.post('/login',(req,res)=>{
    if(req.body.user.name !== 'admin' || req.body.user.age !='10'){
        res.send({
            status: 400,
            message: '登陆失败'
        })
    }
    //jsonwebtoken 的 sign()方法 生成jwt字符串
    const tokenStr = jwt.sign({name:req.body.name},secretKey,{expiresIn:'30s'})
    res.send({
        status: 200,
        message: '登陆成功!',
        token: tokenStr
    })
})