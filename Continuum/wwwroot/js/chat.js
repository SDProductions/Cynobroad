"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    document.getElementById("messagesList").innerHTML += formatMessage(user, msg);
});

function formatMessage(user, message) {
    return "<div class='message'><img class='profile-picture'/>" +
        "<div class='message-content'><h5 class='message-header'>" +
        user + " " + new Date().toLocaleTimeString() + "</h5><p>" + message + "</p></div></div>";
}

document.addEventListener("DOMContentLoaded", function () {
    //Disable send button until connection is established
    if (document.getElementById("sendButton")) {
        document.getElementById("sendButton").disabled = true;

        document.getElementById("sendButton").addEventListener("click", function (event) {
            var message = document.getElementById("messageInput").value;
            connection.invoke("SendMessage", message).catch(function (err) {
                return console.error(err.toString());
            });
            document.getElementById("messageInput").value = "";
            event.preventDefault();
        });

        connection.start().then(function () {
            document.getElementById("sendButton").disabled = false;
        }).catch(function (err) {
            return console.error(err.toString());
        });
    }
});

function setDialog(selector) {
    var dialog = document.getElementById("dialog");
    var selected = document.getElementById(selector);

    if (!dialog.style.display) dialog.style.display = "none";

    if (dialog.style.display !== "none") {
        dialog.style.display = "none";
        dialog.childNodes.forEach((value) => value.style.display = "none");
    }
    else {
        dialog.style.display = "flex";
        selected.style.display = "flex";
    }
}

function hideDialog() {
    dialog.style.display = "none";
}

function stopPropogation(event) {
    event.stopPropagation();
}