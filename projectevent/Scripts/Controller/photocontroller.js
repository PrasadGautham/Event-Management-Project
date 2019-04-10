(function () {
    console.log("controllerjs");

    var photocontroller = function ($scope, photoservice, $location, $routeParams) {
        console.log("photo controller");
        $scope.helloWorld = "Hello World";
        var sucess = function(data) {
            $scope.Photo = data;

        };
        var Photo = function (data) {
            $scope.photo = data;

        };
        var failed = function () {
            console.log("Some error");
        };
        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};
        //};

        photoservice.getallphotographers().then(sucess, failed);


        $scope.addPhoto = function (photo) {

            photoservice.AddPhoto(photo).then(function(data) {
                console.log(data);
                $location.path("/photo")
            }, failed);
        };

        $scope.Updatephoto = function (photo) {

            photoservice.UpdatePhoto(photo).then(function (data) {
                console.log(data);
                $location.path("/photo")
            }, failed);
        };
        $scope.init = function () {

            photoservice.GetPhotoById($routeParams.photographyID).then(Photo, failed);
        };
        $scope.deletePhoto = function (Photographyid) {
            var con = confirm("Do you want to delete this photographer");
            if (con) {
                photoservice.DeletePhoto(Photographyid).then(function (data) {
                    console.log(data);
                    alert("Photographer deleted sucessfully");
                    $scope.photo = data;
                }, failed);
            }
        };
        //$scope.GetEmployeebyName = function (Name) {
        //EmployeeService.GetEmployeebyName(Name).then(sucess, failed);

        //};
        //$scope.init = function (Id) {

        //EmployeeService.GetEmployeebyId(Id).then(sucess, failed);

        //};
        //$scope.Updates1 = function (Id) {
        //    EmployeeService.Updates1(Id).then(yes, failed);
        //};

    };
    app.controller("photocontroller", ["$scope", "photoservice", "$location", "$routeParams", photocontroller]);
})();