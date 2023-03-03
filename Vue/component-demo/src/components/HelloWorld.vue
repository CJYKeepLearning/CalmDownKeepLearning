<template>
  <div class="hello">
    {{count}}
    <button @click="add">+1</button>

    <ul>
      <li v-for="todo in doneTodos" :key="todo.id" >{{todo.text}}</li>
    </ul>
  </div>
</template>

<script>
  import {mapState,mapGetters, mapMutations} from 'vuex'
  export default{
    name:'HelloWorld',
    computed: {
      ...mapState([
        'count','todos'
      ]),
      ...mapGetters([
        'doneTodos'
      ])
    },
    methods:{
      ...mapMutations([
        'increment'
    ])
    }
  }
</script>
<style scoped>

</style>