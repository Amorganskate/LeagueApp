<template>
    <v-row>
        <v-col>
            <v-list>
                <template v-for="(match, index) in matches.matches">
                    {{match.gameId}} {{index}}
                </template>
            </v-list>
        </v-col>
    </v-row>
</template>

<script>
import axios from 'axios'
export default {
    name: 'MatchList',
    props:{
        summoner: {
            Type: Object,
            Required: true,
            default: ''
        }
    },
    data()  {
        return{
            matches: []
        }
    },
    methods: {
        async get_matches(){
            var response = await axios.get(`https://localhost:44375/matches?accountid=${this.summoner.accountId}`)

             if(response.status === 200){
                    this.matches = response.data;
                }
        }
    },
    mounted(){
        if(this.summoner)
            this.get_matches();
    }
}
</script>