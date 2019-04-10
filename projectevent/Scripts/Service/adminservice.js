


(function () {

    console.log("adminlogservice");
    var adminLogservice = function ($http) {
        console.log("adminlogservice");
        debugger;
        var adminlogin = function (username, password) {
            return $http.get("/api/adminlog?username=" + username + "&password=" + password).then(function (Response) {
    return Response.data;
});
        }

        return {
        adminlogin:adminlogin

        }
    };
    app.factory("adminLogservice", ["$http", adminLogservice]);
})();
