angular.module("CustomerApp").controller("CustomerCtrl", function ($scope, $http, $location, $routeParams) {
    $scope.customers = [];
    
    var loadCustomers = function(){
        $http.get("http://localhost:52517/api/customers").success(function (data, status, headers, config) {        
            $scope.customers = data;
        
        }).error(function (data, status, headers, config) { });
    }
    loadCustomers();

    if ($routeParams.CustomerID) {
        $http.get("http://localhost:52517/api/customers/" + $routeParams.CustomerID).success(function (data, status, headers, config) {           
            $scope.customer = data;
        }).error(function (data, status, headers, config) { });
    }
    
    $scope.updateCustomer = function(customer){
        
        $http.put("http://localhost:52517/api/customers/" + customer.id, customer).success(function (data) {
            loadCustomers();
        }).error(function (data) {
           
        });
    }

    $scope.CreateCustomer = function (customer) {        
        $http.post('http://localhost:52517/api/Customers',customer).success(function (data) {
            $location.path("Home");
            loadCustomers();
        }).error(function (error) { 
            console.log(error);
        }).finally(function () {
        	
        });
    }

   
    $scope.deleteCustomer = function (customer) {
        $http.delete('http://localhost:52517/api/Customers/' + customer.id).success(function (data) {

            $.each($scope.customers, function (i) {
                if ($scope.customers[i].id === customer.id) {
                    $scope.customers.splice(i, 1);
                    return false;
                }
            });

        }).error(function (data) {
            
        });
    }
   
})