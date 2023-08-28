import type { CatType } from '@/types/CatType'
import { ref, type Ref } from 'vue'

export const exampleCats = () => {
  const cats: Ref<CatType[]> = ref([
    {
      id: '1',
      name: 'Pumpkin',
      color: 'Ginger',
      age: 6,
      image: 'https://cdn.pixabay.com/photo/2015/11/16/22/14/cat-1046544_1280.jpg'
    },
    {
      id: '2',
      name: 'Sugar',
      color: 'White',
      age: 10,
      image: 'https://cdn.pixabay.com/photo/2018/08/08/05/12/cat-3591348_1280.jpg'
    },
    {
      id: '3',
      name: 'Cookie',
      color: 'Tabby grey',
      age: 3,
      image: 'https://cdn.pixabay.com/photo/2016/03/27/07/31/cat-1282309_1280.jpg'
    },
    {
      id: '4',
      name: 'Daisy',
      color: 'Tabby grey',
      age: 1,
      image: 'https://cdn.pixabay.com/photo/2019/05/08/21/21/cat-4189697_1280.jpg'
    },
    {
      id: '5',
      name: 'Honey',
      color: 'Ginger',
      age: 10,
      image: 'https://cdn.pixabay.com/photo/2018/01/03/19/17/cat-3059075_1280.jpg'
    }
  ])
  return cats
}
