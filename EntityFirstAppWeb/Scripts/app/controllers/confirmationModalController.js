app.controller('confirmationModalController', confirmationModalController);


confirmationModalController.$inject = ['$rootScope', '$scope', '$modalInstance', 'Id', 'serviceName', 'userService', 'videoService'];

function confirmationModalController($rootScope, $scope, $modalInstance, Id, serviceName, userService, videoService) {
    $scope.Data = Id;
    $scope.OK = OK;
    $scope.Cancel = Cancel;
    
    var serviceName = serviceName;


    function OK() {
        console.log(serviceName);
        if (serviceName == 'userService') {
            userService.deleteUser($scope.Data).then(onSuccessDeleteUser, onFailedDeleteUser);
            console.log("is here");
            function onSuccessDeleteUser(result) {
                $modalInstance.dismiss('this is result for dismiss');
                toastr.success('Delete User Success');
                $rootScope.$broadcast('userTableEvent', {});
            }

            function onFailedDeleteUser(errorMessage) {
                $modalInstance.dismiss('this is result for dismiss');
                console.log("Something bad happen");
            }
        }
        else if(serviceName =='videoService') {
            videoService.deleteVideo($scope.Data).then(onSuccessDeleteVideo, onFailedDeleteVideo);

            function onSuccessDeleteVideo(result) {
                $modalInstance.dismiss('this is result for dismiss');
                toastr.success('Delete Video Success');
                $rootScope.$broadcast('videoTableEvent', {});
            }

            function onFailedDeleteVideo(errorMessage) {
                $modalInstance.dismiss('this is result for dismiss');
                console.log("Something bad happen");
            }
        }
        else if (serviceName == '') {

        } else {
            $modalInstance.dismiss('this is result for dismiss');
        }
      
    }

    function Cancel() {
        $modalInstance.dismiss('this is result for dismiss');
    }
    console.log(Id);
    console.log("confirmationModalController");
}