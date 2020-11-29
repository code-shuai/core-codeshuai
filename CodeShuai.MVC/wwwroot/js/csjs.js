
//дCookie
function setCookie(objName, objValue, objHours) {
    var str = objName + "=" + escape(objValue); //����
    if (objHours > 0) {//Ϊ0ʱ���趨����ʱ�䣬������ر�ʱcookie�Զ���ʧ
        var date = new Date();
        var ms = objHours * 3600 * 1000;
        date.setTime(date.getTime() + ms);
        str += "; expires=" + date.toGMTString();
    }
    document.cookie = str+'; path=/';
}

//��Cookie
function getCookie(objName) {//��ȡָ�����Ƶ�cookie��ֵ
    var arrStr = document.cookie.split("; ");
    for (var i = 0; i < arrStr.length; i++) {
        var temp = arrStr[i].split("=");
        if (temp[0] == objName) return unescape(temp[1]);  //����
    }
    return "";
}


function delCookie(objName) {
    setCookie(objName, '', -1);
}
function UserExit() {
    delCookie('userAccount');
    window.location.href = '/user/login';
}


function DeleteBill() {

}


//��� �˵�
function AddBill() {
    var billLabel = $("#billLabel").val().split('/');
    var billData = {};

    billData.Money = $("#billMoney").val();
    billData.Remark = $("#billRemark").val();
    billData.LabelName = billLabel[1];
    billData.LabelCode = billLabel[0];
    billData.UserID = 1;
    $.ajax({
        url: "/values/AddBill",
        data: billData,
        dataType: "json",
        type: "POST"
    }).done(function (addTF) {
        if (addTF == 1001) {
            $("#billAddModelCloseBtn").click();
            $("#billData").empty();
            LoadData(0);
        }
    })
}


//���� �˵� ��ǩ �����˵�
function LoadLabel() {
    $("#billLabel").empty();
    $.ajax({
        url: "/values/getlabels",
        data: "",
        dataType: "json",
        type: "get"
    }).done(function (labelData) {
        var billLabelToHtml = '';
        $(labelData).each(function (index, element) {
            billLabelToHtml += '<option>' + element.labelCode + '/' + element.labelName + '</option>';
        })
        $("#billLabel").append(billLabelToHtml);
    })
}


function billLabelBtn(labelId, labelName, labelCode) {
    $("#billLabel").empty();
    $("#billLabel").append('<i id="billLabelCode" class="' + labelCode + '"></i><span id="billLabelName" class="csML-20">' + labelName + '</span>');
}

//���� �˵� ����
function LoadData(pageIndex) {
    var userId = getCookie('userAccount');
    var pageSize = 10;
    $.ajax({
        url: "/values/getbills?pageIndex=" + pageIndex + "&pageSize=" + pageSize + "&id=" + userId,
        data: "",
        dataType: "json",
        type: "get"
    }).done(function (billData) {
        var billDataHeight = $("#billData").outerHeight();
        console.log(billDataHeight)
        if (billDataHeight != 0) {
            $("body,html").animate({
                scrollTop: billDataHeight
            }, 2000);
        }
        var faSize = 'font-size:' + ((window.screen.width / 12) * (3 / 4)).toFixed(2) + 'px';
        var billDataToHtml = '';
        var billAddTime = '';
        $(billData).each(function (index, element) {
            var thisAddTime = new Date(element.addTime);
            var strThisAddTime = thisAddTime.getFullYear() + '.' + thisAddTime.getMonth() + '.' + thisAddTime.getDate();
            if (billAddTime == "") {
                billAddTime = strThisAddTime;
                billDataToHtml += '<div><span  class="csbill-date cstext-orange-2">' + strThisAddTime + '</span></div>';
            } else if (billAddTime != strThisAddTime) {
                billAddTime = strThisAddTime;
                billDataToHtml += '<div><span  class="csbill-date cstext-orange-2">' + strThisAddTime + '</span></div>';
            }
            billDataToHtml +=
                '<div>' +
            '<span class="csML-20"><i class="' + element.labelCode + '  cstext-orange-2" style="' + faSize + '"></i></span>' +
                '<span class="csbill-remark ">' + (element.remark == "" || element.remark == null ? element.labelName : element.remark) + '</span>' +
                '<span class="csbill-money">' + element.money + '</span>' +
                '<hr />' +
                '</div>'

        })
        billDataToHtml += '<br/>';
        $("#billData").append(billDataToHtml);
        $("#billData").append('<div><span  class="text-danger">---------- ��' + (pageIndex + 1) + 'ҳ ----------</span></div>');

    })
}











//var a = $("#sjnavHead").height(),//width()����Ԫ�صĿ�ߣ�������padding/border/margin
//    b = $("#sjnavHead").innerHeight(),//innerWidth()����Ԫ�صĿ�� + padding
//    c = $("#sjnavHead").outerHeight(),//outerWidth()����Ԫ�صĿ�� + padding + border
//    d = $("#sjnavHead").outerHeight(true);//outerWidth(true)����Ԫ�ؿ�� + padding + border + margin
//var wname = window.navigator.userAgent;
//var screen_width = window.screen.width;
//var screen_height = window.screen.height;
//var w = $(document).width();
//var h = $(document).height();
//console.log(a + ',' + b + ',' + c + ',' + d);
//console.log(wname);
//console.log("width:" + screen_width + "--height:" + screen_height + "--otherWidth:" + w + "--otherHeight" + h);
//console.log(sjnavHeight);
