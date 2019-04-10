(function () {

    console.log("gautservice");
    var gautservice = function ($http) {
        console.log("gautservice");
      
        var acceptvendors = function (id) {
            return $http.put("/api/admintoacceptvendor/" + id).then(function (Response) {
                return Response.data;
            });
        }
        var acceptbook = function (id) {
            return $http.put("/api/Vendortoacceptbooking/" + id).then(function (Response) {
                return Response.data;
            });
        }
        var getallvendors = function () {
            return $http.get("/api/admintoacceptvendor").then(function (Response) {
                return Response.data;
            });
        }

        
        var deletevendors = function (id) {
            return $http.delete("/api/admintoacceptvendor/" + id).then(function (Response) {
                return Response.data;
            });
        }
        var addreview = function (review) {
            debugger;
            return $http.post("api/Review/", review).then(function (Response) {
                return Response.data;
            });
        }
        //var Getvenuebyid = function (Id) {
        //    return $http.get("api/Venue/" + Id).then(function (Response) {
        //        return Response.data;
        //    });
        //}
        var allreview = function (id) {
            return $http.get("api/Review/"+id).then(function (Response) {
                return Response.data;
            });
        }
        //var Getcustomerbyid = function (Id) {
        //    return $http.get("api/Customer/" + Id).then(function (Response) {
        //        return Response.data;
        //    });
        //}
        var getalldetails = function () {
            return $http.get("api/Vendortoacceptbooking/").then(function (Response) {
                return Response.data;
            });
        }
        var getallcustomers = function () {
            debugger;
            return $http.get("api/detailsforadmin/").then(function (Response) {
                return Response.data;
            });
        }
        

        return {
           
            acceptvendors: acceptvendors,
            deletevendors:deletevendors,
            getallvendors: getallvendors,
            addreview: addreview,
            allreview: allreview,
            getalldetails: getalldetails,
            getallcustomers: getallcustomers,
            acceptbook:acceptbook
            //Getcustomerbyid: Getcustomerbyid,
            //Getvenuebyid: Getvenuebyid


        }
    };
    app.factory("gautservice", ["$http", gautservice]);
})();
