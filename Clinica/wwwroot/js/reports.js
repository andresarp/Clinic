$(document).ready(function){
    $("btnLoadReport").click(function () {
        ReportManager.LoadReport();
    });
});

var ReportManager = {
    LoadReport: function () {
        var jsonParam = "";
        var serviceURL = "../Reports/GenerateReports";
        ReportManager.GetReport(serviceURL, jsonParam, onFailed);
        function onFailed(error) {
            console.error("Se ha presentado un error al cargar el reporte");
        }
    },

    GetReport: function (serviceURL, jsonParams, errorCallback) {
        jQuery.ajax({
            url: serviceURL,
            async: false,
            type: "POST",
            data: "{" + jsonParams + "}",
            contentType: "application/json; charset=utf-8",
            success: function () {
                window.open('../Report/ReportViewer.aspx', '_newtab');
            },
            error: errorCallback
        });
    }

}