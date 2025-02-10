<template>
  <div class='memory-palace-container'>
    <a-scene embedded arjs>
      <a-camera position="0 1.6 3">
        <a-cursor></a-cursor>
      </a-camera>
      <a-box position="0 0 -5" width="5" height="5" depth="5" color="#8B5A2B"></a-box>
      <a-sphere v-for="(memory, index) in memories" :key="index" :position="memory.position" radius="0.3" color="blue" @click="showMemory(memory)"></a-sphere>
      <a-light type="directional" position="1 1 1"></a-light>
    </a-scene>
    <div v-if="selectedMemory" class="memory-popup">
      <p>{{ selectedMemory.text }}</p>
      <button @click="selectedMemory = null">Close</button>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      memories: [{ position: "1 1 -3", text: "Mathematics class in school" }],
      selectedMemory: null
    };
  },
  methods: {
    showMemory(memory) {
      this.selectedMemory = memory;
    }
  }
};
</script>
