// GETting feedback
var FeedbackModuleGet = (function () {
    return {
        getFeedbacks: function (callback) {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://msa2015nandoso.azurewebsites.net/api/Feedbacks",
                success: function (data) {
                    callback(data);
                    $('.spin').hide();
                }
            });
        }
    }
}());

// POSTing to db the feedback
function postMessage(name, message) {
    $('.spin').show();
    showSpinner();
    $.ajax({
        type: "POST",
        data: { Name: name, Message: message },
        url: "http://msa2015nandoso.azurewebsites.net/api/Feedbacks",
        success: function () {
            $('.spin').hide();
            location.reload();
        }
    });
}
