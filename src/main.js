import Vue from 'vue'
import App from './App.vue'
import  './filter/filter'
import './content/libs/axios.js'
Vue.config.productionTip = false

new Vue({
  render: h => h(App)
}).$mount('#app')
