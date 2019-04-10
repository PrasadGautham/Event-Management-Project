
(function () {
    console.log("controllerjs");

    var venue1controller = function ($scope, service, $location, $rootScope) {
        console.log("Vendor controller");
       
        var sucess = function (data) {
            $scope.venue = data;
            
            console.log("data ");
        };
        var failed = function () {
            console.log("Some error");
        };

        var search1 = function (data){
            $scope.showdiv = function () {
                return false;
            }
         
            $scope.searchvenue = data;
            
        }

        var hehe = function (data) {
            $scope.any = data;
            $rootScope.selectedvenue = data;
        };
        service.getall().then(sucess, failed);
        
        $scope.showdiv = function () {
            return true;
        };
        
        $scope.showb = function () {
            return true;
        };

        
        $scope.searchbyloc = function (search) {
            debugger;
            service.searchbyloc(search).then(search1, failed);
           
        }

        var booked = function (data) {

            if (data == true)
            {

                alert("booked");
            }

        };

        $scope.bookdata = function (book) {
            service.insertbook(book).then(booked, failed);

        }

        
        $scope.validate = function (date1, vid) {
            //debugger;
            $scope.name = date1;
            $rootScope.dates = date1;
            //$scope.booking = $rootScope.global;
            //$location.path("/venuebook");
            //debugger;
            
            service.validate(date1,vid).then( function (data) {
                //$scope.datecheck = data;
                debugger;
                if (data == true) {
                    
                   
                    alert("not available");
                    
                }
                else {
                    
                    alert("available");
                    
                    //$scope.showdiv1 = function () {
                    //    return true;
                    //}
                    //service.book(vid).then(sucess, failed);
                    debugger;
                    service.book(vid).then(hehe, failed);
                    console.log("venue check");
                    debugger;
                    $scope.ast = function () {
                        return true
                    };
                    $scope.abc = function () {
                        return true
                    };
                    //$location.path("/venuebook");
                }
                console.log("datecheck ");
            }, failed);
        }
       
        

  


    };



    app.controller("venue1controller", ["$scope", "service", "$location", "$rootScope", venue1controller]);
})();
