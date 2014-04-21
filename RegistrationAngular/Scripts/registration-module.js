var registrationModule = angular.module("registrationModule", ['ngRoute', 'ngResource'])
    .config(function($routeProvider, $locationProvider) {
        $routeProvider.when('/Registration/Courses', {
            templateUrl: '/templates/courses.html',
            controller: 'CoursesController'
        });
        $routeProvider.when('/Registration/Instructors', {
            templateUrl: '/templates/instructors.html',
            controller: 'InstructorsController'
        });
        $routeProvider.when('/Registration/CreateAccount', {
            templateUrl: '/templates/create-account.html',
            controller: 'AccountController'
        });
        $routeProvider.when('/Registration/Classes', {
            templateUrl: '/templates/classes.html',
            controller: 'ClassesController'
        });
        $locationProvider.html5Mode(true);
    });