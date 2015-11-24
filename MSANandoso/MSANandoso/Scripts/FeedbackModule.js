var FeedbackModuleGet = (function () {
    return {
        getFeedbacks: function (callback) {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://localhost:21320/api/Feedbacks",
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
        url: "http://localhost:21320/api/Feedbacks"
    });
}
