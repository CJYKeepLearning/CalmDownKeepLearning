import MOCk from 'mockjs'
// 使用 mockjs 模拟数据
MOCk.mock('/product/search',{
    "ret":0,
    "data":
    {
        "mtime":"@datetime",
        "score|1-800":1,
        "rank|1-100":1,
        "stars|1-5":1,
        "nickname":"@cname",
        "img":"@image('200x100','#ffcc33','#FFF','png','Fast Mock')"
    }
})