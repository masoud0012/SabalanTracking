﻿/*$(document).ready(function () {
    var table = document.getElementById('details');
    var rows = table.getElementsByTagName('tr');
    $("#MaterialId").on("change", function () {
        var SelectMaterial = $("#MaterialId")
        $.ajax({
            url: "/Process/getProcessByMaterialID/" + SelectMaterial.val(),
            method: "GET",
            success: function (response) {
                ($.parseJSON(response));
            },
            error: function (xhr, status, error) {
                console.error("Error fetching data: " + error);
            }
        });
    });
})*/