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
  height: 100%;
  width: 100%;
  object-fit: contain;
}
</style>
