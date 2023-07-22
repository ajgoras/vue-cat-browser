<script setup lang="ts"></script>

<template>
  <header>
    <img alt="App logo" class="logo" src="@/assets/logo.png" />
    <nav>
      <RouterLink to="/">Home</RouterLink>
      <RouterLink to="/about">About</RouterLink>
    </nav>
  </header>
</template>

<style scoped>
header {
  outline: 2px solid rgba(0, 0, 0, 0.2);
  margin: -15px 11% 0px 11%;
  padding-top: 15px;
  border-radius: 15px;
  display: flex;
  align-items: center;
  transition: outline .3s ease-in-out;
}
header:hover{
  outline: 2px solid rgba(0, 0, 0, 0.471);
}

.logo {
  border-radius: 50px;
  width: 265px;
  height: auto;
}

nav{
  position: sticky;
  margin-left: 70px;
  display: flex;
  gap: 25px;
  font-size: 16px;
  font-weight: bold;
}

nav a{
  position: relative;
}

nav a:hover{
  color: var(--green-main-color-darker);
}

nav a::after{
  content: '';
  position: absolute;
  bottom: 0;
  left: 0;
  width: 0%;
  height: .15em;
  border-radius: 10px;
  background-color: var(--green-main-color-darker);
  height: 2px;
  transition: .2s ease-in-out;
}

nav a:hover::after{
  width: 100%
}

@media (min-width: 1024px) {
  .greetings h1,
  .greetings h3 {
    text-align: left;
  }
}
</style>
