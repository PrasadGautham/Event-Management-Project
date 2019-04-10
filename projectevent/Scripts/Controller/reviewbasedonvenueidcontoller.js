(function () {
    console.log("controllerjs");

    var reviewbasedonvenueidcontoller = function ($scope, gautservice, $location, $routeParams) {
        console.log("Agent controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data) {
            $scope.Review = data;

        };
        var failed = function () {
            console.log("Some error");
        };
        $scope.addreview = function (review) {
            debugger;
            gautservice.addreview(review).then(function (data) {
                $location.path("/allreview")
            }, failed);
        };
       
        gautservice.allreview($routeParams.id).then(sucess, failed);
    
    };
    app.controller("reviewbasedonvenueidcontoller", ["$scope", "gautservice", "$location", "$routeParams", reviewbasedonvenueidcontoller]);
})();