function dateFormat(dataStr) {
    const dt = new Date(dataStr)
    const y = dt.getFullYear()
    const m = padZero(dt.getMonth())
    const d = padZero(dt.getDate())
    return `${y}-${m}-${d}`
}
function padZero(n) {
    return n>9 ? n:'0'+n
}
module.exports = {
    dateFormat
}