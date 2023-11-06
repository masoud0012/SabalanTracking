﻿$(document).ready(function () {
    var firstRow = $("#details tbody tr:first option:not(:first)");
    $("#MaterialId").on("change", function () {
        var SelectMaterial = $("#MaterialId")
        $.ajax({
            url: "/Material/GetById/" + SelectMaterial.val(),
            method: "GET",
            success: function (response) {
                var material = $.parseJSON(response)
                $("#UnitOfMaterial").text(material.Unit.Name)
            },
            error: function (xhr, status, error) {
                console.error("Error fetching data: " + error);
            }
        });
        //Get All SN based on selected material
       /* $.ajax({
            url: "/FeedList/GetAllSNByMaterialID/" + SelectMaterial.val(),
            method: "GET",
            success: function (response) {
                FeedSelectTag($.parseJSON(response))
            },
            error: function (xhr, status, error) {
                console.error("Error fetching data: " + error);
            }
        });*/
    });
/*    function FeedSelectTag(list) {
        var rows = $("#details tbody tr select");
        rows.find("option:gt(0)").remove()

        $.each(list, function (item, i) {
            $.each(i, function (item, index) {
                rows.append($('<option>', {
                    value: index.SN,
                    text: "متریال:" + index.Material.Name + "||" + "   شماره سریال: " + index.SN + "  ||مانده در انبار: " + index.Quantity + " " + index.Material.Unit.Name
                }));
            });
        });
    }
*/})
