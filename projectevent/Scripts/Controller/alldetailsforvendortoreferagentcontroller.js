(function () {
    console.log("controllerjsvenueee");

    var alldetailsforvendortoreferagentcontroller = function ($scope, gautservice) {
        debugger;
        console.log("vencust controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data) {
            debugger;
            $scope.alldetails = data;

        };
        var failed = function () {
            console.log("Some error");
        };
        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};

        gautservice.getalldetails().then(sucess, failed);
        //$scope.IsVisible = false;
        $scope.acceptbook = function (id) {
            gautservice.acceptbook(id).then(function (data) {
                alert("booking accepted");
                //$scope.Vendors = data
            }, failed);
        };
        $scope.acceptkeyvisibleornot = function (value) {

            if (value == true)
                return true;
            else
                return false;

        };
    };

    //$scope.GetEmployeebyName = function (Name) {
    //Employeegautservice.GetEmployeebyName(Name).then(sucess, failed);

    //};
    //$scope.init = function (Id) {

    //Employeegautservice.GetEmployeebyId(Id).then(sucess, failed);

    //};
    //$scope.Updates1 = function (Id) {
    //    Employeegautservice.Updates1(Id).then(yes, failed);
    //};


    app.controller("alldetailsforvendortoreferagentcontroller", ["$scope", "gautservice", alldetailsforvendortoreferagentcontroller]);
})();