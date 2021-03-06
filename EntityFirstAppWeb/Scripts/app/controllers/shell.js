﻿app.controller('shell', shellController);

shellController.$inject = ['$rootScope', 'common', 'config'];

function shellController($rootScope, common, config) {
    console.log(config);
    console.log("shell controller");
    var vm = this;
    var logSuccess = common.logger.getLogFn('shell', 'success');
    console.log(logSuccess);
    var events = config.events;
    vm.busyMessage = 'Please wait ...';
    vm.isBusy = true;
    vm.spinnerOptions = {
        radius: 40,
        lines: 7,
        length: 0,
        width: 30,
        speed: 1.7,
        corners: 1.0,
        trail: 100,
        color: '#F58A00'
    };

    activate();

    function activate() {
        logSuccess('Hot Towel Angular loaded!', null, true);
        common.activateController([], 'shell');
    }

    function toggleSpinner(on) { vm.isBusy = on; }

    $rootScope.$on('$routeChangeStart',
        function (event, next, current) { toggleSpinner(true); }
    );

    $rootScope.$on(events.controllerActivateSuccess,
        function (data) { toggleSpinner(false); }
    );

    $rootScope.$on(events.spinnerToggle,
        function (data) { toggleSpinner(data.show); }
    );
}