<template >
     <div class="container-content">
        <MSHeader></MSHeader>
     </div>
</template>

<script>
import MSHeader from "./ComponentChild/MSHeader.vue"
export default {
   name: "body-right",
   components: {
      MSHeader 
   }
}
</script>

<style>
.container-content{
   position: absolute;
   left: 202px;
   top: 0;
   right: 0;
   bottom: 0;
   border-left: 1px solid black ;
   height: 100%;
}
</style>