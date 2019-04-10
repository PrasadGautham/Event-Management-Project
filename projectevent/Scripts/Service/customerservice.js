//testttttttttttttttttttttttttttttttttttttttttttttttttttt okay
(function () {
    var customerservice = function ($http) {
                var addcustomers = function (customer) {
   
            return $http.post("api/customerreg/", customer).then(function (Response) {

                return Response.data;
            });
        }
        //var updateemployee = function (employee) {
        //    return $http.put("/api/employee/", employee).then(function (Response) {
        //        return Response.data;
        //    });
        //}
        //var deleteemployee = function (EmployeeId) {
        //    return $http.delete("/api/employee/" + EmployeeId).then(function (Response) {
        //        return Response.data;
        //    });
        //}
        //var getemployeebyid = function (id) {
        //    return $http.get("/api/employee/" + id).then(function (Response) {
        //        return Response.data;
        //    });
        //}
        return {
            //GetAllEmployees: GetAllEmployees,
            //searchemployees: searchemployees,
            //getemployeebyid: getemployeebyid,
            //AddEmployees: AddEmployees,
            //updateemployee: updateemployee,
            //deleteemployee: deleteemployee,
            addcustomers:addcustomers
        }
    };
    app.factory("customerservice", ["$http", customerservice]);
})();