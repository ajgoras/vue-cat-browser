<script setup lang="ts">
import CatComponent from '@/components/CatComponent.vue'
import type { CatType } from '@/types/CatType'
import axios from 'axios'
import { onBeforeMount, ref, type Ref } from 'vue'

const cats: Ref<CatType[]> = ref([])

const getCats = async () => {
  const { data } = await axios.get('http://localhost:5143/api/cats')
  return data
}

onBeforeMount(async () => {
  cats.value = await getCats()
})
</script>

<template>
  <div id="main">
    <h1>Cats</h1>
    <div class="cats-container">
      <div class="cats-list">
        <p class="cat-name" v-for="cat of cats">{{ cat.name }}</p>
      </div>
      <div>
        <CatComponent :key="cat.id" v-for="cat of cats" :cat="cat"></CatComponent>
      </div>
    </div>
  </div>
</template>

<style scoped>
#main {
  margin-top: 50px;
  margin-left: 50px;
}

.cats-container {
  display: grid;
  grid-template-columns: repeat(2, 30%);
}

.cats-list {
  margin-top: 10vmin;
}

.cat-name {
  font-size: 6vmin;
}
</style>
