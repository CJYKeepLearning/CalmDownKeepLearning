[TOC]

## Web项目流程:

1. 项目根目录中 npm install -y 初始化

2. 创建 app.js  导入express模块，进行初始化

3. 创建router 和 router_handler 文件夹 

4. 创建db 进行连接数据库 和 身份认证

5. 写 router

6. 封装res.cc 函数 用中间件

7. 输入的username 和 password检测

8. 捕获数据验证错误 注册中间件

   **参考apiserver文档**

## fs模块

### 导入fs模块

```javascript
//导入fs模块
const fs = require('fs')
```

### 读取文件

```javascript
//读取文件
fs.readFile('./files/1.txt','utf8',function(err, dataStr){
    if(err){
        console.log(err)
    }
    console.log('---------')
    console.log(dataStr)
})
//注意
1.f.writeFile()只能创建文件，不能创建目录
2.f.writeFile()为覆盖写
```

读失败和写失败时 err 存在，是一个对象，否则不存在

## path 模块

### path.join()

```javascript
const pathStr = path.join('/a','')
// __dirname  表示当时文件所处的目录
const pathStr = path.join(__dirname,'./files/1.txt')//等同pathStr2  
const pathStr2 = fs.readFile(__dirname+'/files/1.txt')
```

## HTML拆分成CSS，JS，HTML三个文件

```javascript
//前期处理
const fs = require('fs')

const path = require('path')

//匹配正则表达式，分别匹配<style></style> 和 <script></script>
//\s 表示匹配空白 \S表示匹配任意字符  *表示可以重复多次
const regStyle = /<style>[\s\S]*<\/style>/

const regScript = /<script>[\s\S]*<\/script>/
```

### 处理CSS

```javascript
function resolveCSS(htmlStr){
    //使用正则提取需要的内容
    const r1 = regStyle.exec(htmlStr)
    const newCSS = r1[0].replace('<style>','').replace('</style>','')
    fs.writeFile(path.join(__dirname,'./index.css'), newCSS, function(err){
        if(err) return console.log('写入css 样式失败!' + err.message)
        console.log('写入CSS成功')
    })
}
```

### 处理JS

```javascript
//处理JS脚本的方法
function resolveJS(htmlStr){
    const r2 = regScript.exec(htmlStr)
    const newJS = r2[0].replace('<script>','').replace('</script>','')
    fs.writeFile(path.join(__dirname,'./index.js'),newJS,function(err){
        if(err) return console.log('写入js 失败!' + err.message)
        console.log('写入js成功')
    })
}
```



### 处理HTML，将内嵌换为link和外链

```javascript
function resolveHTML(htmlStr){
    //处理HTML文件，将内嵌的<style> 和 <script> 标签 替换为外联的<link>和<script>标签
    const newHTML = htmlStr
    .replace(regStyle,'<link rel="stylesheet" href="./index.css"/>')
    .replace(regScript,'<script src="./index.js"></script>')
    //将替换后的HTML写入到index.html中
    fs.writeFile(path.join(__dirname,'./index.html'),newHTML,err =>{
        if(err) return console.log('写入html 失败!' + err.message)
        console.log('写入html成功')
    })
}
```

##  http模块

① 导入 http 模块

② 创建 web 服务器实例

③ 为服务器实例绑定 **request** 事件，监听客户端的请求

④ 启动服务器

```javascript
const http = require('http')
const server = http.createServer()
③ 为服务器实例绑定 request 事件，监听客户端的请求
server.on('request',function (req, res){
    const url = req.url
    const method = req.method
    const str = `req.url = ${url} method = ${method}`
    console(str)
    console.log('Someone visit our web server')
    //设置编码方式
    res.setHeader('Content-Type','text/html; charset=utf-8')
    //res响应对象
    //res.end() 向客户端发送指定内容，并结束这次请求的处理过程
	res.end(str)
})
④ 启动服务器
server.listen(80, function(req){
    const str = 'req.url = '+ req.url + 'req.method = '+req.method
    console.log(str)
})
```

