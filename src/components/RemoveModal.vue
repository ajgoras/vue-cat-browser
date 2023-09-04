<script setup lang="ts">
const props = defineProps<{
  title: string
  body: string
  function?: () => Promise<void>
}>()
</script>

<template>
  <!-- Modal -->
  <div
    class="modal fade"
    id="exampleModal"
    tabindex="-1"
    aria-labelledby="exampleModalLabel"
    aria-hidden="true"
  >
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5" id="exampleModalLabel">{{ props.title }}</h1>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></button>
        </div>
        <div class="modal-body">{{ props.body }}</div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
          <button
            @click="props.function"
            data-bs-dismiss="modal"
            type="button"
            class="btn btn-danger"
          >
            Remove cat
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
@media (prefers-color-scheme: dark) {
  .modal-content {
    background-color: var(--vt-c-black-soft);
    color: whitesmoke;
  }

  .modal-header {
    border-bottom: #8080805d solid 1px;
  }

  .modal-footer {
    border-top: #8080805d solid 1px;
  }
}
</style>
