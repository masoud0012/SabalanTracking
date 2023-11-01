$(document).ready(function () {
    var table = $('#details');
    var rows = table.find('tr');
    console.log(table.find('tbody').find('tr'));
    var rowOuterHtml = rows[rows.length - 1].outerHTML;
    $("#ProcessNameId").on("change", function () {
        let table1 = $('#details');
        if ($("#ProcessNameId").val() == 1) {
            table1.find('tbody').find('tr').remove();
        } else {
            if (table1.find('tbody').find('tr').length == 0) {
                alert(table1.find('tbody').find('tr').length)
                console.log(table1.find('tbody').find('tr'))
                table1.find('tbody').append(rowOuterHtml)
            }
        }
    })
})
