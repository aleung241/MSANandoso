document.addEventListener("DOMContentLoaded", function () {
    console.log("DOM loaded and ready to go!");
    loadFeedbacks();
});

function loadFeedbacks() {
    FeedbackModuleGet.getFeedbacks(setupFeedbacksList);
}

function setupFeedbacksList(feedbacksList) {
    var feedbackGrid = document.getElementById("feedbackList");

    for (var i = 0; i < feedbacksList.length; i ++) {
        var div = document.createElement("div");

        var name = document.createElement("h5");
        name.innerHTML = feedbacksList[i].Name;
        div.appendChild(name);

        var message = document.createElement("p");
        message.innerHTML = feedbacksList[i].Message;
        div.appendChild(message);

        var listbreak = document.createElement("hr");

        feedbackGrid.appendChild(div);
        feedbackGrid.appendChild(listbreak);
    }
}

function submitMessage() {
    var nameBox = document.getElementById("nameBox");
    var messageBox = document.getElementById("messageBox");
    postMessage(nameBox.value, messageBox.value);
}
