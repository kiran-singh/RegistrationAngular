registrationModule.directive('myScopedDirective', function() {
    return {
        restrict: 'A',
        scope: {
            'title': '@msdTitle'
        },
        link: function($scope, $element, $attrs) {
            $scope.setDirectiveTitle = function(title) {
                $scope.title = title;
            };
        }
    };
});