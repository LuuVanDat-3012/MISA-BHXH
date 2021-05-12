
import moment from 'moment'
export default {
   formatDate (val) {
      if (val) {
         return moment(String(val)).format('DD/MM/YYYY')
      }
   },
   formatGender(val){
      if(val==0) return 'Nam';
      if(val==1) return 'Nữ';
      if(val==2||val==null) return 'Khác';
   },
   // formatName(val){
   //    var arrNum = [0,1,2,3,4,5,6,7,8,9];
   //    for (let index = 0; index < arrNum.length; index++) {
   //       const element = array[index];
   //       if(val.indexOf(element) != -1)
   //          return false;
   //    }
   //    return true;
   // }
}