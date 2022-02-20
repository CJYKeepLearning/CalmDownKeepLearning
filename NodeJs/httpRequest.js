const http = require('http')

const server = http.createServer()

server.on('request', function (req,res){
    const url = req.url
    const method = req.method
    const str = `req.url = ${url} method = ${method}`
    res.end(str)
    console.log('Someone visit our web server')
    //resxiang
})

server.listen(80, function(req){
    console.log('server running http://127.0.0.1')
})