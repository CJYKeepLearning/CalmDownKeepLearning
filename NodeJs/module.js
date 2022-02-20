const username = '张三'
function printName(){
    console.log(username)
}
module.exports.username = username
module.exports.printName = function printName(){}