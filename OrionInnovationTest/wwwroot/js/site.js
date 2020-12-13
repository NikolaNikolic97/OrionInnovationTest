// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#dataBase").on("click", sendTextDb);
    $("#file").on("click", sendTextFile);
    $("#userInput").on("click", sendTextUserInput);
});

function sendTextDb() {
    $.ajax({
        url: "http://localhost:56074/Home/ReadText",
        dataType: "JSON",
        type: "POST",
        data: {
            implementation: "db",
            text: null
        },
        success: function (data) {
            console.log(data);
        },
        error: function () {

        }
    })
}
function sendTextFile() {
    $.ajax({
        url: "http://localhost:56074/Home/ReadText",
        dataType: "JSON",
        type: "POST",
        data: {
            implementation: "file",
            text : null
        },
        success: function (data) {
            console.log(data);
        },
        error: function () {

        }
    })
}
function sendTextUserInput() {
    let inputText = $("#user_input_text").val().trim();
    console.log(inputText)
    $.ajax({
        url: "http://localhost:56074/Home/ReadText",
        dataType: "JSON",
        type: "POST",
        data: {
            implementation: "userInput",
            text: inputText
        },
        success: function (data) {
            console.log(data);
        },
        error: function () {

        }
    })
}