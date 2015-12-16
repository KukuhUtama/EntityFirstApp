﻿/*This is root module*/
var app = angular.module('EntityFirstApp', [
     // Angular modules 
        'ngAnimate',        // animations
        'ngRoute',          // routing
        'ngSanitize',       // sanitizes html bindings (ex: sidebar.js)

        // Custom modules 
        'common',
        // 3rd Party Modules
        'ui.bootstrap',      // ui-bootstrap (ex: carousel, pagination, dialog)

        //EntityFirstApp module start here
        'userModule',
        'videoModule',
        'rentModule'
]);

app.config(function ($routeProvider) {

    $routeProvider.when("/", {
       // controller: "dashboardController",
        templateUrl: "scripts/app/views/dashboard.html"
    });

    $routeProvider.when("/admin", {
        // controller: "candidatesController",
        templateUrl: "scripts/app/views/admin.html"
    });

    $routeProvider.when("/EditUser", {
        controller: "editUserController",
        templateUrl: "scripts/user/views/EditUser.html"
    });

    $routeProvider.when("/ShowUser", {
        controller:  "showUserController",
        templateUrl: "scripts/user/views/ShowUser.html"
    });


    $routeProvider.when("/EditVideo", {
        controller: "editVideoController",
        templateUrl: "scripts/video/views/EditVideo.html"
    });

    $routeProvider.when("/ShowVideo", {
        controller: "showVideoController",
        templateUrl: "scripts/video/views/ShowVideo.html"
    });

    $routeProvider.when("/ShowRenting", {
        controller: "showRentController",
        templateUrl: "scripts/rent/views/ShowRent.html"
    });


    $routeProvider.otherwise({ redirectTo: "/" });

});