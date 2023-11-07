function GetFormullas(item) {
    var materialId = ($(item).val())
    var formulla = $("#FormullaId").val()
    $.ajax({
        url: "/Formulla/GetByMaterialId/" + materialId,
        method: "GET",
        success: function (response) {
            console.log($.parseJSON(response))
            let quantity = ($(item).closest('tr').find('input'))
            quantity.val(1)
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: " + error);
        }
    });
}
