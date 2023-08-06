<script setup lang="ts">
import CatComponent from '@/components/CatComponent.vue'
import type { CatType } from '@/types/CatType'
import axios from 'axios'
import { onBeforeMount, ref, watch, type Ref, onMounted } from 'vue'
import { axiosUrls } from '../axiosUrls/axiosUrls'
import ScrollReveal from 'scrollreveal'

const cats: Ref<CatType[]> = ref([])
const activeCat: Ref<CatType> = ref({ id: '', name: '', color: '', age: 0, image: '' })
const isCatsLoading: Ref<boolean> = ref(true)
const isCatsLoadingLongerThan5sec: Ref<boolean> = ref(false)

function onIntersection(entries: any) {
  entries.forEach((entry: any) => {
    const catId = entry.target.id.substring(4)
    const catToPaste = cats.value.find((cat) => cat.id == catId)
    if (catToPaste) {
      activeCat.value = catToPaste
    }
  })
}

const getCats = async () => {
  const data: Promise<CatType[]> = axios
    .get(axiosUrls.getCatsUrl)
    .then((res) => {
      setTimeout(() => {
        isCatsLoadingLongerThan5sec.value = true
      }, 5000)
      return res.data
    })
    .finally(() => {
      isCatsLoading.value = false
      let thresholdValue = 0.69
      if (window.innerWidth < 1350) {
        thresholdValue = 0.8
      }
      if (window.innerWidth < 1100) {
        thresholdValue = 1
      }
      const observer = new IntersectionObserver(onIntersection, {
        root: null,
        threshold: thresholdValue
      })
      setTimeout(() => {
        cats.value.forEach((cat) => {
          observer.observe(document.getElementById(`cat-${cat.id}`)!)
        })
        setTimeout(() => {
          activeCat.value = cats.value[0]
        }, 120)
      }, 350)
    })
  return data
}

onBeforeMount(async () => {
  cats.value = await getCats()
})

onMounted(() => {
  ScrollReveal().reveal('.cats-list', { delay: 550 })
  ScrollReveal().reveal('.cat-component-container-parent', { delay: 950 })
  ScrollReveal().reveal('.cat-component-container-loading', { delay: 400 })
})

watch(activeCat, () => {
  const catName = cats.value.find((cat) => cat === activeCat.value)
  if (catName) {
    activeCat.value = catName
  }
})

watch(isCatsLoadingLongerThan5sec, () => {
  setTimeout(() => {
    ScrollReveal().reveal('.loading-information', { delay: 300 })
  }, 0)
})
</script>

<template>
  <div id="BrowseCatsView">
    <h1>Cats</h1>
    <div class="cats-container">
      <div class="cats-list">
        <p v-if="!isCatsLoading" class="cat-name">Cat Name: {{ activeCat.name }}</p>
      </div>
      <div v-if="isCatsLoading" class="cat-component-container-loading">
        <div class="spinner-border text-success" role="status">
          <span class="visually-hidden">Loading...</span>
        </div>
        <h5>Loading Cats..</h5>
        <p class="loading-information" v-if="isCatsLoadingLongerThan5sec">
          You have to wait for the backend server to start up, because it runs on free hosting and
          shuts down after not being used for a while.
        </p>
      </div>
      <div class="cat-component-container-parent">
        <div v-if="!isCatsLoading" class="cat-component-container">
          <CatComponent
            :id="`cat-` + cat.id"
            :key="cat.id"
            v-for="cat of cats"
            :cat="cat"
          ></CatComponent>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
#BrowseCatsView {
  width: 100%;
  margin-top: 50px;
  padding-left: 50px;
  display: grid;
  grid-template-columns: 2fr 5fr;
}

.cats-list {
  position: fixed;
  top: 45vmin;
  left: 3vmax;
}

.cat-component-container {
  float: right;
  margin-right: 0.5vmin;
}

.cat-component-container-loading {
  position: relative;
  display: flex;
  align-items: center;
  flex-direction: column;
  top: 20vmin;
  gap: 10px;
}
.cat-component-container-loading .spinner-border {
  position: relative;
  left: -1vmin;
  margin-bottom: 10px;
}

.cat-name {
  font-size: 4vmax;
}

@media (max-width: 1100px) {
  h1 {
    height: fit-content;
  }
  #BrowseCatsView {
    width: 100%;
    margin-top: 50px;
    padding-left: 50px;
    display: flex;
    justify-content: center;
  }
  .cats-container {
    width: 65vmin;
    margin: auto;
  }
  .cat-component-container {
    margin-bottom: 30vmin;
  }

  .cat-component-container {
    margin-right: -5vmin;
  }
  .cats-list {
    background-color: var(--vt-c-white);
    z-index: 2;
    position: fixed;
    top: 80vh;
    left: 0;
    height: 20vh;
    width: 100vw;
    display: flex;
    justify-content: center;
    align-items: center;
  }
  .cat-name {
    font-size: 7vmin;
  }

  @media (prefers-color-scheme: dark) {
    .cats-list {
      background-color: var(--vt-c-black);
    }
  }
}

@media (max-width: 770px) {
  .cat-component-container {
    margin-right: -4vmin;
  }

  @media (prefers-color-scheme: dark) {
    .cats-list {
      background-color: var(--vt-c-black);
    }
  }
}

@media (max-width: 540px) {
  .cat-component-container {
    margin-top: 15vmin;
    margin-right: -2.5vmin;
  }
  .cats-list {
    top: 75vh;
    height: 25vh;
  }

  @media (prefers-color-scheme: dark) {
    .cats-list {
      background-color: var(--vt-c-black);
    }
  }
}

@media (max-width: 440px) {
  .cat-component-container {
    margin-top: 20vmin;
    margin-right: 1vmin;
  }
  .cats-list {
    top: 70vh;
    height: 30vh;
  }

  @media (prefers-color-scheme: dark) {
    .cats-list {
      background-color: var(--vt-c-black);
    }
  }
}

@media (max-width: 395px) {
  .cat-component-container {
    margin-top: 25vmin;
    margin-right: 2vmin;
  }

  @media (prefers-color-scheme: dark) {
    .cats-list {
      background-color: var(--vt-c-black);
    }
  }
}
</style>
