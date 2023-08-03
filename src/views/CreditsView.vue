<script setup lang="ts">
import CreditMaterial from '@/components/CreditMaterial.vue'
import { onMounted } from 'vue'
import ScrollReveal from 'scrollreveal'
const materials = [
  {
    imageLink:
      'https://raw.githubusercontent.com/ajgoras/vue-cat-browser/main/src/assets/cat_icon.png',
    attributeInfo: `<a href="https://www.flaticon.com/free-icons/cat" title="cat icons">Cat icons created by AomAm - Flaticon</a>`,
    href: `https://www.flaticon.com/free-icons/cat`,
    anchorValue: 'Cat icons created by AomAm - Flaticon'
  },
  {
    imageLink:
      'https://raw.githubusercontent.com/ajgoras/vue-cat-browser/main/src/assets/cats-paw.png',
    attributeInfo: `<a href="https://www.flaticon.com/free-icons/paw" title="paw icons">Paw icons created by logisstudio - Flaticon</a>`,
    href: `https://www.flaticon.com/free-icons/paw`,
    anchorValue: 'Paw icons created by logisstudio - Flaticon'
  },
  {
    imageLink:
      'https://raw.githubusercontent.com/ajgoras/vue-cat-browser/main/src/assets/cat-home-side.png',
    attributeInfo: `<a href="https://www.freeiconspng.com/img/40349">Cat Free Icon Vectors Download</a>`,
    href: `https://www.freeiconspng.com/img/40349`,
    anchorValue: 'Cat Free Icon Vectors Download created by Ahkâm'
  },
  {
    imageLink:
      'https://raw.githubusercontent.com/ajgoras/vue-cat-browser/main/src/assets/heart.png',
    attributeInfo: `<a href="https://www.flaticon.com/free-icons/heart" title="heart icons">Heart icons created by Fathema Khanom - Flaticon</a>`,
    href: `https://www.flaticon.com/free-icons/heart`,
    anchorValue: 'Heart icons created by Fathema Khanom - Flaticon'
  },
  {
    imageLink:
      'https://raw.githubusercontent.com/ajgoras/vue-cat-browser/main/src/assets/sad-cat.png',
    attributeInfo: `<a href="https://www.flaticon.com/free-icons/cat" title="cat icons">Cat icons created by AomAm - Flaticon</a>`,
    href: `https://www.flaticon.com/free-icons/cat`,
    anchorValue: 'Cat icons created by AomAm - Flaticon'
  }
]

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
