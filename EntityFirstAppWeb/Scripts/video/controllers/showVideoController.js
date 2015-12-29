videoModule.controller('showVideoController', showVideoController);

showVideoController.$inject = ['$scope', '$location', 'ngTableParams', 'videoService', 'modalService'];

function showVideoController($scope, $location, ngTableParams, videoService, modalService) {
    
    var vm = this;

    $scope.$on('videoTableEvent', function (event, data) {
        vm.videosTable.reload();
    });

    vm.videosTable = new ngTableParams({
        page: 1,
        count: 10
    }, {
        total: 100,
        getData: function ($defer, params) {
          
            videoService.getAllVideo().then(onSuccessGetAllVideo, onFailedGetAllVideo);

            function onSuccessGetAllVideo(result) {
                vm.data = result;
                params.total(result.length);
                $defer.resolve(vm.data);
            }

            function onFailedGetAllVideo(errorMessage) {
                console.log("Something bad happen");
            }
        }
    });

    vm.addVideo = addVideo;
    vm.deleteVideo = deleteVideo;

    function addVideo() {
        var url = '/EditVideo';
        $location.url(url);
    }

    function deleteVideo(videoId) {
        modalService.confirmationModal(videoId, 'videoService');
    }

    console.log("Show cide Controller");
}