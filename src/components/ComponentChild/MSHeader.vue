<template >
    <div class="container">

          <div class="listRes">
                 <select name="" id="">
                     <option value="" v-for="res in listRes" :key="res"> {{res}}</option>
                 </select>
          </div>

          <div class="user">
                <div class="icon user">
                    image
                </div>
                <div class="username">
                    name
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
           listRes:['Nha hang ha Noi 1', ' Nha hang Ha Noi 2', 'Nha hang Ha Noi 3']
        }
    }
}
</script>

<style>
</style>