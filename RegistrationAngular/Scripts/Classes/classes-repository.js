registrationModule.factory('classesRepository', function ($resource) {
    return {
        get: function() {
            return $resource('/api/Classes').query();
        }
    };
});