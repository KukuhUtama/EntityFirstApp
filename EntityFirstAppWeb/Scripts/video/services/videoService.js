videoModule.service('videoService', videoService);

videoService.$inject = ['$http', '$q', 'commonEnum'];

function videoService($http, $q, commonEnum) {

    var videoService = {
        getAllVideo: getAllVideo,
        addVideo: addVideo,
        deleteVideo : deleteVideo
    }

    return videoService;

    function getAllVideo() {
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.get,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.getAllVideo,
        })
            .success(onSuccess)
            .error(onError);

        function onSuccess(data) {
            deferred.resolve(data);
        }

        function onError() {
            deferred.reject();
        }

        return deferred.promise;
    }

    function addVideo(video) {
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.post,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.addVideo,
            data: video
        })
            .success(onSuccess)
            .error(onError);

        function onSuccess(data) {
            deferred.resolve(data);
        }

        function onError() {
            deferred.reject();
        }

        return deferred.promise;
    }



    function deleteVideo(videoId) {
        var parameters = {
            Id: videoId
        }
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.post,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.deleteVideo,
            params: parameters
        })
            .success(onSuccess)
            .error(onError);

        function onSuccess(data) {
            deferred.resolve(data);
        }

        function onError() {
            deferred.reject();
        }

        return deferred.promise;
    }



}