<script setup lang="ts">
import { axiosUrls } from '@/axiosUrls/axiosUrls'
import router from '@/router'
import type { CatType } from '@/types/CatType'
import axios from 'axios'
import { onBeforeMount, onMounted, ref, type Ref } from 'vue'
import ScrollReveal from 'scrollreveal'
const cat: Ref<CatType> = ref({ id: '', name: '', color: '', age: 0, image: '' })

const getCat = async () => {
  const data: Promise<CatType> = axios
    .get(axiosUrls.getCatUrl + `${router.currentRoute.value.params.id}`)
    .then((res) => {
      return res.data
    })
  return data
}

onBeforeMount(async () => {
  cat.value = await getCat()
})

onMounted(() => {
  setTimeout(() => {
    ScrollReveal().reveal('.return-to-cats-container', { delay: 1500 })
    ScrollReveal().reveal('.cat-element', { delay: 250 })
    ScrollReveal().reveal('.cat-photo', { delay: 650 })
    ScrollReveal().reveal('.cat-description', { delay: 1000, interval: 120 })
  }, 0)
})
</script>

<template>
  <div id="CatDetailsComponent">
    <div class="return-to-cats-container">
      <RouterLink to="/browse">&lt Return to cats</RouterLink>
    </div>
    <div class="cat-element">
      <img :id="cat.id" class="cat-photo" alt="cat-photo" draggable="false" :src="cat.image" />
      <h2 class="cat-description">Hello, my name is {{ cat.name }}</h2>
      <h3 class="cat-description">I am {{ cat.age }} years old</h3>
      <h4 class="cat-description">My fur is {{ cat.color }}</h4>
    </div>
  </div>
</template>

<style scoped>
#CatDetailsComponent {
  margin-top: 30px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  gap: 30px;
  margin-bottom: 10vmin;
}
.cat-element {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  gap: 10px;
  padding: 30px;
  outline: 2px solid rgba(0, 0, 0, 0.2);
  border-radius: 5px;
  transition: outline 0.2s ease-in-out;
}
.cat-element:hover {
  outline: 2px solid rgba(0, 0, 0, 0.471);
}
.cat-photo {
  object-fit: contain;
  height: auto;
  width: auto;
  max-width: 85vmin;
  max-height: 85vmin;
  object-fit: contain;
  border-radius: 7px;
}

.return-to-cats-container {
  font-size: 2.2vmin;
  font-weight: bold;
  user-select: none;
}
.return-to-cats-container a {
  padding: 1vmin 1.5vmin 1vmin 1.5vmin;
  border: 2px var(--green-main-color-darker) solid;
  border-radius: 50px;
  background-color: var(--green-main-color);
  color: whitesmoke;
}

.return-to-cats-container a:hover {
  background-color: whitesmoke;
  color: var(--green-main-color);
}

@media (max-width: 600px) {
  .return-to-cats-container {
    font-size: 3vmin;
  }

  .return-to-cats-container a {
    padding: 1.5vmin 2vmin 1.5vmin 2vmin;
  }

  .cat-photo {
    object-fit: contain;
    height: auto;
    width: auto;
    max-width: 88vmin;
    max-height: 88vmin;
    object-fit: contain;
    border-radius: 7px;
  }

  .cat-element {
    padding: 13px;
  }
}

@media (prefers-color-scheme: dark) {
  .cat-element {
    outline: 2px solid rgba(154, 154, 154, 0.2);
  }
  .cat-element:hover {
    outline: 2px solid rgba(255, 255, 255, 0.296);
  }
  .return-to-cats-container a {
    background-color: var(--green-main-color-darker);
    border: 2px var(--green-main-color-darkest) solid;
  }
  .return-to-cats-container a:hover {
    background-color: var(--vt-c-black-soft);
    color: var(--green-main-color-lighter);
  }
}
</style>