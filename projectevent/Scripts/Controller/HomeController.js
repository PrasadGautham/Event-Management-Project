(function () {
    var HomeController = function ($scope) {
        $scope.Message = "Online Event Management System";
        $scope.img = "emimg1.jpg";



        var success = function (data) {
            $scope.customer = data;
        }
        var failed = function () {
            console.log("some error");
        }
        $scope.addcustomer = function (customer) {
            customerservice.addcustomers(customer).then(function (data) {
                console.log(data);
                //if (data == true) {
                //    alert("welcome to OEMS");
                //    $location.path("/home");
                //}
                //else {
                //    alert("please try again later");
                //}
                var retVal = confirm("WELCOME TO OEMS");
                if (retVal === true) {

                    $location.path("/customerlogin");
                    return true;
                }
                else {
                    document.write("User does not want to continue!");
                    return false;
                }
            }, failed)
        }






    }
    app.controller("HomeController", ["$scope", HomeController]);
})();