<template>
  <div id="app">
    <img src="./assets/logo.png">
    <Hello></Hello>
  </div>
</template>
<!--在Script 中 导入Hello.vue 作为组件，
components中也得写上
-->
<script>
import Hello from './components/Hello' 
export default {
  name: 'App',
  components:{
    Hello
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
