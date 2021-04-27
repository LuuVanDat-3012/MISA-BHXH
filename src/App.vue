<template>
  <div id="app">
     <BodyLeft></BodyLeft>
  </div>
</template>

<script>
import BodyLeft from "./components/Body-left.vue"
export default {
  name: 'App',
  components: {
   BodyLeft
  },
  data(){
    return{
      name : "luu van dat"
    }
  }
}
</script>

<style>

</style>
