registrationModule.controller("CoursesController", function ($scope, coursesRepository) {
    $scope.courses = coursesRepository.get();
});