registrationModule.directive('classRow', function () {
    return {
        restrict: 'E',
        link: function(scope, element, attrs) {
            var html = '<tr>';
            var dayCell = '<td>' + attrs.cls.day + '</td>';
            html += dayCell;
            html += '</tr>';
            element.replaceWith(html);
        }
    };
});