<template>
  <div class="container-content" >
    <MSHeader></MSHeader>
    <MSContent @clickToShowDialog="displayDialog()"></MSContent>
    <MSDialog @closeDialog="closeDialog()" v-show="isActive" @clickToShowDialog="displayDialog"></MSDialog>
  </div>
</template>

<script>
import MSHeader from "./ComponentChild/MSHeader.vue";
import MSContent from "./ComponentChild/MSContent.vue";
import MSDialog from '../content/dialog/MSdialog.vue';
export default {
  name: "body-right",
  components: {
    MSHeader,
    MSContent,
    MSDialog
  },
  data(){
    return{
      isActive : false
    }
  },
  methods: {
    displayDialog(){
        this.isActive = true;
    },
    closeDialog(){
        this.isActive = false;
    }
  },
};
</script>

<style>
.container-content {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  border-left: 1px solid #8a8989;
  width: calc(100% - 226px);
}
</style>
