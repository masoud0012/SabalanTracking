$(document).ready(function () {
    var firstRow = $("#details tbody tr:first option:not(:first)");

    console.log(firstRow);
    $("#MaterialId").on("change", function () {
        var SelectMaterial = $("#MaterialId")
        $.ajax({
            url: "/FeedList/GetAllSNByMaterialID/" + SelectMaterial.val(),
            method: "GET",
            success: function (response) {
                console.log($.parseJSON(response));
                FeedSelectTag($.parseJSON(response))
            },
            error: function (xhr, status, error) {
                console.error("Error fetching data: " + error);
            }
        });
    });
    function FeedSelectTag(list) {
        var rows = $("#details tbody tr select");
        rows.find("option:gt(0)").remove()

        $.each(list, function (item, i) {
            $.each(i, function (item, index) {
                console.log(index)
                rows.append($('<option>', {
                    value: index.SN,
                    text: "Material:" + index.Material.Name + "||" + "   SN: " + index.SN +"  ||Quantity in stock: "+ index.Quantity
                }));
            });
        });
    }
})
