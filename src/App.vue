<template>
   <div>
       <BodyLeft></BodyLeft>
       <BodyRight></BodyRight>
   </div>
</template>

<script>

import BodyLeft  from './components/Body-left.vue';
import BodyRight  from './components/Body-right.vue';
export default {
  components: { BodyLeft },
  name: 'App',
  computed:{
    BodyLeft, BodyRight
  },
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
