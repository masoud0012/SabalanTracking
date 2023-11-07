$(document).ready(function () {
    //var firstRow = $("#details tbody tr:first option:not(:first)");
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

    });
})
