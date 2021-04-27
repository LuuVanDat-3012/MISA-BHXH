<template>
  <div id="app">
     <BodyLeft></BodyLeft>
     <BodyRight> </BodyRight>
  </div>
</template>

<script>
import BodyLeft from  "./components/Body-left.vue"
import BodyRight from "./components/BodyRight.vue"
export default {
  name: 'App',
  components: {
   BodyLeft,
   BodyRight
  }
}
</script>

<style>

</style>
