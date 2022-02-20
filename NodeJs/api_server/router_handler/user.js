const db = require('../db/index')
const bcrypt = require('bcryptjs')

const jwt = require('jsonwebtoken')
const config = require('../config')

exports.regUser = (req,res)=>{
    const userinfo = req.body

    if(!userinfo.username || !userinfo.password){
        return res.cc('用户名和密码不能为空')
    }

    const sql = 'select * from ev_users where username = ?'
    db.query(sql,[userinfo.username],(err,results)=>{
        if(err){
            return res.cc(err)
        }
        //用户名是否占用
        if(results.length>0){
            return res.cc('用户名已经占用')
        }
        //未占用 进行注册
        //密码加密
        userinfo.password = bcrypt.hashSync(userinfo.password,10)
        const sql = 'insert into ev_users set ?'
        db.query(sql,{username: userinfo.username, password: userinfo.password},function(err,results){
            if (err) return res.cc(err.message)
            if(results.affectedRows !== 1){
                return res.cc('注册用户失败' )
            }
            return res.send({ status: 0, msg: '注册用户成功' })
        })
    })
}
//登录
exports.login = (req,res)=>{
    const userinfo = req.body
    const sql = 'select * from ev_users where username = ?'
    db.query(sql,userinfo.username,(err,results)=>{
        if(err) return res.cc(err)
        if(results.length != 1) return res.cc('登陆失败')
        //判断密码是否正确   compareSync(用户提交的密码,数据库的密码)
        const compareResult = bcrypt.compareSync(userinfo.password,results[0].password)
        if(!compareResult){
            return res.cc('密码错误')
        }
        //生成token
        const user = {...results[0],password:'',user_pic:''}
        const tokenStr = jwt.sign(user,config.jwtSecretKey,{expiresIn: config.expiresIn})
        //token响应给客户端
        res.send({
            status:0,
            message:'登陆成功',
            token: 'Bearer ' + tokenStr,
        })
    })
}