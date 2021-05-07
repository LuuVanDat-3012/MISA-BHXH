<template >
     <div class="container-cbb">
         <select name="" id="">
             <option value="" v-for="item in list" :key="item">{{item}}</option>
         </select>
     </div>
</template>
<script>
export default {
     name: "Combobox",
     data(){
         return {

         }
     },
     props:{
         list : Array    
     }
}
</script>
<style scoped>
 .container-cbb{
        width: 200px;
        height: 43px;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left: 20px;
    } 
 .container-cbb:hover{
      border: 1px solid #2FBEBE;
 }  
 .container-cbb:focus{
      border: 1px solid #2FBEBE;
 }      
         .container-cbb select{
             box-sizing: border-box;
             height: 40px;
             width: 198px;
             border: 0;
         }
option{
    border: 0;
}
</style>