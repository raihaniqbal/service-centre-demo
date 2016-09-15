(function () {
    'use strict';

    var app = angular.module('pasServiceCentreApp', []);


    app.service('pasLocatorService', ['$http', function ($http) {

        var getNearBy = function (mapLocation) {
            var url = '/api/servicecentres/getnearby?latitude=' + mapLocation.latitude + '&longitude=' + mapLocation.longitude;

            return $http.get(url, {
                headers: { 'Content-Type': 'application/json', 'Accept': 'text/json' }
            }).then(function (response) {
                return response.data;
            }, function (errorResponse) {
                return errorResponse;
            });
        };

        return {
            getNearBy: getNearBy
        };
    }]);

    app.directive('pasServiceCentreLocator', pasServiceCentreLocator);

    function pasServiceCentreLocator() {
        return {
            replace: true,
            templateUrl: '/Scripts/app/templates/pasServiceCentreLocatorTemplate.html',
            controller: pasServiceCentreLocatorCtrl,
            controllerAs: 'pasCtrl'
        };
    }

    pasServiceCentreLocatorCtrl.$inject = ['$scope', 'pasLocatorService'];

    function pasServiceCentreLocatorCtrl($scope, pasLocatorService) {

        var vm = this;

        vm.loadServiceCentres = function (userLocation) {

            pasLocatorService.getNearBy(userLocation).then(function (data) {
                vm.servCentres = data;
            });

        }

        function Init() {
            // HTML5/W3C Geolocation
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    vm.loadServiceCentres({
                        latitude: position.coords.latitude,
                        longitude: position.coords.longitude
                    });
                }, function () {
                    loadDefaultLocation();
                }, { maximumAge: 60000, timeout: 10000 });
            }
            else {
                loadDefaultLocation();
            }
        }

        function loadDefaultLocation() {
            var mapLocation = {
                latitude: -31.862841,
                longitude: 115.817638
            }
            vm.loadServiceCentres(mapLocation);
        }

        Init();
    }

})();