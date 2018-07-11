var app = angular.module('presysLogin', []);

app.controller('loginController', function ($scope, $http) {
    $scope.username = "";
    $scope.password = "";

    //submit login
    $scope.login = function () {
        $(".preloader").show();

        $http({
            method: "POST",
            url: "/Login/GetUsers",
            data: { user: $scope.username, password: $scope.password }
        }).then(function mySuccess(response) {
            window.location.href = "/Home/";
        }, function myError(response) {
            $scope.myWelcome = response.statusText;
        });
    }
});