registrationModule.factory('instructorsRepository', function($resource) {
    return {
        get: function() {
            return $resource('/api/Instructors').query();
        }
    };
});