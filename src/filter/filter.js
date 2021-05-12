import Vue from 'vue'
import moment from 'moment'

Vue.filter('formatDate', function (val) {
    if (val) {
        return moment(String(val)).format('DD/MM/YYYY')
     }
})

Vue.filter('formatGender', function (val) {
      if(val==0) return 'Nam';
      if(val==1) return 'Nữ';
      return 'Khác';
})
 