videoModule.service('videoService', videoService);

videoService.$inject = ['$http', '$q', 'commonEnum'];

function videoService($http, $q, commonEnum) {

    var videoService = {
        getAllVideo: getAllVideo
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
}