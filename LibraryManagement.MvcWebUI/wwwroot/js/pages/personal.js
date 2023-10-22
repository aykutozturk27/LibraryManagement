myApp.controller('PersonalController', ['$scope', '$rootScope', '$http', 'NgTableParams', function ($scope, $rootScope, $http, NgTableParams) {

    $scope.loadPersonals = function () {
        $http({
            method: "POST",
            url: "/Personal/GetPersonalList",
            headers: { "Content-Type": "Application/json;charset=utf-8" },
            data: {}
        }).then(function (response) {
            $scope.personalList = response.data;
            $scope.tablePersonalParams = new NgTableParams({
            },
                {
                    filterDelay: 0,
                    counts: [10, 20, 50, 100],
                    dataset: angular.copy(response.data)
                });
        });
    }

    $(document).ready(function () {
        $scope.loadPersonals();
    });
}]);