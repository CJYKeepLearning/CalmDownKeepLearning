import VueRouter from "vue-router";
import Vue from "vue";
import Discover from "../components/Discover.vue"
import TopList from "../components/TopList.vue"
import PlayList from "../components/PlayList.vue"
import Friends from "../components/Friends.vue"
import My from "../components/My.vue"
import Product from "../components/Product.vue"
Vue.use(VueRouter)

const router = new VueRouter({
    routes:[
        {   path:'/',redirect:"/friends"},
        {   path:'/discover',component:Discover,
                children:[
                    {path:'topList',component:TopList},
                    {path:'playList',component:PlayList}
                ]},
        {   path:'/friends',component:Friends},
        {   path:'/my',component:My,
                children:[
                    {path:':id',component:Product,props:true},
                ]}
    ]
})
// 需要在main.js中使用 ，实际在创建Vue对象的时候需要将router加载一下
export default router