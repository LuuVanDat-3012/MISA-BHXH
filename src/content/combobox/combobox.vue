<template >
     <div class="container-cbb">
         <select name="" id="">
             <option value="" v-for="res in listRes" :key="res">{{res}}</option>
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
         listRes : Array    
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
         .container-cbb select{
             box-sizing: border-box;
             height: 43px;
             width: 200px;
             border: 0;
         }

</style>