
userApp.controller('DashboardCtrl', function ($scope, $storage, $rootScope, $routeParams, $location, $timeout, $billtos, $window) {

    $scope.today = new Date();
    $scope.employee_create_page = "/employees/create/";

    $scope.metrics = [{
        "delinquencyLatencyTypeEnum": "slow",
        "balance": 310897.40,
        "count": 413,
        "id": 2
    }, {
        "delinquencyLatencyTypeEnum": "30s",
        "balance": 59154.66,
        "count": 98,
        "id": 3
    }, {
        "delinquencyLatencyTypeEnum": "60s",
        "balance": 33498.26,
        "count": 61,
        "id": 4
    }, {
        "delinquencyLatencyTypeEnum": "90s",
        "balance": 25787.86,
        "count": 45,
        "id": 5
    }, {
        "delinquencyLatencyTypeEnum": "91+",
        "balance": 183656.01,
        "count": 324,
        "id": 6
    }];

    /* set template subviews */
    //$scope.templates = {
    //    stream: "App_Scripts/common/templates/stream.html",
    //    modal: "../App_Scripts/common/templates/drawer.html",
    //    loan: "../App_Scripts/common/templates/make_loan_confirm.html"
    //};


    $scope.SubmitEmployees = function (data) {
        /* show sucess message */
        $rootScope.$notifications.push({
            type: 'success',
            title: 'Borrower Payment collection.',
            message: 'The borrower payment collection data was posted succesfully.'
        });
    }

    
    $scope.remove = function(model, e)
    {
        debugger


    }
    $scope.open = function (model, e) {

        //  $scope['billtos'].$selected = $scope.grids['billtos'].$open(e);

        var data = $scope.grids.not_completed.$get(e);
        console.log("@billtos", data);
        //$location.path('/employees/create/' + data.BillToId);
        $window.location.href = $scope.employee_create_page + data.BillToId;


        //// $scope.billtos.$selected = $scope.grids.billtos.$open(e);
        //var data = $scope.grids.not_completed.$get(e);
        //$storage.put('billtos', data);
        //console.log("@billtos", data);
        //$location.path('../billtos/edit');

    };


    //$scope.$on('$viewContentLoaded', function () {
        
        console.log("@init: dashboard"); 

        $scope.applications = {
            not_completed: []
        };


    ///* get applications by statuses */
    //    $billtos.get({ method: "billtos", companyname: "atlanta" }, function (rows) {
    //        debugger
    //        $scope.applications.not_completed = rows.BillTos.$values[0];
    //    });

        /* get applications in review and fill the datatable*/
        $billtos.get({ method: "billtos" }, function (response) {
             
            //console.log(response.BillTos.$values);
            $scope.applications = response.BillTos.$values;
            var data = JSON.stringify(response.BillTos.$values);
            //$scope.grids.billtos.$add(data);
             
            $scope.grids.not_completed.$data(response.BillTos.$values);

        });

    //});

});