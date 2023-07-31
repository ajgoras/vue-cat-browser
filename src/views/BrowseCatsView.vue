<script setup lang="ts">
import CatComponent from '@/components/CatComponent.vue'
import type { CatType } from '@/types/CatType'
import axios from 'axios'
import { onBeforeMount, ref, watch, type Ref } from 'vue'

const cats: Ref<CatType[]> = ref([])
const activeCat: Ref<string> = ref('')

var observer = new IntersectionObserver(onIntersection, {
  root: null,
  threshold: 0.8
})
function onIntersection(entries: any) {
  entries.forEach((entry: any) => (activeCat.value = entry.target.id.substring(4)))
}
setTimeout(() => {
  cats.value.forEach((cat) => {
    observer.observe(document.getElementById(`cat-${cat.id}`)!)
  })
}, 100)

const getCats = async () => {
  const { data }: { data: CatType[] } = await axios.get('http://localhost:5143/api/cats')
  return data
}

onBeforeMount(async () => {
  cats.value = await getCats()
  setTimeout(() => {
    activeCat.value = cats.value[0].id
  }, 70)
})

watch(activeCat, () => {
  const catName = cats.value.find(({ id }) => id === activeCat.value)
  if (catName) {
    activeCat.value = catName?.name
  }
})
</script>

<template>
  <div id="main">
    <h1>Cats</h1>
    <div class="cats-container">
      <div class="cats-list">
        <p class="cat-name">{{ activeCat }}</p>
      </div>
      <div class="cat-component-container">
        <CatComponent
          :id="`cat-` + cat.id"
          :key="cat.id"
          v-for="cat of cats"
          :cat="cat"
        ></CatComponent>
      </div>
    </div>
  </div>
</template>

<style scoped>
#main {
  margin-top: 50px;
  margin-left: 50px;
  margin-right: 50vmin;
}

.cats-list {
  position: fixed;
  top: 45vmin;
  left: 10vmin;
}

.cat-component-container {
  width: 60%;
  margin: auto;
  margin-right: -10vmin;
}

.cat-name {
  font-size: 6vmin;
}
</style>
