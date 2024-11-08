var deletePage = new Vue({
    el: '#DeletePg',
    data: {
        termekId: null,
    },
    created() {
        this.termekId = this.getQueryParam('id');
    },
    methods: {
        getQueryParam(param) {
            const urlParams = new URLSearchParams(window.location.search);
            return urlParams.get(param);
        },
        deleteProduct() {
            if (this.termekId) {
                axios.post(`/api/termek/delete/${this.termekId}`)
                    .then(response => {
                        // Törlés sikeres, átirányítás a termékek listájára
                        window.location.href = '/termek';
                    })
                    .catch(error => {
                        console.error('Hiba történt a törlés során:', error);
                    });
            }
        }
    }
});