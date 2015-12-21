userModule.service('userService', userService);

userService.$inject = ['$http', '$q', 'commonEnum'];

function userService($http, $q, commonEnum) {

    var userService = {
        getAllUser: getAllUser,
    }

    return userService;

    function getAllUser() {
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.get,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.getAllUser,
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