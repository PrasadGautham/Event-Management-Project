(function () {

    console.log("service");
    var venueservice = function ($http) {
        console.log("venueservice");
        var getallvenues = function () {
            return $http.get("/api/Venue").then(function (Response) {
                return Response.data;
            });



        }
        var AddVenue = function (venue) {
            return $http.post("api/venue/", venue).then(function (Response) {
                return Response.data;
            });
        }
        var GetVenueById = function (Id) {
            return $http.get("api/venue/" + Id).then(function (Response) {
                return Response.data;
            });
        }
        var Updatevenue = function (venue) {
            return $http.put("api/venue/", venue).then(function (Response) {
                return Response.data;
            });
        }

        return {
            getallvenues: getallvenues,
            AddVenue: AddVenue,
            GetVenueById: GetVenueById,
            Updatevenue: Updatevenue
        }
    };
    app.factory("venueservice", ["$http", venueservice]);
})();