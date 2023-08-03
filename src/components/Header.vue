<script setup lang="ts">
import router from '@/router'
import ScrollReveal from 'scrollreveal';
import { onMounted } from 'vue';
const navigateToHome = () => {
  router.push('/')
}
onMounted(() => {
  ScrollReveal().reveal("#Header", {delay:50 , distance: "120px" , origin: "top"})
})
</script>

<template>
  <div id="Header">
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
        <RouterLink to="/about">Credits</RouterLink>
      </nav>
      <div class="browser-cats-container">
        <RouterLink to="/browse">Browse Cats</RouterLink>
      </div>
    </header>
  </div>
</template>

<style scoped>
#Header {
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
  min-height: 80px;
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
.logo:hover {
  cursor: pointer;
}

nav {
  display: flex;
  gap: 5vw;
  font-size: 16px;
  font-weight: bold;
  user-select: none;
}

.browser-cats-container {
  font-size: 16px;
  font-weight: bold;
  margin-right: 20px;
  user-select: none;
}
.browser-cats-container a {
  padding: 7px 8px 7px 8px;
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
  #Header {
    margin: auto;
    width: 70%;
  }
}
@media (max-width: 820px) {
  #Header {
    margin: auto;
    width: 75%;
  }
}
@media (max-width: 768px) {
  #Header {
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
  #Header {
    margin: auto;
    width: 93%;
  }

  nav {
    gap: 3vw;
    font-size: 14px;
  }
  .browser-cats-container {
    margin-right: 10px;
    font-size: 14px;
  }
  .logo {
    border-radius: 50px;
    width: 200px;
    height: auto;
  }
}

@media (max-width: 440px) {
  #Header {
    margin: auto;
    width: 97%;
  }
  nav {
    font-size: 13px;
    gap: 3vw;
  }
  .browser-cats-container {
    margin-right: 5px;
    font-size: 13px;
  }
  .logo {
    border-radius: 50px;
    width: 180px;
    height: auto;
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
