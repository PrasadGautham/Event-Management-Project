(function () {
    console.log("controllerjs");

    var venuecontroller = function ($scope, $location, $routeParams, venueservice) {
        console.log("Venue controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data) {
            $scope.Venues = data;

        };
        var failed = function () {
            console.log("Some error");
        };
        var singlevenue = function (data) {
            $scope.venue = data;

        };

        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};

        venueservice.getallvenues().then(sucess, failed);
        //$scope.GetEmployeebyName = function (Name) {
        //EmployeeService.GetEmployeebyName(Name).then(sucess, failed);

        //};
        //$scope.init = function (Id) {

        //EmployeeService.GetEmployeebyId(Id).then(sucess, failed);

        //};
        //$scope.Updates1 = function (Id) {
        //    EmployeeService.Updates1(Id).then(yes, failed);
        //};
        $scope.UpdateVenue = function (venue) {

            venueservice.Updatevenue(venue).then(function (data) {
                console.log(data);
                $location.path("/venue")
            }, failed);
        };
        $scope.init = function () {

            venueservice.GetVenueById($routeParams.venueID).then(singlevenue, failed);
        };
    };
    app.controller("venuecontroller", ["$scope", "$location", "$routeParams", "venueservice", venuecontroller]);
})();