function GetQauntityByFormull(item) {
    var SN = ($(item).val())
    var formulla = $("#FormullaId").val()
    console.log(formulla)
    $.ajax({
        url: "/FeedList/GetFormullaBySN/" + SN,
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
