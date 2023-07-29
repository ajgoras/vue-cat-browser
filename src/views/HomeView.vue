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
      <h2>Browse beautiful cats, upload new, edit</h2>
      <h2>or remove existing cats 🐈‍⬛</h2>
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

h2 {
  font-family: 'Shadows Into Light', cursive;
  position: absolute;
  font-size: 4vmin;
  margin-left: 6.5vmin;
  color: black;
  margin-top: 52vmin;
}
h2:nth-of-type(2) {
  margin-top: 56vmin;
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
  min-width: 250px;
}

@media (max-width: 1100px) {
  header {
    flex-direction: column;
  }
  .cat-home-side-container {
    margin: auto;
    margin-right: 5vmin;
    margin-top: -30vmin;
    z-index: 2;
  }
}

@media (max-width: 480px) {
  h1 {
    font-size: 12vmin;
  }

  h2{
    margin-top: 54vmin;
    font-size: 5.5vmin;
  }
  h2:nth-of-type(2){
    margin-top: 59vmin;
  }

  h1:nth-of-type(1) {
    top: -3vmin;
  }
  h1:nth-of-type(2) {
    top: 8.5vmin;
  }
  h1:nth-of-type(3) {
    top: 21vmin;
  }
  .cat-icon-logo-container {
    top: 3vmin;
    left: 32vmin;
  }

  .cats-paw-logo-container {
    top: 26.5vmin;
    left: 71vmin;
  }

  .cat-home-side-container {
    margin-top: -32vmin;
  }
}

@media (max-width: 400px) {
  .cat-home-side-container {
    margin-top: -40vmin;
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
  .cats-paw-logo {
    content: url('@/assets/cats-paw-inverted.png');
  }
}
</style>
