<template>
    <div>
        <h1 class="fa fa-camera-retro">{{myTitle}}</h1>
        <h2>{{my2Title}}</h2>
    </div>
</template>
<!--props 自定义的属性。这样在内部<template>以及外面（APP.vue）就可以使用myTitle了-->
<script>
export default {
    props:["myTitle","my2Title"],
    data:function(){
        return{
            title:'电影名称'
        }
    }
}
</script>
