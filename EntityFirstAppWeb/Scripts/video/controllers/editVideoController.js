videoModule.controller('editVideoController', editVideoController);

editVideoController.$inject = ['$location', 'videoService'];

function editVideoController($location, videoService) {
    var vm = this;
    vm.video = {
        Title: "",
        Genre: "",
        AddedDate: "",
        ModifiedDate: "",
        Count: "",
        Status: "",
        RentPrice: "",
    };

    vm.addVideo = addVideo;
    vm.reset = reset;

    function reset() {
        vm.video = {};
    }

    function addVideo() {
        vm.video.AddedDate = new Date();
        vm.video.ModifiedDate = new Date();
        videoService.addVideo(vm.video).then(onSuccessAddVideo, onFailedAddVideo);

        function onSuccessAddVideo(data) {
            toastr.success('Adding Video Success');
            vm.video = {};
            $location.url('/ShowVideo');
        }

        function onFailedAddVideo() {
            toastr.error('Adding Video Failed');
        }
    }

    console.log("Edit Controller");
}