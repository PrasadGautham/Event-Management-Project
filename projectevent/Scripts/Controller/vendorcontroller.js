(function () {
    console.log("controllerjs");

    var vendorcontroller = function ($scope, $location, vendorservice, $rootScope) {
        $scope.id = 1;
        console.log("Vendor controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data) {
            $scope.Vendor = data;
            $location.path = ("/vendor1")

        };
        var failed = function () {
            console.log("Some error");
        };
        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};

        //aservice.getallagents().then(sucess, failed);
        //$scope.GetEmployeebyName = function (Name) {
        //EmployeeService.GetEmployeebyName(Name).then(sucess, failed);

        //};
        $scope.RegisterVendor = function (vendor) {
        vendorservice.registervendor(vendor).then(function (data) {
                console.log(data);
               
                if (data==true)
                {
                    alert("registration successful");
                }
                else {
                    alert("registration failed");
                }

                $location.path("/vendor")
            }, failed);
        };
        $scope.getvendorbyid = function(Id) {

        vendorservice.getvendor(Id).then(sucess, failed);

        };
        $scope.Login = function (username, password) {
            debugger;
            vendorservice.custlogin(username, password).then(function (data) {
                console.log(data);
                $rootScope.idvendor = data;
                //if (data == true) {
                //    debugger;
                //    alert("login sucess");
                //}
                //else {
                //    alert("failed");
                //}
                $location.path("/vendorhmpage")
            }, failed);

        };

        //$scope.Updates1 = function (Id) {
        //    EmployeeService.Updates1(Id).then(yes, failed);
        //};

    };
    app.controller("vendorcontroller", ["$scope", "$location", "vendorservice", "$rootScope", vendorcontroller]);
})();