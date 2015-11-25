var FeedbackModuleGet = (function () {
    return {
        getFeedbacks: function (callback) {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://msa2015nandoso.azurewebsites.net/api/Feedbacks",
                success: function (data) {
                    callback(data);
                }
            });
        }
    }
}());

function postMessage (name, message) {
    $.ajax({
        type: "POST",
        data: { Name: name, Message: message },
        url: "http://msa2015nandoso.azurewebsites.net/api/Feedbacks"
    });
}
