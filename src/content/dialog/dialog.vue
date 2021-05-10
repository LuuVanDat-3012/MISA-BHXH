<template>
<div class="container-dialog">
     <div class="dialog-model">
    </div>
     <div class="dialog">
            <div class="dialog-title">
                 <div class="dialog-title-text">
                      THÔNG TIN KHÁCH HÀNG
                 </div>
                 <div class="btn-close-dialog" @click="closeDialog()">
                     
                 </div>
            </div>
            <div class="dialog-content">
               <div class="content-up">
                   <div class="input-image">
                        <div class="image-icon">
                            <div></div>
                        </div>
                        <div class="image-text">
                            <div>
                                 Vui lòng chọn ảnh có định dạng <b>.jpg, .png, .gif</b>   
                            </div>  
                        </div>
                   </div>
                   <div class="input-info-up">
                       <!-- Bên trái -->
                        <div class="input-half">
                            <div class="input-code input-common">
                                 <div class="input-title">Mã nhân viên <b style="color: red">(*)</b></div>
                                 <div class="input-box">
                                     <input type="text" name="employeeCode" FieldName = "employeeCode" class="imposition">
                                 </div>
                            </div>
                            <div class="input-code-card input-common" >
                                <div class="input-title">Mã thẻ thành viên</div>
                                 <div class="input-box">
                                     <input type="text" name="customerCodeCard">
                                 </div>
                            </div>
                            <div class="input-birthday  input-common">
                                <div class="input-title">Ngày sinh</div>
                                <div class="input-box">
                                     <input type="date" name="customerbỉthday" placeholder="dd/MM/yyyy">
                                 </div>
                            </div>
                        </div>
                   </div>
                        <!-- bên phải -->
                        <div class="input-half">
                              <div class="input-code input-common">
                                 <div class="input-title">Họ và tên <b style="color: red">(*)</b></div>
                                 <div class="input-box">
                                     <input type="text" name="fullName" class="imposition" @keyup="isRight()">
                                 </div>
                            </div>
                            <div class="input-code-card input-common" >
                                <div class="input-title">Nhóm khách hàng</div>
                                 <div class="input-box">
                                     <select name="groundId" id="">
                                         <option value="">Kế toán</option>
                                         <option value="">Trưởng phòng</option>
                                         <option value="">Phó phòng</option>
                                         <option value="">Nhân sự</option>
                                     </select>
                                 </div>
                            </div>
                            <div class="input-birthday  input-common">
                                <div class="input-title">Giới tính</div>
                                <div class="input-box radioGender">
                                    <div class="male">
                                        <input type="radio" name="customerGender" value="Nam" id="nam">
                                        <label for="nam">Nam</label>
                                    </div>
                                     <div class="female">
                                        <input type="radio" name="customerGender" value="Nữ" id="nu">
                                        <label for="nu">Nữ</label>
                                     </div>
                                     <div class="other">
                                         <input type="radio" name="customerGender" value="Khác" id="khac">
                                        <label for="khac">Khác</label>
                                     </div>
                                 </div>
                            </div>
                        </div>
                   </div>
                   <!-- NỬA DƯỚI -->
                        <div class="input-center">
                                    <div class="input-center-row">
                                        <div class="input-center-left">
                                                <div class="input-title">Email </div>
                                                <div class="box-center-left">
                                                    <input type="text" name="customerEmail" placeholder="example@gmail.com">
                                                </div>
                                        </div>
                                        <div class="input-center-right">
                                                <div class="input-code-card input-common" >
                                                    <div class="input-title">Số điện thoại <b style="color: red">(*)</b></div>
                                                    <div class="input-box">
                                                        <input type="text" name="phoneNumber" class="imposition" @keyup="isRight()">
                                                    </div>
                                                </div>
                                        </div>
                                    </div>

                                    <div class="input-center-row">
                                        <div class="input-center-left">
                                                <div class="input-title">Tên công ty </div>
                                                <div class="box-center-left">
                                                    <input type="text" name="customerEmail" >
                                                </div>
                                        </div>
                                        <div class="input-center-right">
                                                <div class="input-code-card input-common" >
                                                    <div class="input-title">Mã số thuế</div>
                                                    <div class="input-box">
                                                        <input type="text" name="customerTaxCode" placeholder="Nhập mã số thuế"> 
                                                    </div>
                                                </div>
                                        </div>
                                    </div>

                                    <div class="input-center-row">
                                        <div class="input-center-address">
                                                <div class="input-title">Địa chỉ </div>
                                                <div class="box-center-address">
                                                    <input type="text" name="customerAddress" >
                                                </div>
                                        </div>
                                    </div>
                        </div>
                         <!-- FOOTER -->
                        <div class="dialog-footer">
                                <div class="btn-cancel">
                                    HUỶ
                                </div>
                                <div class="btn-save" @click="saveEmployee()">
                                    LƯU
                                </div>
                        </div> 
        </div>   
    </div>       
</div>
    

  
</template>
<script>
import $ from 'jquery'
export default {
   name: "MSDialog",
   components:{
      
   },
   data(){
       return{
           textCode: "Mã khách hàng (*)",
           textName:"Họ vàn tên",
           textCardCode:"Mã thẻ thành viên",
           textPhone:"Số điện thoại",
           textTax:"Mã số thuế"
       }
   },
   methods:{
        closeDialog(){
        this.$emit('closeDialogInApp');
        },
        saveEmployee(){
           var fullname = $("[name='fullname']").val();
        //    var phoneNumber = $("[name='phoneNumber']").val();
        //    var employeeCode = $("[name='employeeCode']").val();
          

           
        },
        isRight(){
            var fullname = $("[name='fullname']").val();
            var phoneNumber = $("[name='phoneNumber']").val();
            var employeeCode = $("[name='employeeCode']").val();
            if(fullname == null || phoneNumber == null || employeeCode == null){
                 $('.input-box .imposition').addClass('noInvalidate');
                 return false;
            }
            
           
        },
        validateData(){

        }
        
   }
  
}
</script>
<style scoped>
/*
    làm mờ
*/
@import url('../../style/root.css');

</style>