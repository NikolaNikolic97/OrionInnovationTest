// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    $("#dataBase").click(function (event) {
        event.preventDefault();
        $.ajax({
            url: "http://localhost:56074/Home/ReadText",
            type: "POST",
            data: {
                implementation: "db",
                text: null
            },
            success: function (data) {
                $("#database_result").text(data);
            },
            error: function () {

            }
        })
    });
    $("#file").click(function (event) {
        event.preventDefault();
        $.ajax({
            url: "http://localhost:56074/Home/ReadText",
            type: "POST",
            data: {
                implementation: "file",
                text: null
            },
            success: function (data) {
                $("#file_result").text(data);
            },
            error: function () {

            }
        })
    });
    $("#userInput").click(function (event) {
        event.preventDefault();
        let inputText = $("#user_input_text").val().trim();
        if (inputText.length > 0) {
            $.ajax({
                url: "http://localhost:56074/Home/ReadText",
                type: "POST",
                data: {
                    implementation: "userInput",
                    text: inputText
                },
                success: function (data) {
                    console.log(data);
                    $("#user_input_result").text(data);
                },
                error: function () {

                }
            })
        }
        else {
            $("#user_input_result").text("You must enter some text to proside");
        }
    });
