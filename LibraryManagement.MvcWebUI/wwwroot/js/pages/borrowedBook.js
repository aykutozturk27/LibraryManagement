myApp.controller('BorrowedBookController', ['$scope', '$rootScope', '$http', 'NgTableParams', function ($scope, $rootScope, $http, NgTableParams) {

    $scope.loadBorrowedBooks = function () {
        $http({
            method: "POST",
            url: "/Book/GetBorrowedBookList",
            headers: { "Content-Type": "Application/json;charset=utf-8" },
            data: {}
        }).then(function (response) {
            $scope.borrowedBookList = response.data;
            $scope.tableBorrowedBookParams = new NgTableParams({
            },
                {
                    filterDelay: 0,
                    counts: [10, 20, 50, 100],
                    dataset: angular.copy(response.data)
                });
        });
    }

    $(document).ready(function () {
        $scope.loadBorrowedBooks();
    });
}]);