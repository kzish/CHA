

function jsconfirm_(title, content) {
    var result="saint";
    result=$.confirm({
        title: title,
        content: content,
        buttons: {
            yes: function () {
                result= "true";
            },
            no: function () {
                result= "false";
            },
        }
    });
    return result;
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
        dotnetInstance.invokeMethodAsync("RenderContent", pageData, QuestionID)
    });

}