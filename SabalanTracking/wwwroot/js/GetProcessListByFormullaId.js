function GetProcessListByFormullaId(obj) {
    var formullId = obj.value;
    $.ajax({
        url: "/Process/getProcessByFormullaID/" + formullId,
        method: "GET",
        success: function (response) {
            var processes = $.parseJSON(response)
            console.log(processes);
            FeedSelectTag(processes);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: " + error);
        }

    });
}
