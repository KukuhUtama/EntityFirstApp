app.service('modalService', modalService);

modalService.$inject = ['$modal'];

function modalService($modal) {

    var modalService = {
        confirmationModal: confirmationModal
    }

    return modalService;

    // ------------------------- //
    // START: Supporting Methods //
    // ------------------------- //
    function openModal(templateUrl, controllerName, size, resolveObject) {
        var modalInstance = $modal.open({
            templateUrl: templateUrl,
            controller: controllerName,
            size: size,
            resolve: resolveObject
        });
        return modalInstance;
    }

    function openModal(templateUrl, controllerName, size, resolveObject, windowClass) {
        var modalInstance = $modal.open({
            templateUrl: templateUrl,
            controller: controllerName,
            size: size,
            resolve: resolveObject,
            windowClass: windowClass
        });
        return modalInstance;
    }


    function confirmationModal(Id, serviceName) {
        var modalInstance = openModal('Scripts/app/views/confirmationModal.html', 'confirmationModalController', 'md', {
            Id: function () {
                return Id;
            },
            serviceName: function () {
                return serviceName;
            }
        });
        return modalInstance;
    }
}