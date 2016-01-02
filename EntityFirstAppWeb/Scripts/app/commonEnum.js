var app =  angular.module('EntityFirstApp');

app.service('commonEnum', commonEnum);

function commonEnum() {

    var commonEnum = {

        ajaxMethod: {
            get: 'GET',
            post: 'POST',
            put: 'PUT',
            delete: 'DELETE'
        },

        baseApiUrl: {
            base: 'http://localhost:53974/api'
        },

        webApiUrl: {
            getAllUser: '/user/getAllUser',
            addUser: '/user/addUser',
            deleteUser: '/user/deleteUser',
            getAllVideo: '/video/getallVideo',
            addVideo: '/video/addVideo',
            deleteVideo: '/video/deleteVideo',
            getAllRenting: '/rent/getAllRent',
            addRenting: '/rent/addRent'
        },

        modalUrl: {

        },

        templateUrl: {

        },

        sort: {
            ascending: 'asc',
            descending: 'desc'
        }

    }

    return commonEnum;
}