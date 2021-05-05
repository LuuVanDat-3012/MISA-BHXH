<template >
    <div class="container">
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
.container{
    display: flex;
    justify-content: space-between;
    border-bottom: 1px solid #d2d2d2;
    height: 48px;
}
.listRes{
    padding: 15px;
    font-weight: bold;
    font-size: 18px;
    border: 0;
    width: 150px;
    
}
.listRes select{
    border: 0;
    width: 150px;
}
.container .user{
    display: flex;
    flex-direction: row;
    position: absolute;
    right: 16px;
   
}
.container .user .icon{
    background-repeat: no-repeat;
    background-position: 25px center;
    width: 50px;
    height: 40px;
    background-size: 25px;
}
.container .user .icon.icon-user{
    background-image: url('../../content/icon/avatar-default.png');
}
.container .user .username{
    padding: 12px;
}

</style>