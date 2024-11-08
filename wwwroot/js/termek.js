var termekPage = new Vue({
    el: '#termekPg',
    data: {
        termekLista: [],
    },
    beforeMount() {
        console.log("Vue instance is mounting");
        this.OnInit();
    },
    methods: {
        OnInit: function () {
            var vm = this;
            console.log("Sending request to API...");
            axios.get(`/api/termek`).then(function (res) {
                console.log("Response received:", res);
                var data = res.data;
                vm.termekLista = data;
            }).catch(function (error) {
                console.error("Error with API request:", error);
            });
        },
    }
});         