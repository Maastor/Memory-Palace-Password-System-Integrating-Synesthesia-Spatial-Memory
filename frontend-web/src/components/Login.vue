<template>
  <div class="login-container">
    <h2>Login</h2>
    <input v-model="username" placeholder="Username">
    <input v-model="password" type="password" placeholder="Password">
    <button @click="login">Login</button>
  </div>
</template>
<script>
export default {
  data() {
    return { username: "", password: "" };
  },
  methods: {
    login() { console.log("Login Clicked"); }
  }
};
</script>
