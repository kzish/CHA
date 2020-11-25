

function jsconfirm_(title, content) {
    var result = "saint";
    result = $.confirm({
        title: title,
        content: content,
        buttons: {
            yes: function () {
                result = "true";
            },
            no: function () {
                result = "false";
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

    $('#mobile-nav').click(function (event) {
        $('._nav').toggleClass('active');
    });
    ////console.log('initree called');
    //if (dotnetInstance == null) {
    //    dotnetInstance = dotnetInstance_;
    //}
    $('#html_course_work').jstree();
    $('#html_exam').jstree();


    $('#html_course_work').on("changed.jstree", function (e, data) {
        var pageData = (data.node.data.jstree.PageData);
        var page_id = (data.node.data.jstree.page_id);
        var topic_id = (data.node.data.jstree.topic_id);
        var has_questions = (data.node.data.jstree.has_questions);
        dotnetInstance.invokeMethodAsync("RenderContent", page_id, pageData, topic_id, has_questions)
    });

    $('#html_exam').on("changed.jstree", function (e, data) {
        var pageData = (data.node.data.jstree.PageData);
        var QuestionID = (data.node.data.jstree.QuestionID);
        dotnetInstance.invokeMethodAsync("RenderContent", pageData, QuestionID)
    });

}

function printCourseWorkPercentageChart(_correct, _failed) {
    var correct = _correct;//parseFloat(_correct);
    var failed = _failed;//parseFloat(_failed);
    Highcharts.chart('printCourseWorkPercentageChart', {
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: 0,
            plotShadow: false
        },
        credits: false,
        title: {
            text: 'Your Score ' + correct + '%',
            align: 'center',
            verticalAlign: 'middle',
            y: 60
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        },
        accessibility: {
            point: {
                valueSuffix: '%'
            }
        },
        plotOptions: {
            pie: {
                dataLabels: {
                    enabled: true,
                    distance: -50,
                    style: {
                        fontWeight: 'bold',
                        color: 'white'
                    }
                },
                startAngle: -90,
                endAngle: 90,
                center: ['50%', '75%'],
                size: '110%'
            }
        },
        series: [{
            type: 'pie',
            name: 'Exam Score',
            innerSize: '50%',
            data: [
                ['Correct (' + correct + ')%', correct],
                ['Failed (' + failed + ')%', failed],
            ]
        }]
    });
}

function printExamPercentageChart(_correct, _failed) {
    var correct = _correct;//parseFloat(_correct);
    var failed = _failed;//parseFloat(_failed);
    Highcharts.chart('printExamPercentageChart', {
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: 0,
            plotShadow: false
        },
        credits: false,
        title: {
            text: 'Your Score ' + correct + '%',
            align: 'center',
            verticalAlign: 'middle',
            y: 60
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        },
        accessibility: {
            point: {
                valueSuffix: '%'
            }
        },
        plotOptions: {
            pie: {
                dataLabels: {
                    enabled: true,
                    distance: -50,
                    style: {
                        fontWeight: 'bold',
                        color: 'white'
                    }
                },
                startAngle: -90,
                endAngle: 90,
                center: ['50%', '75%'],
                size: '110%'
            }
        },
        series: [{
            type: 'pie',
            name: 'Exam Score',
            innerSize: '50%',
            data: [
                ['Correct (' + correct + ')%', correct],
                ['Failed (' + failed + ')%', failed],
            ]
        }]
    });
}