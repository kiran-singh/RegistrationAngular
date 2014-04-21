'use strict';

registrationModule.controller("ClassesController", function ($scope, $window, classesRepository) {
    $scope.schoolDays = classesRepository.get();
    $scope.dayHeadings = ['Day', 1, 2, 3, 4, 5, 6, 7, 8];
    $scope.sayHi = function (period) {
        if ($scope.hasName(period)) {
            $window.alert("Hi from " + period.subject.name);
            return "Happy days";
        }
        return "Not so happy now...";
    };
    $scope.hasName = function (period) {
        return period != null && period.subject != null && period.subject.name !== null;
    };
});
