const fs = require('fs')
const path = require('path')
const http = require('http')
const server = http.createServer()

server.on('request',(req,res) => {
    const url = req.url
    if(url === '/clock/index.html'){
        const fpath = path.join(__dirname,url)
        fs.readFile(fpath,'utf8',(err,dataStr)=>{
            res.end(dataStr)
        })
    }
})
server.listen(80,(req,res)=>{
    console.log('visit.....')
})