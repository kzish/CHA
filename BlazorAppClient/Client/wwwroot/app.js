
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

//init tree in coursework
function initTree(dotnetInstance) {
    //
    $('#html').jstree();
    $('#html').on("changed.jstree", function (e, data) {
        var pageData = data.node.data.jstree.PageData;
        dotnetInstance.invokeMethodAsync("RenderContent", pageData)
    });
}