(function () {
    console.log("controllerjs");
    
    var agentcontroller = function ($scope, agentservice, $location, $routeParams) {
        console.log("Agent controller");
        $scope.helloWorld = "Hello World";
        var sucess = function (data)  {
            $scope.Agents = data;
         
        };
        var singlagent = function (data) {
            $scope.agent = data;

        };
        var failed = function () {
            console.log("Some error");
        };
        //var yes = function (data) {
        //    $scope.Employees1 = data;
        //};

        agentservice.getallagents().then(sucess, failed);


        $scope.addAgent = function (agent) {

            agentservice.AddAgent(agent).then(function (data) {
                console.log(data);
                $location.path("/Agent")
            }, failed);
        };
        //$scope.GetEmployeebyName = function (Name) {
            //EmployeeService.GetEmployeebyName(Name).then(sucess, failed);

        //};
        $scope.UpdateAgent = function(agent) {

           agentservice.Updateagent(agent).then(function (data) {
                console.log(data);
                $location.path("/Agent")
            }, failed);
        };
        $scope.deleteAgent = function (AgentId) {
            var con = confirm("Do you want to delete this agent");
            if (con) {
                agentservice.DeleteAgent(AgentId).then(function (data) {
                    console.log(data);
                    alert("Agent deleted sucessfully");
                    $scope.Agents = data;
                }, failed);
            }
        };
        $scope.init = function () {

            agentservice.GetAgentById($routeParams.agentID).then(singlagent, failed);
        };
        //$scope.Updates1 = function (Id) {
        //    EmployeeService.Updates1(Id).then(yes, failed);
        //};

    };
    app.controller("agentcontroller", ["$scope", "agentservice", "$location", "$routeParams", agentcontroller]);
})();