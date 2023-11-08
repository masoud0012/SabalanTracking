function GetFormullas(item) {
    var materialId = ($(item).val())
    var formulla = $("#FormullaId").val()
    $.ajax({
        url: "/Formulla/GetByMaterialId/" + materialId,
        method: "GET",
        success: function (response) {
            console.log($.parseJSON(response))
            FeedFormullaList($.parseJSON(response))
            /*let quantity = ($(item).closest('tr').find('input'))*/
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: " + error);
        }
    });

    function FeedFormullaList(list) {
        $("#FormullaId option:not(:first-child)").remove();
        $.each(list, function (item, index) {
            $("#FormullaId").append($('<option>', {
                value: index.Id,
                text: index.Name
            }));
        });
    }
}
