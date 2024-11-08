var createPage = new Vue({
    el: '#createPg',
    data: {
        product: {
            Cikkszam: '',
            Termeknev: '',
            Leiras: '',
            Ar: ''
        },
        errors: {
            Cikkszam: '',
            Termeknev: '',
            Leiras: '',
            Ar: ''
        }
    },
    methods: {
        // Form küldése
        submitForm() {
            this.errors = {}; // Hibák törlése előzőleg

            // Ellenőrzés (például, hogy a kötelező mezők ki vannak töltve)
            if (!this.product.Cikkszam || !this.product.Termeknev || !this.product.Ar) {
                if (!this.product.Cikkszam) this.errors.Cikkszam = "Cikkszám is required!";
                if (!this.product.Termeknev) this.errors.Termeknev = "Terméknév is required!";
                if (!this.product.Ar) this.errors.Ar = "Ár is required!";
                return;
            }

            // Küldés az API-nak
            axios.post('/api/termek', this.product)
                .then(response => {
                    if (response.data.success) {
                        window.location.href = '/termek'; // Visszairányítás a termékek listájához
                    } else {
                        alert('Valami hiba történt a termék mentésekor.');
                    }
                })
                .catch(error => {
                    console.error(error);
                    alert('Valami hiba történt.');
                });
        }
    }
});