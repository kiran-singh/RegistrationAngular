registrationModule.directive('gdayx', function() {
    return {
        restrict: 'E',
        controller: function($scope) {
            $scope.what = "";
            this.is = function(what) {
                $scope.what = what;
            };
        },
        link: function($scope, $element) {
            $element.bind('click', function() {
                alert('GDayX is ' + $scope.what);
            });
        }
    };
});

registrationModule.directive('is', function() {
    return {
        require: 'gdayx',
        restrict: 'A',
        link: function(scope, element, attrs, gdayxCtrl) {
            gdayxCtrl.is(attrs.is);
        }
    };
})