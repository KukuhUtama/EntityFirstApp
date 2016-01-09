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
            
            function onSuccessDeleteUser(result) {
               
                if (result.Messages[0].MessageType == 0) {
                     $modalInstance.dismiss('this is result for dismiss');
                     toastr.success(result.Messages[0].Value);
                     $rootScope.$broadcast('userTableEvent', {});

                } else if (result.Messages[0].MessageType == 2) {
                     $modalInstance.dismiss('this is result for dismiss');
                     toastr.warning(result.Messages[0].Value);

                } else {
                    toastr.warning(result.Messages[0].Value);

                }
            
            }

            function onFailedDeleteUser(errorMessage) {
                $modalInstance.dismiss('this is result for dismiss');
                console.log("Something bad happen");
            }
        }
        else if(serviceName =='videoService') {
            videoService.deleteVideo($scope.Data).then(onSuccessDeleteVideo, onFailedDeleteVideo);
            

            function onSuccessDeleteVideo(result) {
            
                if (result.Messages[0].MessageType == 0) {
                    $modalInstance.dismiss('this is result for dismiss');
                    toastr.success(result.Messages[0].Value);
                    $rootScope.$broadcast('videoTableEvent', {});
                    console.log("Success");

                } else if (result.Messages[0].MessageType == 2) {
                    console.log("Warning");
                    $modalInstance.dismiss('this is result for dismiss');
                    toastr.warning(result.Messages[0].Value);

                } else {
                    toastr.warning(result.Messages[0].Value);

                }
                
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

    console.log("confirmationModalController");
}