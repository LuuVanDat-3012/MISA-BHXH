<template>
    <div class="main-content">
        <div class= "content-header">
              <div class="content-header-text">
                    <h2>Danh sách khách hàng</h2>
              </div>
              <div class="content-header-button">
                    <button class="btnInsert">
                        <div class="btnInsert-icon">

                        </div>
                        <div class="btnInsert-text">
                            Thêm khách hàng
                        </div>
                        
                    </button>
              </div>
        </div>

        <div class="content-input">

        </div>

    </div>
</template>
<script>
export default {
    name: "mscontent"
}
</script>
<style scoped>
.main-content .content-header{
    height: 50px;
    width: 100%;
    display: flex;
    padding: 10px;
 }
    .main-content .content-header .content-header-text{
        line-height: 50px;
    }
    .main-content .content-header .content-header-button{
        position: absolute;
        right: 15px;
        line-height: 50px;
      
    }
        .btnInsert{
            background-color: #019160;
            height: 40px;
            line-height: 40px;
            color: #fff;
            border-radius: 4px;
            border : 0;
            width: 190px;
            align-items: center;
            display: flex;
        }

            .btnInsert-icon{
                 width: 52px;
                 height: 40px;
                 background-image: url('../../content/icon/add.png');
                 background-repeat: no-repeat;
                 background-position: center;
                 padding-left: 16px;
                 padding-right: 8px;
                 position: absolute;
                
        }
            .btnInsert-text{
                position: absolute;
                right: 24px;
            }

        
            
</style>