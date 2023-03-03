import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)

const store = new Vuex.Store({
    state:{
        count:0,
        todos:[
            {id:1,text:'.1.',done:true},
            {id:2,text:'.2.',done:false},
            {id:3,text:'.3.',done:true}
        ]
    },
    mutations:{
        increment:state => {
            state.count++
        }
    },
    getters:{
        doneTodos:state => {
            return state.todos.filter(todos => todos.done)
        }
    }
})
export default store