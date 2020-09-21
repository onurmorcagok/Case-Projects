<template>
  <div class="header mb-5">
    <nav class="navbar fixed-top navbar-expand-lg navbar-light bg-light">
      <router-link class="nav-link" to="/">
        <img class="img" src="https://cdn.baymak.com.tr/assets/svg/baymak--logo.svg" />
      </router-link>
      <button
        class="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#navbarNav"
        aria-controls="navbarNav"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav mx-auto">
          <li class="nav-item">
            <router-link class="nav-link" to="/">
              <i class="fas fa-home">
                <span>Anasayfa</span>
              </i>
            </router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/haberler">
              <i class="fas fa-newspaper">
                <span>Haberler</span>
              </i>
            </router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/duyurular">
              <i class="fas fa-bullhorn">
                <span>Duyurular</span>
              </i>
            </router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/iletisim">
              <i class="fas fa-file-signature">
                <span>İletişim</span>
              </i>
            </router-link>
          </li>
        </ul>
      </div>
    </nav>
  </div>
</template>

<script>
export default {
  name: "Header",
};
</script>

<style scoped>
.header {
  margin-top: 150px;
}
.img {
  width: 150px;
}

i{
    width: 120px;
    font-size: 20px;
}

span {
    margin-left:5px;
}
</style>