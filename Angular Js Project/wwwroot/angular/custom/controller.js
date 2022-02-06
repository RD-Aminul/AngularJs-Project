/// <reference path="../angular.js/angular.js" />

psngrApp.controller('psngrController', function ($scope, Upload, $timeout, psngrService) {
    $scope.newPsngr = {};
    $scope.message = "";
    $scope.UploadFiles = function (files) {
        $scope.SelectedFiles = files;
        $scope.newPsngr.ImageName = files[0].name;

    };

    PsngrList();
    function PsngrList() {
        psngrService.psngrList().then(function (result) {
            $scope.psngr = result.data;
        })
    }

    $scope.Insert = function () {
        if ($scope.SelectedFiles && $scope.SelectedFiles.length) {
            UploadFile();
        }
        psngrService.insert($scope.newPsngr).then(function (result) {
            $scope.message = "Passenger Save Successfully";
            ClearAll();
            PsngrList();
        });
    }

    $scope.FillDropDownValue = function () {
        psngrService.trainList().then(function (result) {
            $scope.trains = result.data;
        });
        psngrService.routeList().then(function (result) {
            $scope.routes = result.data;
        });
        psngrService.classList().then(function (result) {
            $scope.classes = result.data;
        });
    }

    $scope.ClearMessage = function () {
        $scope.message = "";
    }

    function UploadFile() {
        Upload.upload({
            url: "api/FileAPI/PsngrImageUpload",
            data: {
                files: $scope.SelectedFiles
            }
        }).then(function (response) {
            $timeout(function () {
                $scope.Result = response.data;
            });
        }, function (response) {
            if (response.status > 0) {
                var errorMsg = response.status + ': ' + response.data;
                alert(errorMsg);
            }
        });
    }

    function ClearAll() {
        $scope.newPsngr = null;
        $(".change_image").val('');
        $('.change_edit').attr('src', 'Images/No Image.jpg');
    }
    $scope.SelectedPsngr = function (psngr) {
        $scope.clickedpsngr = psngr;
        $scope.clickedpsngr.JourneyDate = new Date(psngr.JourneyDate)
        psngrService.trainList().then (function (result) {
            $scope.trains = result.data;
        });
        psngrService.routeList().then (function (result) {
            $scope.routes = result.data;
        });
        psngrService.classList().then(function (result) {
            $scope.classes = result.data;
        });
    };

    $scope.UpdatePsngr = function () {
        psngrService.updatePsngr($scope.clickedpsngr).then(function (result) {
            $scope.Message = "Updated successfully";
            $scope.psngr = result.data;
            PsngrList();
        }, function () {
            alert(result);
        });
    };
    $scope.DeletePsngr = function (id) {
        psngrService.deletePsngr(id).then(function () {
            $scope.Message = "Delete successfully"
            PsngrList();
        }, function (result) {
            alert(result);
        })
    };
});