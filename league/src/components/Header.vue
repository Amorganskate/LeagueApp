<template>
    <v-row pa-3>
        <v-col>
          <v-text-field label="Search For Summoner"></v-text-field>
        </v-coL>
        <v-col>
          <v-select label="Regions" :items="regions"></v-select>
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
        }
    },
    methods:{
            async getRegions(){
                axios.defaults.headers.get["Access-Control-Allow-Origin"] = "*";
                var response = await axios.get("https://localhost:44375/Regions")

                if(response.status === 200){
                    this.regions = response.data;
                }
            }
    },
    mounted(){
        this.getRegions();
    }
}
</script>