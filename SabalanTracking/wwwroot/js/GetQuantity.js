function GetQauntity(obj) {
    var SN = obj.value;
    var formullaId = $("#FormullaId").val();
    $.ajax({
        url: "/FeedList/GetQuantity/" + formullaId + "/" + SN,
        method: "GET",
        success: function (response) {
            $(obj).closest('tr').find('input').val(response)
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: " + error);
        }
    });
}