<template>
    <div class="main-content">
        <div class= "content-header">
              <div class="content-header-text">
                    <h2>Danh sách khách hàng</h2>
              </div>
              <div class="content-header-button">
                    <button class="btnInsert" @click="sayHi()">
                        <div class="btnInsert-icon">

                        </div>
                        <div class="btnInsert-text">
                            Thêm khách hàng
                        </div>         
                    </button>
              </div>
        </div>

        <div class="content-input">
             <div class="input-search">
                    <button class="btnSearch"> </button>
                    <input type="text" class="search-box" placeholder="Tìm kiếm theo tên, email... ">
             </div>
             <div class="input-department">
                 <select name="" id="">
                     <option value="" v-for="department in listDepartment" :key="department">{{department}}</option>
                 </select>
             </div>
             <div class="input-position">
                      <select name="" id="">
                     <option value="" v-for="position in listPosition" :key="position">{{position}}</option>
                 </select>
             </div>

        </div>

    </div>
</template>
<script>
export default {
    name: "mscontent",
    methods:{
        sayHi(){
            alert("Hello");
        }
    },
    data(){
        return{
             listDepartment:[
               'Tất cả phòng ban', 'Phòng tài chính', 'Phòng nhân sự', ' Phòng kế toán' 
             ],
             listPosition:[
                 'Tất cả chức vụ', 'Nhân viên kế toán', 'Nhân viên kinh đoanh', 'Bảo vệ'
             ]    
        }
          
    }
}
</script>
<style scoped>
.main-content .content-header{
    height: 45px;
    width: 100%;
    display: flex;
    padding: 10px;
 }
    .main-content .content-header .content-header-text{
       position: absolute;
      top: 38px;
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
            width: 180px;
            align-items: -18px center;
            display: flex;
        }
        .btnInsert:hover {
            background-color: #2FBEBE;
            cursor: pointer;
        }

            .btnInsert-icon{
                 width: 30px;
                 height: 40px;
                 background-image: url('../../content/icon/add.png');
                 background-repeat: no-repeat;
                 background-position: 10px 9px;
                 position: absolute;
                
        }
            .btnInsert-text{
                position: absolute;
                right: 24px;
            }

.main-content .content-input{
    height: 50px;
    width: 100%;
    display: flex;
    background-color: transparent;
}
    .main-content .content-input .input-search{
        width: 320px;
        height: 43px;
        display: flex;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left:10px ;
        flex-direction: row;
    }
       
        .main-content .content-input .input-search .btnSearch{
                    position: absolute;
                    border-radius: 50%;
                    border: 0;
                    background-color: transparent;
                    height: 43px;
                    width: 45px;
                    outline: 0;
                    background-image: url('../../content/icon/search.png');
                    background-repeat: no-repeat;
                    background-position: center; 
                    padding-left: 5px;
        }
        .main-content .content-input .input-search .btnSearch:hover{
           background-color: #d2d2d2;
           border-radius: 3px;
        }
        .main-content .content-input .input-search .search-box{
                    width: calc(320px - 45px);
                    position: absolute;
                    height: 43px;
                    left: 55px;
                    border: 0;
                    box-sizing: border-box;  
        }
         .main-content .content-input .input-search .search-box:focus{
             outline: 0;
         }


    .main-content .content-input .input-department{
        width: 200px;
        height: 43px;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left: 20px;
    }     
         .main-content .content-input .input-department select{
             box-sizing: border-box;
             height: 43px;
             width: 200px;
             border: 0;
         }


     .main-content .content-input .input-position{
        width: 200px;
        height: 43px;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left: 20px;
    }     
         .main-content .content-input .input-position select{
             box-sizing: border-box;
             height: 43px;
             width: 200px;
             border: 0;
         }

        
            
</style>