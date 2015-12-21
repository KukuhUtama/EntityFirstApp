userModule.controller('showUserController', showUserController);

showUserController.$inject = ['ngTableParams', 'userService'];

function showUserController(ngTableParams, userService) {
    
    var vm = this;
    vm.Title = "Something missing";
    

    //$scope.usersTable = new ngTableParams({
    //    page: 1,
    //    // show first page
    //    count: 10,
    //    // count per page
    //    sorting: {
        
    //    },
    //    filter: {

    //    }
    //}, {
    //    total: 100,
    //    dataset: data
    //    //getData: function ($defer, params) {
    //    //    var args = {};  
    //    //}
    //});

    //$scope.userTable = new ngTableParams({
    //    page: 1,
    //    count: 10
    //}, {
    //    total: $scope.users.length,
    //    getData: function ($defer, params) {
    //        data = $scope.users;//$scope.users.slice((params.page() - 1) * params.count(), params.page() * params.count());
    //        $defer.resolve(data);
    //    }
    //});

    vm.usersTable = new ngTableParams({
        page: 1,
        count: 10
    }, {
        total: 100,
        getData: function ($defer, params) {
           // vm.data = vm.users.slice((params.page() - 1) * params.count(), params.page() * params.count());
           //$defer.resolve(vm.data);
            userService.getAllUser().then(onSuccessGetAllUser, onFailedGetAllUser);

            function onSuccessGetAllUser(result) {
                console.log(result);
                vm.data = result;
                params.total(result.length);
                $defer.resolve(vm.data);
            }

            function onFailedGetAllUser(errorMessage) {
                console.log("Something bad happen");
            }
        }
    });

    vm.doSearch = function () {
        console.log("Do Search");
        vm.usersTable.reload();
    }
    
}