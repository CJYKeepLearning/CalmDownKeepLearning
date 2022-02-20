const expressJoi = require('@escook/express-joi')
const express = require('express')
const router = express.Router()
const artcate_handler = require('../router_handler/artcate')

//获取校验规则
const {add_artcate_schema,delete_cate_schema,get_cate_schema,update_cate_schema} = require('../schema/artcate')

//获取文章分类
router.get('/cates',artcate_handler.getArticleCates)

//新增文章分类
router.post('/addcates',expressJoi(add_artcate_schema),artcate_handler.addArticleCate)

//删除文章分类
router.post('/deletecate/:id',expressJoi(delete_cate_schema),artcate_handler.deleteCateById)

//根据Id获取文章分类数据
router.post('/cates/:id',expressJoi(get_cate_schema),artcate_handler.getAriticleById)

//更新文章
router.post('/updatecate', expressJoi(update_cate_schema),artcate_handler.updateCateById)
module.exports = router