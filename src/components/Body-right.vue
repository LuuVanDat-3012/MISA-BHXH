<template>
  <div class="container-content">
    <MSHeader></MSHeader>
    <MSContent ></MSContent>
    <MSDialog
     
    ></MSDialog>
  </div>
</template>
 <!-- @closeDialog="closeDialog()"

      @clickToShowDialog="displayDialog()"
      v-bind:customer="this.customer" -->
<script>
import MSHeader from "./ComponentChild/MSHeader.vue";
import MSContent from "./ComponentChild/MSContent.vue";
import MSDialog from "../content/dialog/MSdialog.vue";
export default {
  name: "body-right",
  components: {
    MSHeader,
    MSContent,
    MSDialog,
  },
  data() {
    return {
      isActive: false,
      customer: null
    };
  },
  methods: {
    displayDialog() {
      this.isActive = true;
    },
    closeDialog() {
      this.isActive = false;
    },
    /**
     * dua du lieu len dialog
     */
    updateCustomer(val){
      console.log("Ham update da duoc goij trong BODY RIGHT" +  val.customerCode);  
    },
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
