<template>
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
</template>
<style scoped>
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