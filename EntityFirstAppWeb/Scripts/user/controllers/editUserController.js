userModule.controller('editUserController', editUserController);

editUserController.$inject = ['$location', 'userService'];

function editUserController($location, userService) {
    var vm = this;
    vm.user = {
        UserName: "",
        Email: "",
        AddedDate: "",
        ModifiedDate: "",
        Password: "",
    };

    vm.addUser = addUser;
    vm.reset = reset;

    function reset() {
        vm.user = {};
    }

    function addUser() {
        vm.user.AddedDate = new Date();
        vm.user.ModifiedDate = new Date();
        userService.addUser(vm.user).then(onSuccessAddUser, onFailedAddUser);
       
        function onSuccessAddUser(data) {
            toastr.success('Adding User Success');
            vm.user = {};
            $location.url('/ShowUser');
        }

        function onFailedAddUser() {
            toastr.error('Adding User Failed');
        }
    }
    console.log("Edit Controller");
}