(function () {
    console.log("customerloginjs");

    var customerLoginController = function ($scope, customerLogservice, $routeParams,$location) {
        $scope.message = "Online Event Management System";
        console.log("customerLogin controller");
        $scope.helloWorld = "Hello World";
        var success = function (data) {
            $scope.LoginData1 = data;

        };
        var failed = function () {
            console.log("Some error");
        };
        //$scope.shc = function () {
        //    debugger;
        //   var dpvalue= document.getElementById(drp).value();
        //   if (dpvalue == 'vendor')
        //   {
        //       $scope.sh = function () {
        //           return true;
        //       };

        //   }
        //};
        
        $scope.Login = function (username,password) {
            debugger;           
            customerLogservice.custlogin(username,password).then(function (data) {
                console.log(data);
              if(data==true)
              {
                  debugger;
                  alert("login sucess"); debugger;
                  $location.path("/book");debugger;
                }
                else {
                  alert("failed");
                  $location.path("/home")
              }

            }, failed);

        };
    
    };
    app.controller("customerLoginController", ["$scope","customerLogservice","$routeParams","$location", customerLoginController]);
})();