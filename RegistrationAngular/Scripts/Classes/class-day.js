'use strict';

registrationModule.directive('classDay', function() {
    return {
        restrict: 'E',
        template: '<span>{{cls.classModels[0].subject}}</span>',
        replace: true,
        //transclude: true,
        scope: {
            cls: '='
        }

    };
});