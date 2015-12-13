app.controller('admin', adminController);

adminController.$inject = ['$scope', '$http', '$location', 'common'];

function adminController($scope, $http, $location, common) {
    var getLogFn = common.logger.getLogFn;
    var log = getLogFn('admin');

    var vm = this;
    vm.title = 'Admin';

    activate();

    function activate() {
        common.activateController([], 'admin')
            .then(function () { log('Activated Admin View'); });
    }
}