## 模块化

### 模块加载

```javascript
//加载系统模块
const fs = require('fs')
//加载用户自定义模块
// 注意：在使用 require 加载用户自定义模块期间，
// 可以省略 .js 的后缀名
const m1 = require('./06.m1.js')
const m1 = require('./06.m1')
```

**在使用require()方法加载其他模块时，会执行被加载模块中的代码**

### 向外共享模块作用域中的成员

1.module对象

​	每个js文件都有一个module对象，存储了和当前模块有关的信息

2.module.exports.

·**module.exports = {} 为重新赋值一个新对象**

·module.exports.name='张三'   为对象挂载一个name属性

·//require得到的对象永远是以module.exports指向对象为准

3.exports对象相当于module.exports

//最终以module.exports指向对象为准

![exports和module.exports的使用注意点](F:\Notes\CalmDownKeepLearning\NodeJs\NodeJsNote.assets\exports和module.exports的使用注意点.png)

## 模块化规范 CommonJS

CommonJS 规定：

① 每个模块内部，module 变量代表当前模块。

② module 变量是一个对象，它的 exports 属性（即 module.exports）是对外的接口。 

③ 加载某个模块，其实是加载该模块的 module.exports 属性。require() 方法用于加载模块。

## npm与包

搜索平台： http://www.npmjs.com/

下载平台：https://registry.npmjs.org/

package.json:记录项目中安装了哪些包

把node_modules文件夹添加到.gitignore忽略文件中

```shell
npm i 包名 -d

npm i 包名
```

i5ting_toc ：可以将md文档转为html页面的小工具

### 包

一个规范的包，它的组成结构，必须符合以下 3 点要求：

① 包必须以单独的目录而存在

② 包的顶级目录下要必须包含 package.json 这个包管理配置文件

③ package.json 中必须包含 name，version，main 这三个属性，分别代表包的名字、版本号、包的入口。

## 模块化的拆分

```javascript
const date = require('./src/dateFormat')
const html = require('./src/htmlEscape')
//...date 代表将date展开,指展开date对应的module.exports
module.exports = {
    ...date,
    ...html
}
```

## Express

web开发框架

1.web网站的服务器

2.API接口的服务器

```javascript
const express = require('express')
//创建web服务器
const app = express()
//启动web服务器
app.listen(80,()=>{
    console.log('expree启动服务器')
})
//监听get请求
app.get('/user',(req,res)=>{
    //res.send()向客户端响应一个JSON对象
    res.send({
        name:'zs',
        age:20,
        sex:'男'
    })
})
//监听post请求
app.post('/user',(req,res)=>{
    res.send('请求成功')
})
```

### Expres中的路由

1. 请求的类型
2. 请求的URL地址
3. 处理函数

```javascript
const express = require('express')
//创建web服务器
const app = express()
//挂载路由
app.METHOD(PATH,HANDLER)
//例
app.get('/user',(req,res)=>{
    })
})
app.post('/user',(req,res)=>{
})
```

**不建议直接挂载在app上，而是将路由抽离为单独的模块**

将路由抽离为单独模块的步骤如下：

① 创建路由模块对应的 .js 文件

② 调用 express.Router() 函数创建路由对象

③ 向路由对象上挂载具体的路由

④ 使用 module.exports 向外共享路由对象

⑤ 使用 app.use() 函数注册路由模块

单个router模块的js文件

```javascript
// 1. 导入express模块
const express = require('express')
// 2.创建路由对象
const router = express.Router()

// 3. 挂载具体的路由
router.get('/',(req,res)=>{
    res.send('Get Method')
})
// 4.暴露路由
module.exports= router
```

组合在一起的js文件

```javascript
const express = require('express')
const app = express()
//1. 导入路由模块
const router = require('./router')
//2.注册路由模块
app.use(router)  
// 可以添加前缀
app.use('/api',router)
app.listen(80,()=>{
    console.log('http://127.0.0.1')
})
```

