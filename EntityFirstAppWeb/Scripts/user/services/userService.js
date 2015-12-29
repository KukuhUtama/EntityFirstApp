userModule.service('userService', userService);

userService.$inject = ['$http', '$q', 'commonEnum'];

function userService($http, $q, commonEnum) {

    var userService = {
        getAllUser: getAllUser,
        addUser: addUser,
        deleteUser : deleteUser
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

    function addUser(user) {
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.post,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.addUser,
            data: user
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

    function deleteUser(userId) {
        var parameters = {
            Id: userId
        }
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.post,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.deleteUser,
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