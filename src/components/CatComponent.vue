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
  transition: outline ease-in-out .15s;
}
.cat-photo:hover{
  outline: var(--green-main-color) 3px solid;
}

@media(prefers-color-scheme:dark){
  .cat-photo:hover{
  outline: var(--green-main-color-darker) 3px solid;
}
}
</style>
