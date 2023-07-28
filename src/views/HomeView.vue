<script setup lang="ts">
import HomeGridComponent from '@/components/HomeGridComponent.vue'
</script>

<template>
  <main>
    <header>
      <HomeGridComponent></HomeGridComponent>
      <h1>YOUR</h1>
      <div class="cat-icon-logo-container">
        <img
          class="cat-icon-logo"
          alt="cat-icon-logo"
          draggable="false"
          src="@/assets/cat_icon.png"
        />
      </div>
      <h1>CAT BROWSER</h1>
      <h1>APPLICATION</h1>
      <div class="cats-paw-logo-container">
        <img
          class="cats-paw-logo"
          alt="cats-paw-logo"
          draggable="false"
          src="@/assets/cats-paw.png"
        />
      </div>
      <div class="cat-home-side-container">
        <img
          class="cat-home-side"
          alt="cat-photo"
          draggable="false"
          src="@/assets/cat-home-side.png"
        />
      </div>
    </header>
  </main>
</template>

<style scoped>
header {
  position: relative;
  display: flex;
}

h1 {
  font-family: 'Shadows Into Light', cursive;
  position: absolute;
  font-size: 9.5vmin;
  margin-left: 6vmin;
  color: black;
  margin-top: 18vmin;
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

.cat-icon-logo-container {
  position: absolute;
  top: 1vmin;
  left: 30vmin;
  background-color: var(--green-main-color);
  height: 8vmin;
  width: 15vmin;
  border-radius: 10px;
  box-shadow: 6px 8px 8px rgba(0, 0, 0, 0.158);
  margin-top: 18vmin;
}

.cat-icon-logo {
  position: absolute;
  height: 12vmin;
  width: 12vmin;
  left: 1.4vmin;
  top: -4vmin;
}

.cats-paw-logo-container {
  position: absolute;
  top: 24vmin;
  left: 53vmin;
  background-color: var(--green-main-color);
  height: 8vmin;
  width: 9vmin;
  border-radius: 1000px;
  box-shadow: 6px 8px 8px rgba(0, 0, 0, 0.158);
  margin-top: 18vmin;
}

.cats-paw-logo {
  position: absolute;
  height: 13vmin;
  width: 13vmin;
  left: -1.95vmin;
  top: -4.2vmin;
}

.cat-home-side-container {
  margin: auto;
  margin-right: 3vmin;
}

.cat-home-side {
  border-radius: 20px;
  width: 50vmin;
  height: auto;
}

@media (max-width: 1100px) {
  header {
    flex-direction: column;
  }
  .cat-home-side-container {
    margin: auto;
    margin-right: 5vmin;
    margin-top: -25vmin;
    z-index: 2;
  }
}

@media (pointer: coarse) {
  .cats-paw-logo-container {
    position: absolute;
    top: 24vmin;
    left: 58vmin;
    background-color: var(--green-main-color);
    height: 8vmin;
    width: 9vmin;
    border-radius: 1000px;
    box-shadow: 6px 8px 8px rgba(0, 0, 0, 0.158);
    margin-top: 18vmin;
  }
}

@media (prefers-color-scheme: dark) {
  h1 {
    color: white;
  }
  .cat-icon-logo-container {
    background-color: var(--green-main-color-darker);
  }
  .cats-paw-logo-container {
    background-color: var(--green-main-color-darker);
  }
}
</style>
