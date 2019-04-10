(function () {
    console.log("controllerjs");

    var detailsforadmintoacceptvendorcontroller = function ($scope, gautservice) {
        console.log("Vendor controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data) {
            $scope.Vendors = data;

        };
        var failed = function () {
           console.log("Some error");
        };
        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};
        gautservice.getallvendors().then(sucess, failed);
     

        $scope.acceptvendors = function (id) { gautservice.acceptvendors(id).then(function (data) {
            alert("Vendor accepted");
            $scope.Vendors=data
        }, failed);}
        $scope.deletevendors = function (id) {
            gautservice.deletevendors(id).then(function (data) {
                alert("Vendor deleted Successfully");
                $scope.Vendors = data
            }, failed);
        }
        $scope.acceptkeyvisibleornot = function (value) {

            if (value == true)
                return true;
            else
                return false;

        };
        //$scope.GetEmployeebyName = function (Name) {
        //EmployeeService.GetEmployeebyName(Name).then(sucess, failed);

        //};
        //$scope.init = function (Id) {

        //EmployeeService.GetEmployeebyId(Id).then(sucess, failed);

        //};
        //$scope.Updates1 = function (Id) {
        //    EmployeeService.Updates1(Id).then(yes, failed);
        //};

    };
    app.controller("detailsforadmintoacceptvendorcontroller", ["$scope", "gautservice", detailsforadmintoacceptvendorcontroller]);
})();