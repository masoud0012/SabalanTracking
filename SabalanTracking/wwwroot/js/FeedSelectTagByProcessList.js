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
