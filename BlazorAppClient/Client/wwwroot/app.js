
function confirm(title, content, yes_call_back) {
    $.confirm({
        title: title,
        content: content,
        buttons: {
            yes: function () {
                yes_call_back;
            },
            no: function () {
            },
        }
    });
}