**app.use()函数 用来注册中间件 **

### Express中间件

​	当一个请求到达 Express 的服务器之后，可以连续调用多个中间件，从而对这次请求进行预处理。

格式：

```javascript
function(req,res,next){}
```

中间件函数一定包含 next

 处理函数只包含req和res

1. 定义中间件函数

   ```javascript
   const mw = function(req,res,next){
       console.log('这是一个中间件函数')
       next()
   }
   ```

2. 全局生效的中间件

   ```javascript
   	客户端发起的任何请求，到达服务器之后，都会触发的中间件，叫做全局生效的中间件。
   	通过调用 app.use(中间件函数)，即可定义一个全局生效的中间件，示例代码如下：
   //注册成全局生效的中间件
   app.use(mw)
   ```

3. 作用

   ​		多个中间件之间，**共享同一份** **req** **和** **res**。基于这样的特性，我们可以在上游的中间件中，**统一**为 req 或 res 对象添加自定义的属性或方法，供下游的中间件或路由进行使用。

4. 定义多个全局中间件

   根据注册的顺序进行执行

   ```javascript
   const mw = function(req,res,next){
       console.log('这是第一个中间件函数')
       next()
   }
   const mw = function(req,res,next){
       console.log('这是第二个中间件函数')
       next()
   }
   app.use(mw1)
   app.use(mw2)
   ```

5. 局部生效的中间件

   ```javascript
   //mw1,mw2在这个路由生效
   app.get('/user',mw1,mw2,(req,res)=>{
       })
   })
   ```

6. 注意

   1. 路由前注册中间件
   2. 可以连续调用多个中间件
   3. next

7. 几种中间件

   ① 应用级别的中间件

   ② 路由级别的中间件

   ③ 错误级别的中间件

   ```javascript
   function(err, req, res, next){}
   ```

   ④ Express 内置的中间件

   ```javascript
   1.express.static 快速托管静态资源的内置中间件，例如： HTML 文件、图片、CSS 样式等
   2. express.json 解析 JSON 格式的请求体数据
   3. express.urlencoded 解析 URL-encoded 格式的请求体数据
   ```

   ```javascript
   // 注意：除了错误级别的中间件，其他的中间件，必须在路由之前进行配置
   // 通过 express.json() 这个中间件，解析表单中的 JSON 格式的数据
   app.use(express.json())
   // 通过 express.urlencoded() 这个中间件，来解析 表单中的 url-encoded 格式的数据
   app.use(express.urlencoded({ extended: false }))
   
   app.post('/user', (req, res) => {
     // 在服务器，可以使用 req.body 这个属性，来接收客户端发送过来的请求体数据
     // 默认情况下，如果不配置解析表单数据的中间件，则 req.body 默认等于 undefined
     console.log(req.body)
     res.send('ok')
   })
   ```

   ⑤ 第三方的中间件

   ```javascript
   ① 运行 npm install body-parser 安装中间件
   ② 使用 require 导入中间件
   ③ 调用 app.use() 注册并使用中间件
   ```

8. 自定义中间件

   1. 监听req的data事件

      ```javascript
      来获取客户端发送到服务器的数据。
          let str = ' '
          //监听req的data事件
          req.on('data',(chunk)=>{
              str += chunk
          })
      ```

   2. 监听req的end事件

      ```javascript
      当请求体数据接收完毕之后，会自动触发 req 的 end 事件
          req.on('end',()=>{
          })
      ```

   3. querystring模块

      ```javascript
      const qs = require('querystring')
      //把查询字符串解析为对象
      const body = qs.parse(str)
      ```

   4. req.body    

      ```javascript
      //req.query 获取客户端通过查询字符串，发送到服务器的数据    url上的
      //req.body post方法发送的body
      ```

   5. 将自定义中间件封装为模块

      ![image-20220219225411426](F:\Notes\CalmDownKeepLearning\NodeJs\NodeJsNote.assets\image-20220219225411426.png)



