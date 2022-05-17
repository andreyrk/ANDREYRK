new Vue({
    el: "#app",
    data: {
        app: app,
    },
    mounted() {
        this.app.mounted(this)
    },
    methods: {

    },
})
