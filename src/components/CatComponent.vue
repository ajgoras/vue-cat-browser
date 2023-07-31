<script setup lang="ts">
import type { CatType } from '@/types/CatType'

const props = defineProps<{
  cat: CatType
}>()


</script>

<template>
  <div class="cat-element">
    <h2>CAT</h2>
    <img :id="cat.id" class="cat-photo" alt="cat-photo" draggable="false" :src="cat.image" />
  </div>
</template>

<style scoped>
.cat-element {
  height: 90vmin;
  width: 90vmin;
}
.cat-photo {
  height: 100%;
  width: 100%;
  object-fit: contain;
}
</style>
