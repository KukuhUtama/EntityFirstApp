﻿rentModule.service('rentService', rentService);

rentService.$inject = ['$http', '$q', 'commonEnum'];

function rentService($http, $q, commonEnum) {

    var rentService = {
        getAllRenting: getAllRenting,
        addRenting: addRenting
    }

    return rentService;

    function getAllRenting() {
        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.get,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.getAllRenting,
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


    function addRenting(rent) {

        var deferred = $q.defer();
        $http({
            method: commonEnum.ajaxMethod.post,
            url: commonEnum.baseApiUrl.base + commonEnum.webApiUrl.addRenting,
            data: rent
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