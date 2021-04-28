<template>
   <div class="body-left">
       <div class="sidebar">
           <div class="toggle"></div>
           <div class="logo"></div>
       </div>

       <div class="menu">
            <div class="menu-item">
                <div class="icon overview"></div>
                <div>Tổng quan</div>
            </div>
             <div class="menu-item">
                <div class="icon report"></div>
                <div>Báo cáo</div>
            </div>
             <div class="menu-item">
                <div class="icon buy"></div>
                <div>Mua hàng</div>
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
    width: 200px;
    height: 100%;
    
    display: flex;
    flex-direction: column;
}

    .body-left .sidebar {
        height: 50px;
        display: flex;
    }

        .body-left .sidebar .toggle {
            width: 50px;
            height: 50px;
            background-image: url('../content/image/toggle.png');
            background-repeat: no-repeat;
            background-size: 22px;
            background-position: 18px center;
            cursor: pointer;
        }

        .body-left .sidebar .logo {
            width: 138px;
            height: 50px;
            background-image: url('../content/image/cukcuk-logo.png');
            background-size: 126px;
            background-repeat: no-repeat;
            background-position: 0px 9px;
            cursor: pointer;
        }

    .body-left .menu {
        position: relative;
        flex: 1;
    }

        .body-left .menu .menu-item {
            display: flex;
            align-items: center;
            cursor: pointer;
        }

            .body-left .menu .menu-item:hover {
                background-color: #E9EBEE;
            }

            .body-left .menu .menu-item .icon {
                width: 50px;
                height: 45px;
                background-repeat: no-repeat;
                background-size: 22px;
                background-position: 18px center;
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

            .body-left .menu .menu-item .item-name {
                width: 150px;
            }
</style>
