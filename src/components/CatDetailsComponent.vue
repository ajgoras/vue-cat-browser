<script setup lang="ts">
import {axiosUrls} from '@/axiosUrls/axiosUrls'
import router from '@/router'
import type {CatType} from '@/types/CatType'
import axios from 'axios'
import {onBeforeMount, onMounted, ref, type Ref} from 'vue'
import ScrollReveal from 'scrollreveal'
import RemoveModal from './RemoveModal.vue'

const cat: Ref<CatType> = ref({id: '', name: '', color: '', age: 0, image: ''})
const editCatValue: Ref<CatType> = ref({id: '', name: '', color: '', age: 0, image: ''})
const isEditModeActive: Ref<boolean> = ref(false)

const getCat = async () => {
  const data: Promise<CatType> = axios
    .get(axiosUrls.getCatUrl + `${router.currentRoute.value.params.id}`)
    .then((res) => {
      return res.data
    })
  return data
}

const sendChangesToDB = async () => {
  await axios.put(axiosUrls.editCatUrl + `${cat.value.id}`, editCatValue.value)
}

const removeCat = async () => {
  axios.delete(axiosUrls.removeCatUrl + `${cat.value.id}`).then(() => {
    router.push('/browse')
  })
}

const discardChanges = () => {
  isEditModeActive.value = !isEditModeActive.value
  editCatValue.value = {...cat.value}
}

const saveChanges = () => {
  cat.value = {...editCatValue.value}
  isEditModeActive.value = !isEditModeActive.value
  sendChangesToDB()
}

onBeforeMount(async () => {
  cat.value = await getCat()
  editCatValue.value = await getCat()
})

onMounted(() => {
  setTimeout(() => {
    ScrollReveal().reveal('.return-to-cats-container', {delay: 1500})
    ScrollReveal().reveal('#CatDetailsComponent', {delay: 250})
    ScrollReveal().reveal('.cat-element', {delay: 350})
    ScrollReveal().reveal('.cat-photo', {delay: 650})
    ScrollReveal().reveal('.cat-description', {delay: 1000, interval: 120})
  }, 0)
})
</script>

<template>
  <div id="CatDetailsComponent">
    <RemoveModal
      :title="'You are going to remove ' + cat.name"
      body="Are you sure? This action is irreversible!"
      :function="removeCat"
    />
    <div class="return-to-cats-container">
      <RouterLink to="/browse">↩️ Return to cats</RouterLink>
    </div>
    <div v-if="!isEditModeActive" class="cat-element">
      <img :id="cat.id" class="cat-photo" alt="cat-photo" draggable="false" :src="cat.image"/>
      <h2 class="cat-description">Hello, my name is {{ cat.name }}</h2>
      <h3 class="cat-description">I am {{ cat.age }} years old</h3>
      <h4 class="cat-description">My fur is {{ cat.color }}</h4>
      <div class="cat-buttons-container">
        <button
          class="cat-description edit-cat-button"
          @click="isEditModeActive = !isEditModeActive"
        >
          Edit {{ cat.name }}
        </button>
        <button
          class="cat-description remove-cat-button"
          data-bs-toggle="modal"
          data-bs-target="#exampleModal"
        >
          Remove {{ cat.name }}
        </button>
      </div>
    </div>
    <div v-if="isEditModeActive" class="cat-element cat-element-edit-mode">
      <img :id="cat.id" class="cat-photo" alt="cat-photo" draggable="false" :src="cat.image"/>
      <input class="cat-detail-input" v-model="editCatValue.name"/>
      <input class="cat-detail-input" v-model="editCatValue.age" type="number"/>
      <input class="cat-detail-input" v-model="editCatValue.color"/>
      <div class="cat-buttons-container">
        <button @click="discardChanges" class="edit-cat-button">Discard Changes</button>
        <button @click="saveChanges" class="save-changes-button">Save Changes</button>
      </div>
    </div>
  </div>
</template>

<style scoped>
#CatDetailsComponent {
  margin-top: 30px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  gap: 30px;
  margin-bottom: 10vmin;
}

.cat-element {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  gap: 10px;
  padding: 30px;
  outline: 2px solid rgba(0, 0, 0, 0.2);
  border-radius: 5px;
  transition: outline 0.2s ease-in-out;
}

.cat-element:hover {
  outline: 2px solid rgba(0, 0, 0, 0.471);
}

.cat-photo {
  object-fit: contain;
  height: auto;
  width: auto;
  max-width: 85vmin;
  max-height: 85vmin;
  border-radius: 7px;
}

