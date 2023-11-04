$(document).ready(function () {
    var table = $('#details');
    var rows = table.find('tr');
    var rowOuterHtml = rows[rows.length - 1].outerHTML;

    $("#ProcessNameId").on("change", function () {
        let table1 = $('#details');
        if ($("#ProcessNameId").val() == 1) {
            table1.find('tbody').find('tr').remove();
            $("#FormullaId").prop("disabled", true);
            $("#DeviceId").prop("disabled", true);

        } else {
            $("#FormullaId").prop("disabled", false);
            $("#DeviceId").prop("disabled", false);

            if (table1.find('tbody').find('tr').length == 0) {
                table1.find('tbody').append(rowOuterHtml)
            }
        }
    })
})
