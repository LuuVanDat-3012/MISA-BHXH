<template>
   <div class="main-container">
       <BodyLeft></BodyLeft>
       <BodyRight></BodyRight>
 
   </div>
</template>

<script>

import BodyLeft  from './components/Body-left.vue';
import BodyRight  from './components/Body-right.vue';
export default {
  components: { BodyLeft, BodyRight },
  name: 'App',
 
  data () {
      return {
        select: ['Vuetify', 'Programming'],
        items: [
          'Programming',
          'Design',
          'Vue',
          'Vuetify',
        ],
      }
    },
};
</script>
<style scoped>
.main-container{
  display: flex;
  flex-direction: row;
}
</style>
