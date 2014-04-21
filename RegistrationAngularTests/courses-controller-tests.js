/// <reference path="Scripts/sinon-1.7.3.js"/>
/// <reference path="../RegistrationAngular/Scripts/angular.js"/>
/// <reference path="../RegistrationAngular/Scripts/angular-resource.js"/>
/// <reference path="../RegistrationAngular/Scripts/angular-route.js"/>
/// <reference path="Scripts/angular-mocks.js"/>
/// <reference path="../RegistrationAngular/Scripts/registration-module.js"/>
/// <reference path="../RegistrationAngular/Scripts/Courses/courses-controller.js"/>
/// <reference path="../RegistrationAngular/Scripts/Courses/courses-repository.js"/>

'use strict';

(function() {
    describe('During construction of the controller', function() {
        var scope, controller, repositoryMock, courses;

        beforeEach(function() {
            module('registrationModule');

            inject(function($rootScope, $controller, coursesRepository) {
                scope = $rootScope.$new();
                repositoryMock = sinon.stub(coursesRepository);
                courses = [{ foo: 'bar' }];
                repositoryMock.get.returns(courses);
                controller = $controller('CoursesController', { $scope: scope });
            });
        });

        it('should set the courses from the repository', function() {
            expect(scope.courses).toBe(courses);
        });
    });
}());