registrationModule.factory('daysRepository', function () {
    return {
        get: function() {
            return ['Day', 1, 2, 3, 4, 5, 6, 7, 8];
        }
    };
});