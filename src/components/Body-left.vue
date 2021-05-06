<template>
   <div class="body-left">
       <div class="sidebar">
           <div class="box-logo">
                 <div class="toggle"></div>
                 <div class="logo"></div>
           </div>
       </div>

       <div class="menu">
            <div class="menu-item">
                <div class="icon overview"></div>
                <div class="menu-item-text">Tổng quan</div>
            </div>
             <div class="menu-item">
                <div class="icon report"></div>
                <div class="menu-item-text">Báo cáo</div>
            </div>
             <div class="menu-item">
                <div class="icon buy"></div>
                <div class="menu-item-text">Mua hàng</div>
            </div>
            <div class="menu-item">
                <div class="icon list-employee"></div>
                <div class="menu-item-text">Danh mục nhân viên</div>
            </div>
               <div class="menu-item">
                <div class="icon setting"></div>
                <div class="menu-item-text">Thiết lập hệ thống</div>
            </div>
       </div>  
       
   </div>
    
</template>
<script>
export default {
   name : "body-left",
   props:{
       val :{
           type: String,
           default : null
       }
   } 
}
</script>

<style scope>
   .body-left {
    background-color: #ffffff;
    width: 226px;
    height: 100%;
    display: flex;
    flex-direction: column;
}

    .body-left .sidebar {
        height: 60px;
        display: flex;
        width: 226px;
        
    }
        .body-left .sidebar .box-logo{
            width: 202px;
            height: 24px;
            position: absolute;
            top: 24px;
            left: 24px;
            display: flex;
        }

            .body-left .sidebar .box-logo .toggle {
                width: 24px;
                height: 24px;
                background-image: url('../content/image/toggle.png');
                background-repeat: no-repeat;
                background-size: contain;
                cursor: pointer;
            }

            .body-left .sidebar .box-logo .logo {
                flex: 1;
                height:24px;
                background-image: url('../content/image/cukcuk-logo.png');
                background-size: contain;
                background-repeat: no-repeat;
                cursor: pointer;
                margin-left: 16px;
            }

    .body-left .menu {
        position: relative;
        flex: 1;
    }

        .body-left .menu .menu-item {
            display: flex;
            align-items: center;
            cursor: pointer;
            height: 44px;
            padding-left: 24px;
        }

            .body-left .menu .menu-item .menu-item-text{
                margin-left: 16px;
            }
            .body-left .menu .menu-item:hover {
                background-color: #E9EBEE;
            }

            .body-left .menu .menu-item .icon {
                width: 20px;
                height: 20px;
                background-repeat: no-repeat;
                background-size: contain;
                background-position: center;
            }

                .body-left .menu .menu-item .icon.overview {
                    background-image: url('../content/icon/dashboard.png');
                }

                .body-left .menu .menu-item .icon.report {
                    background-image: url('../content/icon/report.png');
                }

                .body-left .menu .menu-item .icon.buy {
                    background-image: url('../content/icon/dashboard.png');
                }
                .body-left .menu .menu-item .icon.list-employee {
                    background-image: url('../content/icon/dic-employee.png');
                }
                 .body-left .menu .menu-item .icon.setting{
                    background-image: url('../content/icon/setting.png');
                }


            .body-left .menu .menu-item .item-name {
                width: 150px;
            }
</style>
