(function () {

    console.log("service");
    var service = function ($http) {
        console.log("service");
        var getallagents = function () {
            return $http.get("/api/Agent").then(function (Response) {
                return Response.data;
            });
        }
        var acceptvendors = function (id) {
            return $http.put("/api/Vendor/" + id).then(function (Response) {
                return Response.data;
            });
        }
        var getallvendors = function () {
            return $http.get("/api/Vendor").then(function (Response) {
                return Response.data;
            });
        }

        var getall= function () {
            return $http.get("/api/customer").then(function (Response) {
                return Response.data;
            });
        }

        
        var deletevendors = function (id) {
            return $http.get("/api/Vendor/"+ id).then(function (Response) {
                return Response.data;
            });
        }

        var validate = function (date1, vid) {
            debugger;
           
            return $http.get("/api/customer/"+date1+"/"+vid).then(function (Response) {
                return Response.data;
            });
        }
          
        
        var searchbyloc = function (search) {
            debugger;
            return $http.get("/api/customer?search=" + search).then(function (Response) {
                debugger;
                return Response.data;
            });
        }



        var book = function (video) {
            
            return $http.get("/api/customer/" + video).then(function (Response) {
                debugger;
                return Response.data;
            });
        }
        return {
            getallagents: getallagents,
            acceptvendors: acceptvendors,
            deletevendors:deletevendors,
            getallvendors: getallvendors,
            getall: getall,
            validate: validate,
            book: book,
            searchbyloc: searchbyloc

        }
    };
    app.factory("service", ["$http", service]);
})();
