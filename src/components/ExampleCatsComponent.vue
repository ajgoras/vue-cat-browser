<script setup lang="ts">
import type { CatType } from '@/types/CatType'
import { type Ref, ref, onMounted } from 'vue'
import { VueperSlides, VueperSlide } from 'vueperslides'
import '../assets/vueper-slides.css'
import { exampleCats } from '@/functions/exampleCats'
import ScrollReveal from 'scrollreveal'

const cats: Ref<CatType[]> = exampleCats()

onMounted(() => {
  ScrollReveal().reveal('.example-cats-header', {
    delay: 310,
    distance: '30px',
    origin: 'left',
    duration: 750
  })
  ScrollReveal().reveal('.example-cats-footer', {
    delay: 310,
    distance: '30px',
    origin: 'left',
    duration: 750
  })
  ScrollReveal().reveal('.vueper-slides-containter', {
    delay: 510,
    distance: '30px',
    origin: 'right',
    duration: 750
  })
})
</script>

<template>
  <div id="ExampleCatsComponent">
    <div class="example-cats-header">
      <h1>Some of our cats</h1>
      <h2>Here are some of our wonderful cats</h2>
      <RouterLink to="/browse">Let’s take a look at all cats </RouterLink>
    </div>
    <div class="vueper-slides-containter">
      <vueper-slides
        :touchable="false"
        :slide-ratio="1 / 1.8"
        duration="3000"
        autoplay
        style="border-radius: 15px"
      >
        <vueper-slide
          style="border-radius: 15px"
          v-for="cat in cats"
          :key="cat.id"
          :title="cat.name"
          :image="cat.image"
        />
        <template #pause>
          <i class="icon pause_circle_outline"></i>
        </template>
      </vueper-slides>
    </div>
    <div class="example-cats-footer">
      <RouterLink to="/browse">Let’s take a look at all cats </RouterLink>
    </div>
  </div>
</template>

<style scoped>
#ExampleCatsComponent {
  display: grid;
  grid-template-columns: 1.8fr 3fr;
  background-color: #5bd77275;
  margin-top: 60px;
  padding: 12vmax 4vmin 12vmax 1vmin;
}

.example-cats-header,
.example-cats-footer {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  gap: 20px;
}

h1 {
  color: black;
  font-family: 'Montserrat';
  font-weight: bold;
  font-size: 3.3vmax;
}

h2 {
  color: black;
  font-family: 'Montserrat';
  font-weight: bold;
  font-size: 1.7vmax;
}

.example-cats-header a,
.example-cats-footer a {
  position: relative;
  font-size: 1.6vmax;
  color: rgb(30, 193, 74);
  font-weight: bold;
}

.example-cats-header a:hover,
.example-cats-footer a:hover {
  color: var(--green-main-color-darker);
}

.example-cats-header a::after,
.example-cats-footer a::after {
  content: '';
  position: absolute;
  bottom: 0;
  left: 0;
  width: 0%;
  height: 0.15em;
  border-radius: 10px;
  background-color: var(--green-main-color-darker);
  height: 2px;
  transition: 0.2s ease-in-out;
}

.example-cats-header a:hover::after,
.example-cats-footer a:hover::after {
  width: 100%;
}

.example-cats-footer {
  display: none;
}

@media (max-width: 760px) {
  #ExampleCatsComponent {
    grid-template-columns: auto;
    grid-template-rows: 1fr 3fr;
    margin-top: 60px;
    padding: 6vmax 4vmin 12vmax 4vmin;
  }

  h1 {
    font-size: 7vmin;
  }

  h2 {
    font-size: 4vmin;
  }
  .example-cats-footer {
    display: flex;
  }

  .example-cats-header a {
    display: none;
  }
  .example-cats-footer a {
    margin-top: 35px;
    font-size: 3.8vmin;
  }
  .vueper-slides-containter {
    margin-top: 50px;
  }
}

@media (prefers-color-scheme: dark) {
  #ExampleCatsComponent {
    background-color: #46a35798;
  }
  h1,
  h2 {
    color: whitesmoke;
  }
  .example-cats-header a:hover,
  .example-cats-footer a:hover {
    color: whitesmoke;
  }

  .example-cats-header a::after,
  .example-cats-footer a::after {
    background-color: whitesmoke;
  }
}
</style>
