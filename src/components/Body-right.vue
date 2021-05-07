<template >
     <div class="container-content">
        <MSHeader></MSHeader>
        <MSContent ></MSContent>
     </div>
</template>

<script>
import MSHeader from "./ComponentChild/MSHeader.vue"
import MSContent from "./ComponentChild/MSContent.vue"
export default {
   name: "body-right",
   components: {
      MSHeader ,
      MSContent
   },
   methods:{
    
      
   }
}
</script>

<style>
.container-content{
   position: absolute;
   top: 0;
   right: 0;
   bottom: 0;
   border-left: 1px solid #8a8989 ;
   width: calc(100% - 226px);
}
</style>