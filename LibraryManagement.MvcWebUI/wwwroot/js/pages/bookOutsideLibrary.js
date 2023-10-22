myApp.controller('BookOutsideLibraryController', ['$scope', '$rootScope', '$http', 'NgTableParams', function ($scope, $rootScope, $http, NgTableParams) {

    $scope.loadBookOutsideLibrarys = function () {
        $http({
            method: "POST",
            url: "/Book/GetBookOutsideLibraryGroupedISBN",
            headers: { "Content-Type": "Application/json;charset=utf-8" },
            data: {}
        }).then(function (response) {
            $scope.bookOutsideLibraryList = response.data;
            $scope.tableBookOutsideLibraryParams = new NgTableParams({
            },
                {
                    filterDelay: 0,
                    counts: [10, 20, 50, 100],
                    dataset: angular.copy(response.data)
                });
        });
    }

    $(document).ready(function () {
        $scope.loadBookOutsideLibrarys();
    });
}]);