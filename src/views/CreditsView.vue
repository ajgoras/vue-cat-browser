<script setup lang="ts">
import CreditMaterial from '@/components/CreditMaterial.vue'
import { onMounted } from 'vue'
import ScrollReveal from 'scrollreveal'
import { creditMaterials } from '@/functions/creditMaterials'

const materials = creditMaterials()

onMounted(() => {
  ScrollReveal().reveal('.about', { delay: 100 })
  ScrollReveal().reveal('.materials', { delay: 350 })
  ScrollReveal().reveal('.material-element', { delay: 300, interval: 120 })
})
</script>

<template>
  <div class="about">
    <h1>Credits and information about the materials used on the site</h1>
  </div>
  <div class="materials">
    <div class="material-element" v-for="material of materials">
      <CreditMaterial :material="material" />
    </div>
  </div>
</template>

<style scoped>
h1 {
  font-weight: bold;
  font-size: 2em;
}
.about {
  font-family: 'Nunito', Tahoma, Geneva, Verdana, sans-serif;
  font-size: 2.5vmin;
  margin-top: 40px;
  padding: 30px;
}

.materials {
  margin: 25px;
  outline: 2px solid rgb(134, 134, 134);
  border-radius: 20px;
}
</style>
