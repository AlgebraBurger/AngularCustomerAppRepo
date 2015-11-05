angular.module("CustomerApp", ["ngRoute"]).config(function ($routeProvider) {
    $routeProvider.when("/Home", {
        templateUrl: "/Views/CustomersList.html",
        controller: 'CustomerCtrl'
    });
    $routeProvider.when("/Customers", {
        templateUrl: "/Views/CustomersList.html"
    });
    $routeProvider.when("/Detail/:CustomerID", {
        templateUrl: "/Views/CustomerDetail.html",
        controller: 'CustomerCtrl',
       
    });
    $routeProvider.when("/AddCustomer", {
        templateUrl: "/Views/CustomerForm.html"
    });  
    $routeProvider.otherwise({
        templateUrl: "/views/CustomersList.html"
    });
});





