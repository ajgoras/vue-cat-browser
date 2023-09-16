<script setup lang="ts">
import {getImageUrl} from '@/functions/getImageUrl'
import type {CreditMaterialType} from '@/types/CreditMaterialType'

defineProps<{
  material: CreditMaterialType
}>()
</script>

<template>
  <div class="material">
    <img draggable="false" :src="getImageUrl(material.imageLink)" alt="credit material image"/>
    <a :href="material.href">{{ material.anchorValue }}</a>
  </div>
</template>

<style scoped>
.material {
  border-bottom: 1px solid rgba(211, 211, 211, 0.432);
  border-top: 1px solid rgba(211, 211, 211, 0.432);
  border-radius: 20px;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  gap: 30px;
  font-size: 17px;
  font-style: italic;
  font-weight: bold;
  margin: -1px -1px 30px -1px;
  transition: all 0.3s ease-in-out;
}

.material:hover {
  outline: 1px solid rgb(85, 85, 85);
}

.material img {
  margin: -1px;
  user-select: none;
  border-radius: 20px;
  box-sizing: content-box;
  background-color: var(--green-main-color);
  padding: 5px 30px 5px 15px;
  width: 50px;
  height: auto;
  transition: all 0.3s ease-in-out;
}

.material:hover img {
  background-color: var(--green-main-color-darker);
}

.material:hover a {
  color: var(--green-main-color-darker);
}
</style>
