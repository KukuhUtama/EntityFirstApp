videoModule.controller('showVideoController', showVideoController);

showVideoController.$inject = ['ngTableParams', 'videoService'];

function showVideoController(ngTableParams, videoService) {
    console.log(videoService)
    var vm = this;

    vm.videosTable = new ngTableParams({
        page: 1,
        count: 10
    }, {
        total: 100,
        getData: function ($defer, params) {
          
            videoService.getAllVideo().then(onSuccessGetAllVideo, onFailedGetAllVideo);

            function onSuccessGetAllVideo(result) {
                console.log(result);
                vm.data = result;
                params.total(result.length);
                $defer.resolve(vm.data);
            }

            function onFailedGetAllVideo(errorMessage) {
                console.log("Something bad happen");
            }
        }
    });
    console.log("Show cide Controller");
}