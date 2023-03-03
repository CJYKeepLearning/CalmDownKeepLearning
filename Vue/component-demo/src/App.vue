<template>
  <div id="app">
    <HelloWorld></HelloWorld>

    <!--声明路由链接-->
    <router-link to="/discover">发现音乐</router-link>
    <hr>
    <router-link to="my">我的音乐</router-link>
    <hr>
    <router-link to="/friends">关注</router-link>
    <!--声明路由占位标签-->
    <router-view></router-view>

    <img alt="Vue logo" src="./assets/logo.png">
    <SingleMovie v-for="movie in movies" :key="movie.id" :myTitle="movie.username" :my2Title="movie.password"></SingleMovie>
    <TableData :tableData="tableData"></TableData>
  </div>
</template>

<script>
import axios from 'axios'
import SingleMovie from './components/SingleMovie.vue'
import TableData from './components/TableData.vue'
import HelloWorld from './components/HelloWorld.vue'
export default {
  name: 'App',
  components: {
    SingleMovie,
    TableData,
    HelloWorld
  },
  data:function(){
    return{
      movies:[],
      tableData:[],
      img:""
    }
  },
  // 组件被创建的时候调用
  // 使用箭头 => 函数来确保作用域一致 箭头函数作用域继承了父级
  created:function(){
    this.$http.get("/user/findAll").then((response)=>{
    this.movies = response.data
    this.tableData = response.data
    })
  },
  // 组件挂载的时候
  mounted:function(){
    axios.get("/product/search").then(res =>{
      console.log(res)
      this.img = res.data.data.img
    })
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
