<script setup lang="ts">
import CatComponent from '@/components/CatComponent.vue'
import type { CatType } from '@/types/CatType'
import axios from 'axios'
import { onBeforeMount, ref, watch, type Ref, onMounted } from 'vue'
import { axiosUrls } from '../axiosUrls/axiosUrls'
import ScrollReveal from 'scrollreveal'

const cats: Ref<CatType[]> = ref([])
const activeCat: Ref<string> = ref('')
const isCatsLoading: Ref<boolean> = ref(true)
const isCatsLoadingLongerThan5sec: Ref<boolean> = ref(false)

const observer = new IntersectionObserver(onIntersection, {
  root: null,
  threshold: 0.8
})
function onIntersection(entries: any) {
  entries.forEach((entry: any) => (activeCat.value = entry.target.id.substring(4)))
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
      setTimeout(() => {
        cats.value.forEach((cat) => {
          observer.observe(document.getElementById(`cat-${cat.id}`)!)
        })
        setTimeout(() => {
          activeCat.value = cats.value[0].id
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
  const catName = cats.value.find(({ id }) => id === activeCat.value)
  if (catName) {
    activeCat.value = catName?.name
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
        <p class="cat-name">{{ activeCat }}</p>
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
  margin-left: 50px;
  margin-right: 50vmin;
  display: grid;
  grid-template-columns: 2fr 5fr;
}

.cats-list {
  position: fixed;
  top: 45vmin;
  left: 10vmin;
}

.cat-component-container {
  float: right;
  margin-right: 5.8vmin;
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
  font-size: 6vmin;
}
</style>
