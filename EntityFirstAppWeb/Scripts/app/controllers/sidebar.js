app.controller("sidebar", sidebarController);

sidebarController.$inject = ['$route', 'config', 'routes'];


function sidebarController($route, config, routes) {
    console.log(routes);
    var vm = this;

    vm.isCurrent = isCurrent;

    activate();

    //function activate() { getNavRoutes(); }

    function getNavRoutes() {
        vm.navRoutes = routes.filter(function (r) {
            return r.config.settings && r.config.settings.nav;
        }).sort(function (r1, r2) {
            return r1.config.settings.nav - r2.config.settings.nav;
        });
    }

    function isCurrent(route) {
        if (!route.config.title || !$route.current || !$route.current.title) {
            return '';
        }
        var menuName = route.config.title;
        return $route.current.title.substr(0, menuName.length) === menuName ? 'current' : '';
    }
}