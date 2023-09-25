import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import ErrorView from '../views/ErrorView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/CreditsView.vue')
    },
    {
      path: '/browse',
      name: 'browse',
      component: () => import('../views/BrowseCatsView.vue')
    },
    {
      path: '/:catchAll(.*)',
      name: 'error',
      component: ErrorView
    },
    { path: '/cat/:id', component: () => import('../components/CatDetailsComponent.vue') },
    {
      path: '/create',
      name: 'create',
      component: () => import('../views/CreateCatView.vue')
    }
  ]
})

export default router
