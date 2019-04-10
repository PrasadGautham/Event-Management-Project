(function () {
    console.log("adminloginjs");

    var adminLoginController = function ($scope, adminLogservice,$routeParams,$location) {
        console.log("adminLogin controller");
        $scope.helloWorld = "Hello World";
        var success = function (data) {
            $scope.LoginData1 = data;

        };
        var failed = function () {
            console.log("Some error");
        };

        $scope.Login = function (username, password) {
            debugger;
            adminLogservice.adminlogin(username, password).then(function (data) {
              
                console.log(data);
                if (data == true) {
                    debugger;
                    alert("login sucess");
                }
                else {
                    alert("failed");
                }
            }, failed).then(function (data) {
                $location.path("/adminpage")
            }, failed);

        };

    };
    app.controller("adminLoginController", ["$scope", "adminLogservice","$routeParams","$location",adminLoginController]);
})();