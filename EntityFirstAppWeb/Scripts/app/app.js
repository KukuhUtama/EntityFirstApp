/*This is root module*/
var app = angular.module('EntityFirstApp', [
     // Angular modules 
        'ngAnimate',        // animations
        'ngRoute',          // routing
        'ngSanitize',       // sanitizes html bindings (ex: sidebar.js)

        // Custom modules 
        'common',           // common functions, logger, spinner
        'common.bootstrap', // bootstrap dialog wrapper functions

        // 3rd Party Modules
        'ui.bootstrap',      // ui-bootstrap (ex: carousel, pagination, dialog)

        //EntityFirstApp module start here
        'userModule',
        'videoModule',
        'rentModule'
]);

app.constant('routes', getRoutes());

// Configure the routes and route resolvers
app.config(['$routeProvider', 'routes', routeConfigurator]);

function routeConfigurator($routeProvider, routes) {
    routes.forEach(function (r) {
        $routeProvider.when(r.url, r.config);
    });
    $routeProvider.otherwise({ redirectTo: '/' });
}

// Define the routes 
function getRoutes() {
    return [
        {
            url: '/',
            config: {
                templateUrl: 'scripts/app/views/dashboard.html',
                title: 'dashboard',
                settings: {
                    nav: 1,
                    content: '<i class="fa fa-dashboard"></i> Dashboard'
                }
            }
        }, {
            url: '/admin',
            config: {
                title: 'admin',
                templateUrl: 'scripts/app/views/admin.html',
                settings: {
                    nav: 2,
                    content: '<i class="fa fa-lock"></i> Admin'
                }
            }
        }
    ];
}