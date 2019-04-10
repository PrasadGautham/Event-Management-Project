(function () {
    debugger;
    console.log("service");
    var agentservice = function ($http) {
        console.log("agentservice");
        var getallagents = function () {
            return $http.get("/api/Agent").then(function (Response) {
                return Response.data;
            });
        };
        var AddAgent = function (agent) {
            return $http.post("api/Agent", agent).then(function (Response) {
                return Response.data;
            });
        }
        var GetAgentById = function (Id) {
            return $http.get("/api/Agent/" + Id).then(function (Response) {
                return Response.data;
            });
        }
        var Updateagent = function (agent) {
            return $http.put("/api/Agent", agent).then(function (Response) {
                return Response.data;
            });

        }
        var DeleteAgent = function (agentID) {
            return $http.delete("/api/Agent/" + agentID).then(function (Response) {
                return Response.data;
            });

        }
        return {
            getallagents: getallagents,
            AddAgent: AddAgent,
            GetAgentById: GetAgentById,
            Updateagent: Updateagent,
            DeleteAgent: DeleteAgent

        }
    };
    app.factory("agentservice", ["$http", agentservice]);
})();