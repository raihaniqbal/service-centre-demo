(function () {
    'use strict';

    var app = angular.module('pasServiceCentreApp', []);

    app.directive('pasServiceCentreLocator', pasServiceCentreLocator);

    function pasServiceCentreLocator() {
        return {
            replace: true,
            templateUrl: '/Scripts/app/templates/pasServiceCentreLocatorTemplate.html',
            controller: pasServiceCentreLocatorCtrl,
            controllerAs: 'pasCtrl'
        };
    }

    pasServiceCentreLocatorCtrl.$inject = ['$scope'];

    function pasServiceCentreLocatorCtrl($scope) {

    }

})();