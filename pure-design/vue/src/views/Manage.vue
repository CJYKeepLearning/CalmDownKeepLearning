<template>
  <el-container style="min-height: 100vh;">
    <el-aside :width="sideWidth + 'px' " style=" background-color: rgb(238, 241, 246);">
      <Aside :isCollapse="isCollapse" :logoTextShow="logoTextShow"></Aside>
    </el-aside>
    
    <el-container>
      <el-header style="border-bottom:1px solid #ccc;">
        <Header :collapse="collapse" :collapse-btn-class="collapseBtnClass"></Header>
      </el-header>
      <el-main>
        <!--表示当前页面的子路由在router-view中展示-->
        <router-view></router-view>
      </el-main>
    </el-container>
  </el-container>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'
import Aside from '@/components/Aside.vue';
import Header from '@/components/Header.vue'
export default {
  name: 'HomeView',
  components: {
    HelloWorld,
    Aside,
    Header,
  },
  created(){
  },
  data(){
    const item = {
        date: '2016-05-02',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1518 弄'
      };
    return{
      msg:"hhhh",
      collapseBtnClass: 'el-icon-s-fold',
      isCollapse:false,
      sideWidth:200,
      logoTextShow:true,
      headerBg: 'headerBg',
    }
  },
  methods:{
    collapse(){
      this.isCollapse = !this.isCollapse
      if(this.isCollapse){
        this.sideWidth=64
        this.collapseBtnClass = 'el-icon-s-unfold'
        this.logoTextShow = false
      }else{
        this.sideWidth=200
        this.collapseBtnClass = 'el-icon-s-fold'
        this.logoTextShow = true
      }
    },
    

  }
}
</script>
<style>
.headerBg{
  background:#afe!important;
}
</style>
