const date = require('./src/dateFormat')
const html = require('./src/htmlEscape')
module.exports = {
    ...date,
    ...html
}