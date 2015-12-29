userModule.controller('showUserController', showUserController);

showUserController.$inject = ['$scope','$location','ngTableParams', 'toaster', 'userService', 'modalService'];

function showUserController($scope, $location, ngTableParams, toaster, userService, modalService) {
    
    var vm = this;
    vm.Title = "Something missing";

    $scope.$on('userTableEvent', function (event, data) {
        vm.usersTable.reload();
    });

    vm.usersTable = new ngTableParams({
        page: 1,
        count: 10
    }, {
        total: 100,
        getData: function ($defer, params) {
 
            userService.getAllUser().then(onSuccessGetAllUser, onFailedGetAllUser);

            function onSuccessGetAllUser(result) {
                vm.data = result;
                params.total(result.length);
                $defer.resolve(vm.data);
            }

            function onFailedGetAllUser(errorMessage) {
                console.log("Something bad happen");
            }
        }
    });

    vm.doSearch = doSearch;
    vm.addUser = addUser;
    vm.deleteUser = deleteUser;

    function doSearch() {
        toastr.error('Adding User Failed');
        console.log("doSearch");
    }

    function addUser(user) {
        var url = '/EditUser';
        $location.url(url);
    }

    function deleteUser(userId) {
        modalService.confirmationModal(userId, 'userService');
    }
}


