function DeleteItem(btn) {
    $(btn).closest('tr').remove();
}
function AddItem(btn) {
    var table = document.getElementById('details');
    var rows = table.getElementsByTagName('tr');

    var rowOuterHtml = rows[rows.length - 1].outerHTML;

    var lastRowIdx = document.getElementById("hdnLastIndex").value;
    var nextRowIdx = eval(lastRowIdx) + 1;
    document.getElementById("hdnLastIndex").value = nextRowIdx;

    rowOuterHtml = rowOuterHtml.replaceAll("[" + lastRowIdx + "]", "[" + nextRowIdx + "]")
    rowOuterHtml = rowOuterHtml.replaceAll("_" + lastRowIdx + "_", "_" + nextRowIdx + "_")
    rowOuterHtml = rowOuterHtml.replaceAll("-" + lastRowIdx, "-" + nextRowIdx)

    var newRow = table.insertRow();

    newRow.innerHTML = rowOuterHtml;

    var btnAddId = btn.id
    var btnDeleteId = btnAddId.replaceAll('btnAdd', 'btnRemove');

    var delbtn = document.getElementById(btnDeleteId);
    delbtn.classList.add("visible");
    delbtn.classList.remove("invisible");

    var addBtn = document.getElementById(btnAddId);
    addBtn.classList.remove("visible");
    addBtn.classList.add("invisible");
}