## CORS跨域资源共享

### 响应头部

1.只允许部分域的请求

```javascript
//*代表任意域，可替换为具体域的地址
res.setHeader('Access-Control-Allow-Origin','*')
```

2.仅支持发起GET,POST，HEAD请求

```javascript
//*可替换为 'POST,GET,DELETE,HEAD'
res.setHeader('Access-Control-Allow-Methods','*')
```

3.简单请求 / 预检请求

```javascript
简单请求
同时满足以下两大条件的请求，就属于简单请求：
① 请求方式：GET、POST、HEAD 三者之一
② HTTP 头部信息不超过以下几种字段：无自定义头部字段、Accept、Accept-Language、Content-Language、DPR、
Downlink、Save-Data、Viewport-Width、Width 、Content-Type（只有三个值application/x-www-formurlencoded、multipart/form-data、text/plain）

非简单请求 即为 预检请求

简单请求和预检请求的区别
简单请求的特点：客户端与服务器之间只会发生一次请求。
预检请求的特点：客户端与服务器之间会发生两次请求，OPTION 预检请求成功之后，才会发起真正的请求。
```

## mysql

```javascript
const mysql = require('mysql')

const db = mysql.createPool({
    host: '127.0.0.1',
    user: 'root',
    password: 'folingmysql',
    database: 'my_db'
})
const user = { name:'ww' ,age:30}
//------------插入数据--------------
//待执行的SQL语句，?代表占位符
const sqlStr = 'insert into users (name,age) values(?,?)'
//使用数组的形式，为?指定具体的值
db.query(sqlStr,[user.name,user.age],(err,results)=>{
    if(err) return console.log(err.message)
    //判断是否成功
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
//--------------更新数据-----------------
//更新数据
const user = { name:'cl' ,age:50}
const sqlStr = 'update users set age=? where name=?'
db.query(sqlStr,[user.age,user.name],(err,results)=>{
    if(err) return console.log(err.message)
    if(results.affectedRows === 1){
        console.log('更新数据成功')
    }
})
//快捷更新数据
const user = { name:'cl' ,age:50}
const sqlStr = 'update users set ? where name=?'
db.query(sqlStr,[user,user.name],(err,results)=>{
    if(err) return console.log(err.message)
    if(results.affectedRows === 1){
        console.log('更新数据成功')
    }
})
//-------------删除数据-------------------
const sqlStr = 'delete from users where name=?'
db.query(sqlStr,user.name,(err,results)=>{
    if(err) return console.log(err.message)
    if(results.affectedRows === 1){
        console.log('删除数据成功')
    }
})
```

## 身份认证

### session

服务器渲染：Session认证机制

(cookie)会员卡+刷卡认证(session)

### jwt

前后端分离：JWT(JSON Web Token)认证机制

![IMG_5040(20220220-094304)](F:\Notes\CalmDownKeepLearning\NodeJs\NodeJsNote.assets\IMG_5040(20220220-094304).PNG)

JWT=Header.Payload.Signature

### express中使用jwt

```javascript
jsonwebtoken 用于生成JWT字符串
express-jwt  用于把jwt字符串解析还原成json
```

![image-20220220100854883](F:\Notes\CalmDownKeepLearning\NodeJs\NodeJsNote.assets\image-20220220100854883.png)

express-jwt解析失败处理

## 中间件的用途

### @escook/express-joi 

来实现自动对表单数据进行验证的功能

```javascript
npm i @escook/express-joi 
```

### joi

为表单中携带的每个数据项，定义验证规则：

```javascript
npm install joi
```

## 总结

三天学完

着实有点慢

api.server为一个案例

其余为模块

一些解释:

node_modules为下载的模块

package.json为版本记录信息

package-lock.json 为版本记录信息