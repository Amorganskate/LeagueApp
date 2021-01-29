<template>
  <v-app>
    <v-app-bar app>
      <Header v-model="summoner"></Header>

    </v-app-bar>

    <v-main>
        <v-container v-if="summoner.accountId != 0">
          <MatchList :summoner="summoner"></MatchList>
        </v-container>
    </v-main>
  </v-app>
</template>

<script>
import Header from './components/Header'
import MatchList from './components/MatchList'
export default {
  name: 'App',
  components: {
    Header,
    MatchList
  },
  data()  {
    return{
      summoner: {
        accountId: '',
        level: 0,
      },
    }
  },
  mounted(){
    console.log(this.summoner)
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
