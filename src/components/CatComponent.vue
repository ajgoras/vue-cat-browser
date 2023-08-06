<script setup lang="ts">
import type { CatType } from '@/types/CatType'
import ScrollReveal from 'scrollreveal'
import { onMounted } from 'vue'

const props = defineProps<{
  cat: CatType
}>()

onMounted(() => {
  ScrollReveal().reveal('.cat-element', { delay: 10, duration: 900, viewFactor: 0.3 })
})
</script>

<template>
  <div class="cat-element">
    <img :id="cat.id" class="cat-photo" alt="cat-photo" draggable="false" :src="cat.image" />
  </div>
</template>

<style scoped>
.cat-element {
  height: 58vmax;
  width: 58vmax;
}

.cat-photo {
  position: relative;
  top: 14vmin;
  height: auto;
  width: auto;
  max-width: 100%;
  max-height: 100%;
  object-fit: contain;
  border-radius: 7px;
  outline: transparent 3px solid;
  transition: outline ease-in-out 0.15s;
}
.cat-photo:hover {
  outline: var(--green-main-color) 3px solid;
  cursor: pointer;
}
@media (max-width: 1100px) {
  .cat-element {
    height: 75vmax;
    width: 75vmax;
  }
}

@media (max-width: 770px) {
  .cat-element {
    height: 88vmin;
    width: 88vmin;
    margin-bottom: 50px;
  }
}

@media (max-width: 540px) {
  .cat-element {
    height: 92vmin;
    width: 92vmin;
    margin-bottom: 140px;
  }
}

@media (max-width: 440px) {
  .cat-element {
    height: 90vmin;
    width: 90vmin;
    margin-bottom: 240px;
  }
}

@media (max-width: 395px) {
  .cat-element {
    height: 89vmin;
    width: 89vmin;
    margin-bottom: 310px;
  }
}

@media (prefers-color-scheme: dark) {
  .cat-photo:hover {
    outline: var(--green-main-color-darker) 3px solid;
  }
}
</style>
