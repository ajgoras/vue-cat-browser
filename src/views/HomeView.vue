<script setup lang="ts"></script>

<template>
  <main>
    <header>
      <div class="grid">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </div>
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

.grid {
  display: grid;
  width: 70vmin;
  grid-template-columns: repeat(5, 1fr);
  transform: rotate(-9deg);
  height: 70vmin;
  grid-gap: 0;
  margin: 18vmin 0 0 -40px;
  background-color: transparent;
  position: relative;
  overflow: hidden;
  background: linear-gradient(to bottom left, rgba(0, 0, 0, 0.186), transparent);
  padding: 1px;
}

.grid div {
  border-top: solid rgba(0, 0, 0, 0.07) 1px;
  border-right: solid rgba(0, 0, 0, 0.07) 1px;
  background-color: white;
}

@media (prefers-color-scheme: dark) {
  h1 {
    color: white;
  }
  .grid {
    background: linear-gradient(to bottom left, rgba(255, 255, 255, 0.186), transparent);
  }
  .grid div {
    border-top: solid rgba(255, 255, 255, 0.07) 1px;
    border-right: solid rgba(255, 255, 255, 0.07) 1px;
    background-color: #181818;
  }
}
</style>
