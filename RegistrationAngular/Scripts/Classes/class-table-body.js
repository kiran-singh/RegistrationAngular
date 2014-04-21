registrationModule.directive('classTableBody', function() {
    return {
        restrict: 'E',
        templateUrl: '/templates/directives/classTableBody.html',
        replace: true,
        scope: {
            'dayHeadings': '=',
            'schoolDays': '=',
            'sayHi': '&',
            'hasName': '&'
        }
        ,
        link: function (scope, element, attrs) {
            console.log(scope);
            console.log(element);
            console.log(attrs);
        }
    };
});