rentModule.controller('showRentController', showRentController);

showRentController.$inject = ['$location', 'ngTableParams', 'rentService'];

function showRentController($location, ngTableParams, rentService) {
    var vm = this;
    vm.rentsTable = new ngTableParams({
        page: 1,
        count: 10
    }, {
        total: 100,
        getData: function ($defer, params) {

            rentService.getAllRenting().then(onSuccessGetAllRenting, onFailedGetAllRenting);

            function onSuccessGetAllRenting(result) {
                vm.data = result;
                for (i = 0; i < result.length; i++) {
                    vm.data[i].RentPrice = vm.data[i].RentingCost / vm.data[i].RentingLength;
                }
                params.total(result.length);
                $defer.resolve(vm.data);
            }

            function onFailedGetAllRenting(errorMessage) {
                console.log("Something bad happen");
            }
        }
    });

    vm.editRenting = editRenting;

    function editRenting(Id) {
        var url = '/EditRenting/' + Id + '';
        console.log(url);
        $location.url(url);
    }
}