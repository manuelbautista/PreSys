var app = angular.module('presysClient', []);

app.controller('clientsController', function ($scope, $http) {
    $scope.Identificacion = "";
    $scope.Nombres = "";
    $scope.Apellidos = "";
    $scope.fechaNac = "";
    $scope.Nacionalidad = "";
    $scope.EstadosCiviles = ["Casado", "Soltero"];
    $scope.Profesion = "";
    $scope.Apodo = "";
    $scope.numHijos = 0;

    //submit login
    $scope.saveClient = function () {
        $(".preloader").show();
        var client = {
            Identificacion: $scope.Identificacion,
            Nombres: $scope.Nombres,
            Apellidos: $scope.Apellidos,
            FechaNac: $scope.fechaNac,
            Nacionalidad: $scope.Nacionalidad,
            Femenino: $scope.optionRadioFemenino,
            Masculino: $scope.optionsRadioMasculino,
            EstadoCivil: $scope.EstadoCivil,
            Profesion: $scope.Profesion,
            Apodo: $scope.Apodo,
            NumHijos: $scope.numHijos
        };

        $.ajax({
            type: "POST",
            url: "/Clients/SaveClient",
            data: { clientObj: client },
            success: function(resultData) {
                if (resultData == "true") {
                    swal({
                            title: "La informacion se guardo correctamente",
                            text: "",
                            type: "success",
                            showCancelButton: false,
                            confirmButtonColor: "#54dd6b",
                            confirmButtonText: "Ok!",
                            closeOnConfirm: false
                        },
                        function() {
                            $(".preloader").hide();
                            window.location.href = "/Clients/";
                        });
                }
                else {
                    $(".preloader").hide();
                    swal("Error", "Ocurrio un error guardando el cliente", "error");
                }
            }

        });

        //$http({
        //    method: "POST",
        //    url: "/Clients/SaveClient",
        //    data: { clientObj: client }
        //}).then(function mySuccess(response) {
        //    showAlert();

        //    //window.location.href = "/Home/";
        //}, function myError(response) {
        //    $scope.myWelcome = response.statusText;
        //});
    }

});