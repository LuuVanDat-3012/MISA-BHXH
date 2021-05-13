<template>
  <div class="container-content">
    <MSHeader></MSHeader>
    <MSContent @openDialog="displayDialog" @showCustomerInDialog="showInfo"></MSContent>
    <MSDialog v-if="isActive"
    @closeDialog="closeDialog" :customer="customer"></MSDialog>
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
      customer: {
        customerCode: '',
        fullname: '',
        gender:'',
        birthday:'',
        phone:'',
        email:'',
        memberCardCode:'',
        taxCode:'',
        address:'',
        company:''
      }
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
  
    showInfo(data){
      this.isActive = true;
      this.customer = data;
      console.log(this.customer.birthday);
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
