import Vue from 'vue'
import App from './App.vue'
// 引入ElementUI
import ElementUI from 'element-ui';
import 'element-ui/lib/theme-chalk/index.css';
Vue.use(ElementUI); 
// 引入font-awesome 图标库
import 'font-awesome/css/font-awesome.min.css';

//引入axios
import axios from 'axios';
 // axios.defaults.baseURL = 'http://localhost:8088'
Vue.prototype.$http = axios
// 引入router
import router from './router';

// 引入Vuex
import Vuex from 'vuex'
Vue.use(Vuex)
import store from './store';
// 引入MockJs 引入时不要设置axios的baseURL
import './mock'
Vue.config.productionTip = false
//实际在创建Vue对象的时候需要将router加载一下
new Vue({
  render: h => h(App),
  router,
  store
}).$mount('#app')
