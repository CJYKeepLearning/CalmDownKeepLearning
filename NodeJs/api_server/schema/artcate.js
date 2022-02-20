const joi = require('joi')

// 定义 分类名称 和 分类别名 的校验规则 
const name = joi.string().required() 
const alias = joi.string().alphanum().required()
const id = joi.number().integer().min(1).required()
//验证添加文章分类
exports.add_artcate_schema = {
    body:{
        name,
        alias,
    },
}
//删除文章分类
exports.delete_cate_schema = {
    params: { id, },
}
//根据Id获取文章
exports.get_cate_schema = { 
    params: { id, }, 
}
//更新文章
exports.update_cate_schema = { 
    body: { 
        Id: id, 
        name, 
        alias, 
    }, 
}