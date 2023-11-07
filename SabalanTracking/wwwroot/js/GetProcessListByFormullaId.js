function GetProcessListByFormullaId(obj) {
    var formullId = obj.value;
    $.ajax({
        url: "/Process/getProcessByFormullaID/" + formullId,
        method: "GET",
        success: function (response) {
            var processes = $.parseJSON(response)
            FeedSelectTag(processes);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: " + error);
        }

    });

    function FeedSelectTag(list) {
        var rows = $("#details tbody tr select");
        rows.find("option:gt(0)").remove()
        $.each(list, function (item, index) {
            rows.append($('<option>', {
                value: index.SN,
                text: "متریال:" + index.Material.Name + "||" + "   شماره سریال: " + index.SN + "  ||مانده در انبار: " + index.Quantity + " " + index.Material.Unit.Name
            }));
        });
    }

}
