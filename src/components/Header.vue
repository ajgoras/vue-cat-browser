<script setup lang="ts">
import router from '@/router'

const navigateToHome = () => {
  router.push('/')
}
</script>

<template>
  <div id="main">
    <header>
      <img
        draggable="false"
        @click="navigateToHome"
        alt="App logo"
        class="logo"
        src="@/assets/logo.png"
      />
      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/about">About</RouterLink>
      </nav>
      <div class="browser-cats-container">
        <RouterLink to="/browse">Browse Cats</RouterLink>
      </div>
    </header>
  </div>
</template>

<style scoped>
#main {
  margin: auto;
  width: 60%;
}
header {
  outline: 2px solid rgba(0, 0, 0, 0.2);
  margin: -15px 0 0 0;
  padding-top: 15px;
  border-radius: 15px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  transition: outline 0.3s ease-in-out;
}
header:hover {
  outline: 2px solid rgba(0, 0, 0, 0.471);
}

.logo {
  border-radius: 50px;
  width: 265px;
  height: auto;
  content: url('@/assets/logo.png');
  user-select: none;
}

nav {
  display: flex;
  gap: 5vw;
  font-size: 16px;
  font-weight: bold;
}

.browser-cats-container {
  font-size: 16px;
  font-weight: bold;
  margin-right: 20px;
}
.browser-cats-container a {
  padding: 6px 8px 6px 8px;
  border: 2px var(--green-main-color-darker) solid;
  border-radius: 50px;
}

.browser-cats-container a:hover {
  background-color: var(--green-main-color);
  color: whitesmoke;
}

nav a {
  position: relative;
}

nav a:hover {
  color: var(--green-main-color-darker);
}

nav a::after {
  content: '';
  position: absolute;
  bottom: 0;
  left: 0;
  width: 0%;
  height: 0.15em;
  border-radius: 10px;
  background-color: var(--green-main-color-darker);
  height: 2px;
  transition: 0.2s ease-in-out;
}

nav a:hover::after {
  width: 100%;
}

@media (max-width: 1024px) {
  #main {
    margin: auto;
    width: 70%;
  }
}
@media (max-width: 820px) {
  #main {
    margin: auto;
    width: 75%;
  }
}
@media (max-width: 768px) {
  #main {
    margin: auto;
    width: 85%;
  }
  header {
    zoom: 0.85;
  }
  .logo {
    border-radius: 50px;
    width: 240px;
    height: auto;
  }
}

@media (max-width: 540px) {
  #main {
    margin: auto;
    width: 90%;
  }
  header {
    zoom: 0.8;
  }
  nav {
    gap: 3vw;
  }
  .browser-cats-container {
    margin-right: 15px;
  }
}

@media (max-width: 420px) {
  #main {
    margin: auto;
    width: 95%;
  }
  header {
    zoom: 0.75;
  }
  nav {
    gap: 2vw;
  }
  .browser-cats-container {
    margin-right: 10px;
  }
}

@media (prefers-color-scheme: dark) {
  .logo {
    content: url('@/assets/logo-dark.png');
  }
  header {
    outline: 2px solid rgba(154, 154, 154, 0.2);
  }
  header:hover {
    outline: 2px solid rgba(255, 255, 255, 0.296);
  }
  nav a:hover {
    color: var(--green-main-color-lighter);
  }
  nav a::after {
    background-color: var(--green-main-color-lighter);
  }
}
</style>
