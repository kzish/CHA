
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
var dotnetInstance;

function initInstance(dotnetInstance_) {
    dotnetInstance = dotnetInstance_;
    console.log(dotnetInstance);
    initTree();
}

//init tree in coursework
function initTree() {

    console.log('initree called');
    ////
    //if (dotnetInstance == null) {
    //    dotnetInstance = dotnetInstance_;
    //}
    $('#html_course_work').jstree();
    $('#html_exam').jstree();


    $('#html_course_work').on("changed.jstree", function (e, data) {
        var pageData = (data.node.data.jstree.PageData);
        dotnetInstance.invokeMethodAsync("RenderContent", pageData)
    });

    $('#html_exam').on("changed.jstree", function (e, data) {
        var pageData = (data.node.data.jstree.PageData);
        var QuestionID = (data.node.data.jstree.QuestionID);
        console.log(pageData);
        dotnetInstance.invokeMethodAsync("RenderContent", pageData, QuestionID)
    });

}