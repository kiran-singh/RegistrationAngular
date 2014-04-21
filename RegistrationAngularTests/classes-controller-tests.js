/// <reference path="Scripts/sinon-1.8.2.js"/>
/// <reference path="../RegistrationAngular/Scripts/angular.js"/>
/// <reference path="../RegistrationAngular/Scripts/angular-resource.js"/>
/// <reference path="../RegistrationAngular/Scripts/angular-route.js"/>
/// <reference path="Scripts/angular-mocks.js"/>
/// <reference path="../RegistrationAngular/Scripts/registration-module.js"/>
/// <reference path="../RegistrationAngular/Scripts/Classes/classes-controller.js"/>
/// <reference path="../RegistrationAngular/Scripts/Classes/classes-repository.js"/>

'use strict';
// ReSharper disable UseOfImplicitGlobalInFunctionScope
(function() {
    describe('During construction of the controller', function() {
        var scope, controller, repositoryMock, schoolDays, window;

        beforeEach(function() {
            module('registrationModule');

            inject(function ($rootScope, $controller, classesRepository, $window) {
                scope = $rootScope.$new();
                window = $window.$new();

                repositoryMock = sinon.stub(classesRepository);
                schoolDays = [{ foo: 'bar' }];
                repositoryMock.get.returns(schoolDays);

                controller = $controller('ClassesController', { $scope: scope });
            });
        });

        it('should set the schooldays from the repository', function() {
            expect(scope.schoolDays).toBe(schoolDays);
        });

        it('should set the dayHeadings', function () {
            var expectedDayHeadings = ['Day', 1, 2, 3, 4, 5, 6, 7, 8];
            expect(scope.dayHeadings).toEqual(expectedDayHeadings);
        });

        it('should set the sayHi function', function () {
            expect(scope.sayHi).toBeDefined();
        });

        it('sayHi should return happy days if hasName is true', function () {
            var period = { foo: 'bar' };
            var stub = sinon.stub(scope, 'hasName');
            stub.onFirstCall().returns(true);

            var windowStub = sinon.stub(window);
            var spy = sinon.spy(windowStub.alert("Hi from " + period.subject.name));

            scope.sayHi(period);
            assert(spy.calledOnce);
            //expect(scope.sayHi(period)).toEqual("Happy days");
        });

        it('sayHi should return not so happy if hasName is false', function () {
            var period = { foo: 'bar' };
            var stub = sinon.stub(scope, 'hasName');
            stub.onFirstCall().returns(false);
            expect(scope.sayHi(period)).toEqual("Not so happy now...");
        });

        it('should set the hasName function', function () {
            expect(scope.hasName).toBeDefined();
        });

        it('hasName should return true if period has subject name', function () {
            var hasName = scope.hasName;
            var period = { subject: { name: "bio" } };
            expect(hasName(period)).toBe(true);
        });

        it('hasName should return false if period has null subject name', function () {
            var hasName = scope.hasName;
            var period = { subject: { name: null } };
            expect(hasName(period)).toBe(false);
        });

        it('hasName should return false if period is null', function () {
            var hasName = scope.hasName;
            expect(hasName(null)).toBe(false);
        });

        it('hasName should return false if period subject is null', function () {
            var hasName = scope.hasName;
            var period = { };
            expect(hasName(period)).toBe(false);
        });
    });
}());