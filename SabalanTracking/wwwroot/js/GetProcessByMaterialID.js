$(document).ready(function () {
    var table = document.getElementById('details');
    var rows = table.getElementsByTagName('tr');
    $("#MaterialId").on("change", function () {
        var SelectMaterial = $("#MaterialId")
        $.ajax({
            url: "/Process/getProcessByMaterialID/" + SelectMaterial.val(),
            method: "GET",
            success: function (response) {
                console.log(response)
                /*GetMaterials*/($.parseJSON(response));
            },
            error: function (xhr, status, error) {
                console.error("Error fetching data: " + error);
            }
        });
    });

/*    function GetMaterials(list) {
        console.log(rows)
        var selectM = $('#ProcessDetails_0__ProcessID_SN')
        selectM.empty();
        var newOption = '<Option>انتخاب سریال نامبر</Option>'
        
        for (var i in list) {
            newOption += '<Option value="' + list[i].Id + '">' + list[i].SN + '</Option>'
        }
        selectM.append(newOption)
    }*/
})