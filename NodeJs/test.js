const mytools = require('./myFoling-tools/index')

const htmlStr = '<h1>这是尝试一下是否正确<span>123&nbsp;</span></h1>'

const newStr = mytools.htmlEscape(htmlStr)

console.log(newStr)