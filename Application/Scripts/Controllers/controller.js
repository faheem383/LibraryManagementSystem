(function () {
    'use strict';

    angular
        .module('libraryapp')
        .controller('libraryController', libraryController);

    libraryController.$inject = ['$scope', 'library'];

    function libraryController($scope, library)
    {

        $scope.library = library.APIData();
    }
})();