import Vue from "vue";
import VueRouter from "vue-router";
import Home from "../views/Home.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home,
  },
  {
    path: "/haberler",
    name: "News",
    component: () => import("../views/News.vue"),
  },
  {
    path: "/duyurular",
    name: "Announcements",
    component: () => import("../views/Announcements.vue"),
  },
  {
    path: "/iletisim",
    name: "Contact",
    component: () => import("../views/Contact.vue"),
  },
  {
    path:"*",
    redirect:"/",
  }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
