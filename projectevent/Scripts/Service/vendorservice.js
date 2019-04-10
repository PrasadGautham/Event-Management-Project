(function () {
    debugger;
    console.log("service");
    var vendorservice = function ($http) {
        console.log("vendorservice");
        var getvendor = function (Id) {
            return $http.get("/api/Vendor/"+Id).then(function (Response) {
                return Response.data;
            });
        }
        var registervendor = function(vendor) {
            return $http.post("api/Vendor",vendor).then(function (Response) {
                return Response.data;
            });

        }
        var custlogin = function (username, password) {
            return $http.get("api/Vendor?username=" + username + "&password=" + password).then(function (Response) {
            return Response.data;
            });
        }

        return {
            getvendor:getvendor,
            registervendor: registervendor,
            custlogin: custlogin
        }
    };
    app.factory("vendorservice", ["$http", vendorservice]);
})();