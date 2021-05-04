<template >
     <div class="container-content">
        <MSHeader></MSHeader>
        <MSContent></MSContent>
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
   }
}
</script>

<style>
.container-content{
   position: absolute;
   left: 232px;
   top: 0;
   right: 0;
   bottom: 0;
   border-left: 5px solid #8a8989 ;
   height: 100%;
   width: calc(100% - 260px);
}
</style>