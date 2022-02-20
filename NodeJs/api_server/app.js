const express = require('express')
const cors = require('cors')
const joi = require('joi')
const app = express()

//解决跨域问题
app.use(cors())
app.use(express.urlencoded({extended:false}))
//托管静态资源文件
app.use('/uploads', express.static('./uploads'))
//优化res.send() 在所有路由之前，封装res.cc函数
app.use(function(req,res,next){
    res.cc = function(err,status = 1){
        res.send({
            status,
            message: err instanceof Error ? err.message : err
        })
    }
    next()
})

//配置解析token中间件
const expressJWT = require('express-jwt')
const config = require('./config')
// 使用 .unless({ path: [/^\/api\//] }) 指定哪些接口不需要进行 Token 的身份认证 
app.use(expressJWT({ secret: config.jwtSecretKey }).unless({ path: [/^\/api\//] }))


// 导入并使用用户路由模块
const userRouter = require('./router/user')
app.use('/api',userRouter)
//注册userinfo路由
const userinfoRouter = require('./router/userinfo')
app.use('/my',userinfoRouter)
//注册artcate路由
const artcateRouter = require('./router/artcate')
app.use('/my/article',artcateRouter)
//注册article路由
const articleRouter = require('./router/article')
app.use('/my/article', articleRouter)
//先导入用户路由模块，再导入错误中间件
// 捕获错误中间件 
app.use(function (err, req, res, next) { 
    // 数据验证失败 
    if (err instanceof joi.ValidationError) return res.cc(err)
    //权限错误
    if(err.name === 'UnauthorizedError') return res.cc('身份认证失败！')
    // 未知错误 
     res.cc(err)
})



app.listen(3007,()=>{

})