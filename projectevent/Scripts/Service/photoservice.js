(function () {
   
    console.log("service");
    var photoservice = function ($http) {
        console.log("photoservice");
        var getallphotographers = function () {
            return $http.get("/api/photo").then(function (Response) {
                return Response.data;
            });
        }
    
        var AddPhoto = function (photo) {
        return $http.post("api/photo", photo).then(function (Response) {
            return Response.data;
        });
        }
        var GetPhotoById = function (Id) {
            return $http.get("/api/photo/" + Id).then(function (Response) {
                return Response.data;
            });
        }
        var UpdatePhoto = function (photo) {
            return $http.put("api/photo", photo).then(function (Response) {
                return Response.data;
            });

        }
        var DeletePhoto = function (photographyID) {
            return $http.delete("/api/photo/" + photographyID).then(function (Response) {
                return Response.data;
            });

        }
    return {
        getallphotographers: getallphotographers,
        AddPhoto: AddPhoto,
        UpdatePhoto: UpdatePhoto,
        GetPhotoById: GetPhotoById,
        DeletePhoto: DeletePhoto
    }
    };
    app.factory("photoservice", ["$http", photoservice]);
})();