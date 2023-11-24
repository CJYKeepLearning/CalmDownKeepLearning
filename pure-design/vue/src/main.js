import Vue from 'vue'
import App from './App.vue'
import router from './router'
// 引入ElementUI
import ElementUI from 'element-ui';
import 'element-ui/lib/theme-chalk/index.css';
import store from './store'
import './/assets/global.css'
//路由
import request from './utils/request';
Vue.prototype.request = request

Vue.config.productionTip = false
Vue.use(ElementUI, {size: 'mini'});



new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
