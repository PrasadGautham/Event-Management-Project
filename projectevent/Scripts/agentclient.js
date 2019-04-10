var app = angular.module('eventdbapp', ['ngRoute']);
console.log("Agentclint");
app.config(function ($routeProvider) {
   
    console.log('Helloworld config');
    $routeProvider.when("/agentadd", {
        templateUrl: "/ClientView/Agents/AddAgent.html",
        controller: "agentcontroller"
    }).when("/ModifyAgent/:agentID", {
        templateUrl: "/ClientView/Agents/EditAgent.html",
        controller: "agentcontroller"
    }).when("/Agent", {
        templateUrl: "/ClientView/Agents/Agentdetails.html",
        controller: "agentcontroller"
    }).when("/venueadd", {
        templateUrl: "/ClientView/AddVenue.html",
        controller: "venuecontroller"
    }).when("/ModifyVenue/:venueID", {
        templateUrl: "/ClientView/EditVenue.html",
        controller: "venuecontroller"
    }).when("/venue", {
        templateUrl: "/ClientView/Venuedetails.html",
        controller: "venuecontroller"
    }).when("/photoadd", {
            templateUrl: "/ClientView/AddPhoto.html",
            controller: "photocontroller"
    }).when("/ModifyPhoto/:photographyID", {
        templateUrl: "/ClientView/Editphoto.html",
        controller: "photocontroller"
    }).when("/photo", {
        templateUrl: "/ClientView/photodetails.html",
        controller: "photocontroller"
    }).when("/vendor", {
        templateUrl: "/ClientView/vendorlogin.html",
        controller: "vendorcontroller"
    }).when("/vendoreg", {
        templateUrl: "/ClientView/vendorreg.html",
        controller: "vendorcontroller"
    }).when("/vendor1", {
        templateUrl: "/ClientView/vendordetails.html",
        controller: "vendorcontroller"
    }).when("/vendorhmpage", {
        templateUrl: "/ClientView/vendorhomepage.html",
        controller: "vendorcontroller"
    }).when("/eventhome", {
        templateUrl: "/ClientView/customer/search.html",
        controller: "venue1controller"
    }).when("/venuebook", {
        templateUrl: "/ClientView/customer/booking.html",
        controller: "venue1controller"

    }

    ).when("/book", {
        templateUrl: "/ClientView/customer/bookpage.html",
        controller: "venue1controller"

    }

    ).when("/image", {
        templateUrl: "/ClientView/customer/imageslider.html",


    }

    ) .when("/searchby", {
            templateUrl: "/ClientView/customer/searchby.html",
            controller: "venue1controller"

        }

    ).when("/Admin", {
            templateUrl: "/ClientView/Admin/Vendordetails.html",
            controller: "detailsforadmintoacceptvendorcontroller"
        }).when("/review", {
            templateUrl: "/ClientView/customer/review.html",
            controller: "reviewbasedonvenueidcontoller"
        }).when("/allreview/:id", {
            templateUrl: "/ClientView/customer/allreview.html",
            controller: "reviewbasedonvenueidcontoller"
        }).when("/alldetails", {
            templateUrl: "/ClientView/customer/alldetails.html",
            controller: "alldetailsforvendortoreferagentcontroller"
        }).when("/adminlogin", {
            templateUrl: "/ClientView/Admin/adminlogin.html",
            controller: "adminLoginController"
        }).when("/adminpage", {
            templateUrl: "/ClientView/Admin/adminpage.html",
            controller: "adminLoginController"
        }).when("/users", {
            templateUrl: "/ClientView/Admin/users.html",
            controller: "allbookingdetailsforadmincontroller"
        }). when("/custreg", {
        templateUrl: "/ClientView/customer/customerReg.html",
        controller: "HomeController"
    }).when("/customerlogin", {
        templateUrl: "/ClientView/login/customerLogin.html",
        controller: "customerLoginController"
    }).when("/home", {
        templateUrl: "/ClientView/home.html",
        controller: "HomeController"
    }).otherwise({ redirectTo: "/home" })
});
app.run(function () { console.log('Helloworld run') });