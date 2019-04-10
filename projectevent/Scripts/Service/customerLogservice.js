(function () {

    console.log("custlogservice");
    var customerLogservice = function ($http) {
        console.log("custlogservice");
        debugger;
        var custlogin = function (username,password) {
            return $http.get("/api/custlog?username="+username+"&password="+password).then(function (Response) {
                return Response.data;   
            });
        }
       
        return {
           custlogin:custlogin
        }
    };
    app.factory("customerLogservice", ["$http", customerLogservice]);
})();