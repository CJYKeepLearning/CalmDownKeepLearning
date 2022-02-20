const mysql = require('mysql')

const db = mysql.createPool({
    host: '127.0.0.1',
    user: 'root',
    password: 'folingmysql',
    database: 'my_db'
})
const user = { name:'ww' ,age:30}
//待执行的SQL语句，?代表占位符
const sqlStr = 'insert into users (name,age) values(?,?)'
//使用数组的形式，为?指定具体的值
db.query(sqlStr,[user.name,user.age],(err,results)=>{
    if(err) return console.log(err.message)
    if(results.affectedRows === 1){
        console.log('插入数据成功')
    }
})
//快捷插入数据
const user = { name:'cl' ,age:40}
const sqlStr = 'insert into users set ?'
db.query(sqlStr,user,(err,results)=>{
    if(err) return console.log(err.message)
    if(results.affectedRows === 1){
        console.log('插入数据成功')
    }
})