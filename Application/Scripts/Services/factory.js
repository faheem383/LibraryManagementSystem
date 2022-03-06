(function () {
    'use strict';

    var libraryService = angular.module('libraryService', ['ngResource']);
    libraryService.factory('library', ['$resource',
        function ($resource) {
           
            return $resource('/Libraries', {}, {

                APIData:
                {
                    method: 'GET',
                    params: {},
                    isArray: true
                }

            });
          
        }
    ]);
})();
