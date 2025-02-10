<template>
  <div>
    <Login v-if="!loggedIn" @login-success="loggedIn = true" />
    <MemoryPalace v-if="loggedIn" />
  </div>
</template>
<script>
import Login from "./components/Login.vue";
import MemoryPalace from "./components/MemoryPalace.vue";
export default {
  components: { Login, MemoryPalace },
  data() { return { loggedIn: false }; }
};
</script>
