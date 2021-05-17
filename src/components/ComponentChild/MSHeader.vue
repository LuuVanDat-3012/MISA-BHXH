<template >
    <div class="header-container">
          <div class="listRes">
                 <select name="" id="">
                     <option value="" v-for="res in listRes" :key="res"> {{res}}</option>
                 </select>
          </div>
         
          <div class="user">
                <div class="icon icon-user">
                   
                </div>
                <div class="username">
                    Nguyễn Văn Đông
                </div>
                <div class="moreInfo">

                </div>
          </div>
    
    </div>
</template>

<script>

export default {
   name: "MSHeader",
   components:{
  
   },
      data () {
        return {
           listRes:['Nhà hàng Hà Nội 1', ' Nhà hàng Hà Nội 2', 'Nhà hàng Hà Nội 3'],
           user:{
               image: "../../content/icon/avatar-default.png",
               username : "Nguyễn Văn Đông"
           }
        }
    }
}
</script>

<style>
.header-container{
    display: flex;
    align-items: center;
    border-bottom: 1px solid #d2d2d2;
    height: 60px;
}
.listRes{
    padding: 0px 24px;
    font-weight: bold;
    font-size: 18px;
    border: 0;
    width: 150px;
    vertical-align: middle;    
}
.listRes select{
    border: 0;
    width: 150px;
}
.header-container .user{
    display: flex;
    flex-direction: row;
    position: absolute;
    right: 16px;
    align-items: center;  
}
.header-container .user .icon{
    background-repeat: no-repeat;
    background-position: 25px 7px;
    width: 50px;
    height: 40px;
    background-size: 25px;   
}
.header-container .user .icon.icon-user{
    background-image: url('../../content/icon/avatar-default.png');
    vertical-align: middle;
}
.header-container .user .username{
    padding: 0px 12px;
    text-align: center;
}
.header-container .user .moreInfo{
    background-image: url('../../content/icon/option.png');
    vertical-align: middle;
    width: 30px;
    height: 30px;
    background-repeat: no-repeat;
    background-position: center;   
}

</style>