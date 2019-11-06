"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    document.getElementById("messagesList").innerHTML += formatMessage(user, msg);
});

function formatMessage(user, message) {
    return "<div class='message'><img class='profile-picture'/>" +
        "<div class='message-content'><h5 class='message-header'>" +
        user + " " + new Date().toLocaleTimeString() + "</h5><p>" + message + "</p></div></div>";
}

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("messageInput").value = "";
    event.preventDefault();
});