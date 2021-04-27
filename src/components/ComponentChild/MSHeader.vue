<template >
    <div class="container">

          <div class="listRes">
              
          </div>

          <div class="user">
                <div class="icon user">

                </div>
                <div class="username">

                </div>
          </div>
    
    </div>
</template>

<script>
export default {
   name: "MSHeader",
      data () {
        return {
            select: ['Vuetify', 'Programming'],
            items: [
            'Programming',
            'Design',
            'Vue',
            'Vuetify',
            ]
        }
    }
}
</script>

<style>
.container{
    position: absolute;
    left: 201px;
}


</style>