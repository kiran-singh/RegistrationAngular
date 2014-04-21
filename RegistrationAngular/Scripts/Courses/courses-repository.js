registrationModule.factory('coursesRepository', function ($resource) {
    return {
        get: function() {
            return  $resource('/api/Courses').query();
        }
    };
})