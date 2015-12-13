app.controller('dashboard', dashboardController);

dashboardController.$inject = ['$scope', '$http', '$location', 'common', 'datacontext'];

function dashboardController($scope, $http, $location, common, datacontext) {
    var getLogFn = common.logger.getLogFn;
    var log = getLogFn('dashboard');

    var vm = this;
    vm.news = {
        title: 'Hot Towel Angular',
        description: 'Hot Towel Angular is a SPA template for Angular developers.'
    };
    vm.messageCount = 0;
    vm.people = [];
    vm.title = 'Dashboard';

    activate();

    function activate() {
        var promises = [getMessageCount(), getPeople()];
        common.activateController(promises, 'dashboard')
            .then(function () { log('Activated Dashboard View'); });
    }

    function getMessageCount() {
        return datacontext.getMessageCount().then(function (data) {
            return vm.messageCount = data;
        });
    }

    function getPeople() {
        return datacontext.getPeople().then(function (data) {
            return vm.people = data;
        });
    }
}