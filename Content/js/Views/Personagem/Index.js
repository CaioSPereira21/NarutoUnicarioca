var appPersonagem = new Vue({
    el: "#personagemApp",
    data: {
        Personagens: [],
    },
    methods: {

    },
    mounted: function () {
        self = this;

        self.Personagens = JSON.parse($('#hfPersonagensJson').val());
    },

});
