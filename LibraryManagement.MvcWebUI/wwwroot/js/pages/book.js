myApp.controller('BookController', ['$scope', '$rootScope', '$http', 'NgTableParams', function ($scope, $rootScope, $http, NgTableParams) {

    $scope.loadBooks = function () {
        $http({
            method: "POST",
            url: "/Book/GetBookList",
            headers: { "Content-Type": "Application/json;charset=utf-8" },
            data: { }
        }).then(function (response) {
            $scope.bookList = response.data;
            $scope.tableBookParams = new NgTableParams({
            },
                {
                    filterDelay: 0,
                    counts: [10, 20, 50, 100],
                    dataset: angular.copy(response.data)
                });
        });
    }

    $(document).ready(function () {
        $scope.loadBooks();
    });
}]);