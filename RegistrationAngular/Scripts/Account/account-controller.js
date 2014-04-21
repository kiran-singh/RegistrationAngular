'use strict';

registrationModule.controller("AccountController", function($scope, accountRepository, $location) {
    $scope.save = function (student) {
        $scope.error = [];

        accountRepository
            .save(student)
            .$promise
            .then(function() { $location.url('Registration/Courses'); },
                function(response) { $scope.errors = response.data; });
    };
});