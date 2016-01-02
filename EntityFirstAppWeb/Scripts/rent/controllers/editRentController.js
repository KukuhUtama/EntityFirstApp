rentModule.controller('editRentController', editRentController);

editRentController.$inject = ['$routeParams','$location', 'rentService', 'userService', 'videoService'];

function editRentController($routeParams, $location, rentService, userService, videoService) {
    var vm = this;
    
    getAllUser();
    getAllVideo();

    vm.isEditMode = false;

    vm.rent = {
        UserId: 0,
        VideoId: 0,
        RentingLength: 1,
        RentingCost: 0,
        AddedDate: "",
        ModifiedDate: "" 
    };
    
    vm.rentingPrice = 1;

    vm.addRent = addRent;
    vm.updateRent = updateRent;
    vm.reset = reset;
    vm.calcuteRentingCost = calcuteRentingCost;
    vm.isNotVideoUserValid = isNotVideoUserValid;


    if ($routeParams.Id != null) {
        rentService.getRentingById($routeParams.Id)
            .then(function (result) {
                vm.rent = result.Model;
                vm.rentingPrice = vm.rent.RentingCost / vm.rent.RentingLength;
            })
            .catch(function (errorMessage) {
                console.log(errorMessage)
            });

        vm.isEditMode = true;
    }

    function isNotVideoUserValid() {
        if (vm.rent.UserId == 0 || vm.rent.VideoId == 0) {
            return true;
        }
        return false;
    }


    function reset() {
        vm.rent= {};
    }

    function calcuteRentingCost() {
        vm.rent.RentingCost = vm.rent.RentingLength * vm.rentingPrice;
    }

    function addRent() {
        vm.rent.AddedDate = new Date();
        vm.rent.ModifiedDate = new Date();
        rentService.addRenting(vm.rent).then(onSuccessAddRent, onFailedAddRent);

        function onSuccessAddRent(data) {
            toastr.success('Adding Rent Success');
            vm.rent = {};
            $location.url('/ShowRenting');
        }

        function onFailedAddRent() {
            toastr.error('Adding Rent Failed');
        }
    }

    function updateRent() {
        
        rentService.updateRenting(vm.rent).then(onSuccessUpdateRent, onFailedUpdateRent);

        function onSuccessUpdateRent(data) {
            toastr.success('Update Rent Success');
            vm.rent = {};
            $location.url('/ShowRenting');
        }

        function onFailedUpdateRent() {
            toastr.error('Update Rent Failed');
        }
    }


    function getAllUser() {
        userService.getAllUser().then(onSuccessGetAllUser, onFailedGetAllUser);

        function onSuccessGetAllUser(result) {
            vm.users = result;
        }

        function onFailedGetAllUser(errorMessage) {
            console.log("Something bad happen");
        }
    }

    function getAllVideo() {
        videoService.getAllVideo().then(onSuccessGetAllVideo, onFailedGetAllVideo);

        function onSuccessGetAllVideo(result) {
            vm.videos = result;
        }

        function onFailedGetAllVideo(errorMessage) {
            console.log("Something bad happen");
        }
    }
    console.log("Edit Rent Controller");
}