var appPersonagem = new Vue({
    el: "#personagemApp",
    data: {
        Personagens: [],
    },
    methods: {
        getBijuusPersonagens: function () {
            var self = this;

            $.ajax({
                type: "POST",
                url: "/Personagem/GetBijuusPersonagens",
                success: function (data) {
                    self.Personagens = data.tailedBeasts;

                },
                error: function () {
                    toastr.error('Erro ao obter as Bijuus .');
                }
            });
        },
    },
    mounted: function () {
        self = this;

        self.getBijuusPersonagens();
    },

});
