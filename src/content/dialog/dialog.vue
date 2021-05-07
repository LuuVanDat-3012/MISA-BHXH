<template>
<div class="container-dialog">
     <div class="dialog-model">
    </div>
     <div class="dialog">
            <div class="dialog-title">
                 <div class="dialog-title-text">
                      THÔNG TIN KHÁCH HÀNG
                 </div>
                 <div class="btn-close-dialog">
                     
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
                                     <input type="text" name="customerName">
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
                                     <input type="date" name="customerbỉthday" placeholder="đ/MM/yyyy">
                                 </div>
                            </div>
                        </div>
                   </div>
                        <!-- bên phải -->
                        <div class="input-half">
                              <div class="input-code input-common">
                                 <div class="input-title">Họ và tên <b style="color: red">(*)</b></div>
                                 <div class="input-box">
                                     <input type="text" name="customerName">
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
                                                        <input type="text" name="customerCodeCard">
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
                                    
                                </div>
                                <div class="btn-save">
                                    LƯU
                                </div>
                        </div> 
        </div>   
    </div>       
</div>
    

  
</template>
<script>

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
   }
}
</script>
<style scoped>
/*
    làm mờ
*/
.dialog-model{
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color:#ccc;
    z-index: 9;
    opacity: 0.4;
}
.dialog{
    width: 900px;
    height: 700px;
    background-color: #FFFFFF;
    z-index: 99999999;
    position: absolute;
    top: calc(50% - 410px);
    left: calc(50% - 435px);
   
}
.dialog-content{
    display: flex;
    flex-direction: column ;
}

/* CSS title of dialog */
.dialog-title{
    display: flex;
    height: 50px;
}
.dialog-title-text{
    font-size: 30px !important;
    font-weight: bold;
    padding-top: 24px;
    padding-left: 24px;
}
.btn-close-dialog{
    width: 24px;
    height: 24px;
    background-image: url('../../content/icon/close-button.png');
    background-repeat: no-repeat;
    background-position: center;
    background-size: contain;
    background-color: #ccc;
    position: absolute;
    right: 0;
}

/* CSS for content dialog */
.content-up{
    width: 100%;
    height: 300px;  
    margin-top: 24px;
    display: flex;
}
    .input-image{
        width: 300px;
        height: 300px;
        display: flex;
        flex-direction: column;
        align-items: center;
    }
       .image-icon{
            width: 300px;
            height: 200px;
       }
       .image-icon div{
           width: 200px;
           height: 200px;
            background-image: url('../../content/image/default-avatar.jpg');
            background-repeat: no-repeat;
            background-position: center;
            background-size: contain;
            border-radius: 50%;
            border: 2px solid #ccc;
            position: absolute;
            left: 50px;
       }
       .image-text{
            flex: 1; 
            padding-top: 5px;
       }
       .image-text div{
           width: 200px;
           height: 30px;
           text-align: center;
       }
       .image-text div b{
          align-content: center;
       }
/* CSS phần input đầu tiên */
input[type=radio] {
    border: 0px;
    width: 100%;
    height: 2em;
}
.input-info-up{
    flex: 1;
    display: flex;
}
.input-half{
    width: 288px;
    height: 300px;
    padding-right: 30px;
}
    .input-common{
        height: 100px;
        display: flex;
        flex-direction: column;
    }
        .input-title{
            width: 100%;
            height: 30px;
        }
        .input-box{
            flex: 1;
        }
        .input-box input{
            height: 40px;
            width: 260px;
            border: 1px solid #d2d2d2;
            border-radius: 3px;
            padding-left:8px;
        }
        .input-box input:focus{
            outline: 0;
            border: 1px solid #019160;
            border-radius: 3px;
        }
        .input-box input:hover{
            outline: 0;
            border: 1px solid #019160;
            border-radius: 3px;
        }
         .input-box select{
            height: 40px;
            width: 260px;
            border: 1px solid #d2d2d2;
            border-radius: 3px;
            padding-left:8px ;
        }
        .radioGender{
            display: flex;
            align-content: center;
            
        }
        .radioGender div{
            width: 95px;
            height: 40px;
            display: flex;
            align-content: center;
            margin-top: 10px;
        }
        .radioGender div label{
            padding-left: 10px;
        }
       
        .radioGender input{
            color: #019160;
            height: 20px;
            width: 20px;     
        }


        /* CSS INPUT center */
.input-center{
    width: 900px;
    height: 240px;
    position: absolute;
    left: 0;
    top: 360px;
    display: flex;
    flex-direction: column;
}
.input-center-row{
    height: 80px;
    width: 100%;
    display: flex;
}
.input-center-left{
    width: 588px;
    height: 100px;
    padding-left: 24px;
}
.input-center-left input{
    width: 537px;
    height: 40px;
    border: 1px solid #ccc;
    padding: 10px;
}
.input-center-left input:focus{
     outline: 0;
     border: 1px solid #019160;
     border-radius: 3px;
}
.input-center-left input:hover{
     outline: 0;
     border: 1px solid #019160;
     border-radius: 3px;
}
.input-center-right{
    margin-left: 25px;
}
.box-center-address{
    width: 844px;
    height: 40px;
   
}
.box-center-address input{
    width: 845px;
    height: 40px;
    border: 1px solid #d2d2d2;
    padding-left: 10px;
    
}
.input-center-address{
    padding-left: 24px;
}

.box-center-address input:focus{
     outline: 0;
     border: 1px solid #019160;
     border-radius: 3px;
}
.box-center-address input:hover{
     outline: 0;
     border: 1px solid #019160;
     border-radius: 3px;
}

/* FOOTER */
.dialog-footer{
    width: 900px;
    background-color: #E9BEBE;
    height: 70px;
    position: absolute;
    bottom: 0;
}



</style>