<script setup lang="ts">
import { getImageUrl } from '@/functions/getImageUrl'
</script>

<template>
  <div id="TutorialComponent">
    <div class="header">
      <h1>Click on cat!</h1>
      <h2>
        If you click on the photo of the cat, you will see more information about the cat. You can
        also change its data and delete it completely.
      </h2>
    </div>
    <div class="image-container">
      <img
        class="cat-image"
        draggable="false"
        :src="getImageUrl('https://cdn.pixabay.com/photo/2021/07/13/11/34/cat-6463284_1280.jpg')"
      />
      <img
      class="pointer-image"
        draggable="false"
        :src="
          getImageUrl(
            'https://raw.githubusercontent.com/ajgoras/vue-cat-browser/main/src/assets/pointer.png'
          )
        "
      />
    </div>
  </div>
</template>

<style scoped>
#TutorialComponent {
  display: grid;
  grid-template-columns: 1fr 1fr;
  margin-top: 110px;
  padding: 12vmax 4vmin 12vmax 4vmin;
}

.image-container{
  position: relative;
}
.cat-image {
  margin-left: 20px;
  height: 30vmax;
  width: auto;
}
.pointer-image{
  height: 10vmax;
  position: absolute;
  top: 17vmax;
  left: 35vmax;
}
</style>
