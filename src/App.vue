<template>
   <div class="main-container">
       <BodyLeft></BodyLeft>
       <BodyRight @clickToShowDialog="displayDialog()"></BodyRight>
        <MSDialog v-if="dialog"></MSDialog>
 
   </div>
</template>

<script>

import BodyLeft  from './components/Body-left.vue';
import BodyRight  from './components/Body-right.vue';
import MSDialog from  './content/dialog/dialog.vue';
export default {
  components: { BodyLeft, BodyRight, MSDialog },
  name: 'App',
  data(){
      return{
            dialog : false
      }
     
  },
  methods:{
    displayDialog(){
        this.dialog = true;
    }
  }
 
};
</script>
<style >
*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
.main-container{
  display: flex;
  flex-direction: row;
}
.main-container {
    font-family: MISA-Regular, MISA-Bold, MISA-Italic;
    font-size: 13px;
    margin: 0px;
    padding: 0px;
    height: 100vh;
}

@font-face {
    font-family: 'MISA-Regular';
    src: url('./content/font/GoogleSans-Regular.otf') ;
}

@font-face {
    font-family: 'MISA-Bold';
    src: url('./content/font/GoogleSans-Bold.otf') ;
}

@font-face {
    font-family: 'MISA-Italic';
    src: url('./content/font/GoogleSans-Italic.otf');
}
</style>
