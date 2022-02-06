

psngrApp.service('psngrService', function ($http) {
    this.psngrList = function () {
        var response = $http.get('Passengers/GetAllPassenger');
        return response;
    };

    this.insert = function (psngr) {
        var response = $http({
            method: "Post",
            url: "Passengers/Create",
            data: psngr,
            contentType: false,
            processData: false
        });
        return response;
    };

    this.updatePsngr = function (psngr) {
        var response = $http({
            method: 'post',
            url: 'Passengers/Edit',
            data: JSON.stringify(psngr)
        });
        return response;
    };

    this.deletePsngr = function (id) {
        var response = $http({
            method: 'post',
            url: "Passengers/Delete?id=" + id,
            params: { BuildingId: JSON.stringify(id) }
        });
        return response;
    }

    this.trainList = function () {
        var response = $http.get('Passengers/GetAllTrain');
        return response;
    };
    this.routeList = function () {
        var response = $http.get('Passengers/GetAllRoute');
        return response;
    };
    this.classList = function () {
        var response = $http.get('Passengers/GetAllClass');
        return response;
    };
});