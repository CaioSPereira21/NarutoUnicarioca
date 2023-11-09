var appPersonagem = new Vue({
    el: "#personagemApp",
    data: {
        Personagens: [],
    },
    methods: {
        getAkatsukiPersonagens: function () {
            var self = this;

            $.ajax({
                type: "POST",
                url: "/Personagem/GetAkatsukiPersonagens",
                success: function (data) {
                    self.Personagens = data.akatsuki;

                },
                error: function () {
                    toastr.error('Erro ao obter os membros da akatsuki .');
                }
            });
        },
    },
    mounted: function () {
        self = this;

        self.getAkatsukiPersonagens();
    },

});
