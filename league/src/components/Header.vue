<template>
    <v-row pa-3>
        <v-col>
          <v-text-field label="Search For Summoner" v-model="summoner_name" @keydown.enter="get_summoner_data()"></v-text-field>
        </v-coL>
        <v-col>
          <v-select label="Regions" :items="regions" v-model="selected_region"></v-select>
        </v-coL>
      </v-row>
</template>

<script>
import axios from 'axios'
export default {
    name: "header",
    data(){
        return{
            regions: [],
            summoner_name: '',
            selected_region: 'NA'
        }
    },
    methods:{
            async getRegions(){
                axios.defaults.headers.get["Access-Control-Allow-Origin"] = "*";
                var response = await axios.get("https://localhost:44375/Regions")

                if(response.status === 200){
                    this.regions = response.data;
                }
            },
            async get_summoner_data(){

                axios.defaults.headers.get["Access-Control-Allow-Origin"] = "*";
                var response = await axios.get(`https://localhost:44375/Summoner?summoner_name=${this.summoner_name}&region=${this.selected_region}`)

                if(response.status === 200){
                    console.log(response.data);
                }
            }
    },
    mounted(){
        this.getRegions();
    }
}
</script>