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
    describe('Get call', function() {
        var httpBackend, courseRepo, courses;

        beforeEach(function() {
            module('registrationModule');
            module('ngResource');

            inject(function ($httpBackend, coursesRepository) {
                httpBackend = $httpBackend;
                courses = [{ foo: 'bar' }];
                courseRepo = coursesRepository;
            });
        });

        afterEach(function () {
            httpBackend.verifyNoOutstandingExpectation();
            httpBackend.verifyNoOutstandingRequest();
        });

        it('should get the query result of api/Courses resource', function () {
            httpBackend.expect("GET", "/api/Courses").respond(courses);
            var actual = courseRepo.get();
            httpBackend.flush();
            expect(actual[0].foo).toBe(courses[0].foo);
        });
    });
}());