.return-to-cats-container {
  font-size: 2.2vmin;
  font-weight: bold;
  user-select: none;
}

.return-to-cats-container a {
  padding: 1vmin 1.5vmin 1vmin 1.5vmin;
  border: 2px var(--green-main-color-darker) solid;
  border-radius: 50px;
  background-color: var(--green-main-color);
  color: whitesmoke;
}

.return-to-cats-container a:hover {
  background-color: whitesmoke;
  color: var(--green-main-color);
}

.cat-buttons-container {
  display: flex;
  gap: 20px;
  justify-content: center;
  align-items: center;
}

.remove-cat-button {
  padding: 1vmin 1.5vmin 1vmin 1.5vmin;
  border: 2px var(--danger-main-color-darker) solid;
  border-radius: 50px;
  background-color: var(--danger-main-color);
  color: whitesmoke;
  transition: all 0.2s ease-in-out;
  font-weight: bold;
}

.edit-cat-button {
  padding: 1vmin 1.5vmin 1vmin 1.5vmin;
  border: 2px var(--warning-main-color-darker) solid;
  border-radius: 50px;
  background-color: var(--warning-main-color);
  color: whitesmoke;
  transition: all 0.2s ease-in-out;
  font-weight: bold;
}

.save-changes-button {
  padding: 1vmin 1.5vmin 1vmin 1.5vmin;
  border: 2px var(--green-main-color-darker) solid;
  border-radius: 50px;
  background-color: var(--green-main-color);
  color: whitesmoke;
  transition: all 0.2s ease-in-out;
  font-weight: bold;
}

.remove-cat-button:hover {
  background-color: whitesmoke;
  color: var(--danger-main-color);
}

.edit-cat-button:hover {
  background-color: whitesmoke;
  color: var(--warning-main-color);
}

.save-changes-button:hover {
  background-color: whitesmoke;
  color: var(--green-main-color);
}

.cat-detail-input {
  background-color: whitesmoke;
  text-align: center;
  border: 1px solid rgba(0, 0, 0, 0.21);
  font-size: calc(1.325rem + 0.9vw);
  height: 40px;
  width: 200px;
  border-radius: 8px;
}

.cat-detail-input:nth-of-type(2) {
  font-size: calc(1.3rem + 0.6vw);
}

.cat-detail-input:nth-of-type(3) {
  font-size: calc(1.275rem + 0.3vw);
  margin-bottom: 10px;
}

input::-webkit-outer-spin-button,
input::-webkit-inner-spin-button {
  -webkit-appearance: none;
  margin: 0;
}

input[type='number'] {
  appearance: textfield;
}

input:focus {
  outline: none;
}

@media (max-width: 600px) {
  .return-to-cats-container {
    font-size: 3vmin;
  }

  .return-to-cats-container a {
    padding: 1.5vmin 2vmin 1.5vmin 2vmin;
  }

  .cat-photo {
    object-fit: contain;
    height: auto;
    width: auto;
    max-width: 88vmin;
    max-height: 88vmin;
    border-radius: 7px;
  }

  .cat-element {
    padding: 13px;
  }
}

@media (prefers-color-scheme: dark) {
  .cat-element {
    outline: 2px solid rgba(154, 154, 154, 0.2);
  }

  .cat-element:hover {
    outline: 2px solid rgba(255, 255, 255, 0.296);
  }

  .return-to-cats-container a {
    background-color: var(--green-main-color-darker);
    border: 2px var(--green-main-color-darkest) solid;
  }

  .return-to-cats-container a:hover {
    background-color: var(--vt-c-black-soft);
    color: var(--green-main-color-lighter);
  }

  .remove-cat-button {
    background-color: var(--danger-main-color-darker);
    border: 2px var(--danger-main-color-darkest) solid;
  }

  .edit-cat-button {
    background-color: var(--warning-main-color-darker);
    border: 2px var(--warning-main-color-darkest) solid;
  }

  .save-changes-button {
    background-color: var(--green-main-color-darker);
    border: 2px var(--green-main-color-darkest) solid;
  }

  .remove-cat-button:hover {
    background-color: var(--vt-c-black-soft);
    color: var(--danger-main-color-lighter);
  }

  .edit-cat-button:hover {
    background-color: var(--vt-c-black-soft);
    color: var(--warning-main-color-lighter);
  }

  .save-changes-button:hover {
    background-color: var(--vt-c-black-soft);
    color: var(--green-main-color-lighter);
  }

  .cat-detail-input {
    background-color: var(--vt-c-black-soft);
    color: whitesmoke;
  }
}
</style>
