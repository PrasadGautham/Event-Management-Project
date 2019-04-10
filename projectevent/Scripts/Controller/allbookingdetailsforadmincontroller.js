(function () {
    console.log("controllerjs");

    var allbookingdetailsforadmincontroller = function ($scope, gautservice) {
        console.log("customer controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data) {
            $scope.customers = data;debugger;

        };
        var failed = function () {
            console.log("Some error");
        };
        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};   debugger;
        debugger;
        gautservice.getallcustomers().then(sucess, failed); debugger;
            
        //$scope.deletecustomer = function (id) {
        //    service.deletecustomer(id).then(function (data) {
        //        alert("Customer deleted Successfully");
        //        $scope.customers = data
        //    }, failed);
        //}
      
       

    };
    app.controller("allbookingdetailsforadmincontroller", ["$scope", "gautservice", allbookingdetailsforadmincontroller]);
})();