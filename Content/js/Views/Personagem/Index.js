var appPersonagem = new Vue({
    el: "#personagemApp",
    data: {
        Personagens: [],
    },
    methods: {
        GetPersonagens: function () {
            var self = this;
            $.ajax({
                type: "POST",
                url: "/Personagem/GetPersonagens",
                success: function (data) {
                    if (data.personagens.length) {
                        self.Personagens = data.personagens;
                    }
                },
                error: function (error) {
                    toastr.error('Erro ao executar operação.');
                }
            });
        },
    },
    mounted: function () {
        var self = this;

        self.GetPersonagens();
    },

});
