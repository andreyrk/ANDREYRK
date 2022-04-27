new Vue({
    el: "#app",
    vuetify: vuetifyConfig,
    data: {
        app: app,
    },
    mounted() {
        this.app.mounted(this)
    },
    methods: {

    },
})
