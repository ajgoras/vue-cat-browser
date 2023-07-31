<template>
  <div id="main">
    <h1>Sorry, can't find anything at this address</h1>
    <img src="../assets/sad-cat.png" />
    <div class="home-button-container">
      <RouterLink to="/">Go back to main page</RouterLink>
    </div>
  </div>
</template>
<style scoped>
#main {
  margin-top: 120px;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 5vmin;
}
img {
  height: 15vmax;
  width: 15vmax;
}
h1 {
  font-size: 5vmin;
}

.home-button-container {
  margin-top: 30px;
  font-size: 3.5vmin;
  font-weight: bold;
  user-select: none;
}
.home-button-container a {
  padding: 2vmin 2.5vmin 2vmin 2.5vmin;
  border: 2px var(--green-main-color-darker) solid;
  border-radius: 50px;
  background-color: var(--green-main-color);
  color: whitesmoke;
}

.home-button-container a:hover {
  background-color: whitesmoke;
  color: var(--green-main-color);
}

@media(prefers-color-scheme: dark){
  .home-button-container a {
    background-color: var(--green-main-color-darker);
  }
  .home-button-container a:hover {
    background-color: var(--vt-c-black-soft);
    color: var(--green-main-color-lighter);
  }
}
</style>
