$(document).ready(function () {
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
        
    }
})
