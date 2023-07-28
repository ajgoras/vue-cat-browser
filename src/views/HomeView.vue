<script setup lang="ts">
import HomeGridComponent from '@/components/HomeGridComponent.vue'
</script>

<template>
  <main>
    <header>
      <HomeGridComponent></HomeGridComponent>
      <h1>YOUR</h1>
      <h1>CAT BROWSER</h1>
      <h1>APPLICATION</h1>
    </header>
  </main>
</template>

<style scoped>
h1 {
  font-family: 'Shadows Into Light', cursive;
  position: absolute;
  font-size: 9.5vmin;
  margin-left: 6vmin;
  color: black;
}

h1:nth-of-type(1) {
  top: -2vmin;
}
h1:nth-of-type(2) {
  top: 9vmin;
}
h1:nth-of-type(3) {
  top: 20vmin;
}

header {
  position: relative;
}

@media (prefers-color-scheme: dark) {
  h1 {
    color: white;
  }
}
</style>
