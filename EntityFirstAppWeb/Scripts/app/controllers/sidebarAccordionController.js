app.controller('sidebarAccordionController', sidebarAccordionController);

sidebarAccordionController.$inject = ['$scope','$route'];

function sidebarAccordionController($scope, $route) {
  
    $scope.menus = [
                       {
                           name: "Administrator",
                           desc: "Administrator",
                           subitems: [
                               {
                                   name: "Show Finance",
                                   desc: "Show Finance",
                                   url: '/admin'
                               },
                               {
                                   name: "Add Administrator",
                                   desc: "Add Administrator",
                                   url: '/admin'
                               }]
                       },
                       {
                           name: "User Administration",
                           desc: "User Administration",
                           subitems: [
                               {
                                   name: "Edit User",
                                   desc: "Edit User",
                                   url: '/EditUser'
                               },
                               {
                                   name: "Show All User",
                                   desc: "Show All User",
                                   url: "/ShowUser"
                               }]
                       },
                       {
                           name: "Video Administration",
                           desc: "Video Administration",
                           subitems: [
                               {
                                   name: "Add Video",
                                   desc: "Add Video",
                                   url: "/EditVideo"
                               },
                               {
                                   name: "Show Video",
                                   desc: "Show Video",
                                   url: "/ShowVideo"
                               }
                           ]
                       } ,
                       {
                           name: "Renting Administration",
                           desc: "Renting Administration",
                           subitems: [
                               {
                                   name: "Show Renting",
                                   desc: "Show Renting",
                                   url: "/ShowRenting"
                               }
                           ]
                       }
    ];

    $scope.default = $scope.menus[-1];
}


app.controller('ItemController', ['$scope', function (scope) {

    scope.$parent.isopen = (scope.$parent.default === scope.item);

    scope.$watch('isopen', function (newvalue, oldvalue, scope) {
        scope.$parent.isopen = newvalue;
    });

}]);