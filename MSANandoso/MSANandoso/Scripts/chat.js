// Gets current time for the timestamp, obtained from local pc time
function time() {
    var currentTime = new Date();
    var hours = currentTime.getHours();
    var minutes = currentTime.getMinutes();

    // Single digit minutes, add a 0 in front for consistency
    if (minutes < 10)
        minutes = '0' + minutes;

    // Is it AM or PM???
    var ampm = 'AM';
    if (hours >= 12) {
        ampm = 'PM';
        hours = hours - 12;
    }
    // If midnight, it's 12:xx AM
    if (hours === 0) {
        hours = 12;
    }
    // Now put it all together
    var time = (hours + ':' + minutes + ' ' + ampm);
    return time;
}

function initChatClient(username) {
    //$('#displayname').val(prompt('Enter your name:', ''));
    document.getElementById('chatintro').innerHTML = 'You are talking as: ' + '<b>' + username + '</b>';
    //if ($('#displayname').val() === '') {
    //$('#displayname').val('anonymous');
    //document.getElementById('chatintro').innerHTML = 'You are talking as: ' + '<b>' + $('displayname').val() + '</b>';
    //}
    

    // Declare a proxy to reference the hub.
    var chat = $.connection.chatHub;
    // Create a function that the hub can call to broadcast messages.
    chat.client.broadcastMessage = function (name, message) {
        // Html encode display name and message.
        var encodedName = $('<div />').text(name).html();
        var encodedMsg = $('<div />').text(message).html();
        // Add the message to the page.
        $('#discussion').append('<li>' + time() + ' ' + '<strong>' + encodedName + '</strong>:&nbsp;&nbsp;' + encodedMsg + '</li>');
    };

    // Set initial focus to message input box.
    $('#message').focus();
    // Start the connection.
    $.connection.hub.start().done(function () {
        // Allow keyboard enter key to send
        $('#message').keyup(function (e) {
            if (e.keyCode === 13 && ($('#message').val().trim() !== "")) {
                chat.server.send($('#displayname').val(), $('#message').val());
                // Clear text box and reset focus for next comment.
                $('#message').val('').focus();
            }
        });
        // Sends after pressing send button instead of keyboard button press enter
        $('#sendmessage').click(function () {
            // Call the Send method on the hub.
            chat.server.send($('#displayname').val(), $('#message').val());
            // Clear text box and reset focus for next comment.
            $('#message').val('').focus();
        });
    });
}

function validateUsername(username) {
    if (username === undefined || username === null || username.trim() === "") {
        username = "anonymous";
    }
    initChatClient(username);
}

// Chat system
$(function () {
    // Get the user name and store it to prepend to messages.
    var setting = {
        title: "Enter your name",
        text: "or leave blank to talk anonymously",
        type: "input",
        confirmButtonText: "Confirm",
        closeOnConfirm: true,
        animation: "slide-from-top",
        inputPlaceholder: "name goes here"
    }
    swal(setting, function(inputValue) {
        validateUsername(inputValue);
    });
});