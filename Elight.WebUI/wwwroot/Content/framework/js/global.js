﻿////<reference path="jquery.min.js" />
//依赖项：jquery、layer、select2。

/**
 * 创建模态窗。
 * @param {Object} options
 */
$.layerOpen = function (options) {
    var defaults = {
        id: "default",
        title: '系统窗口',
        type: 2,
        //skin: 'layui-layer-molv',
        width: "auto",
        height: "auto",
        maxmin: false,
        content: '',
        shade: 0.3,
        btn: ['确认', '取消'],
        btnclass: ['btn btn-primary', 'btn btn-danger'],
        yes: null
    };
    var options = $.extend(defaults, options);
    top.layer.open({
        id: options.id,
        type: options.type,
        scrollbar: false,
        //skin: options.skin,
        shade: options.shade,
        shadeClose: true,
        maxmin: options.maxmin,
        title: options.title,
        fix: false,
        area: [options.width, options.height],
        content: options.content,
        btn: options.btn,
        btnclass: options.btnclass,
        yes: function (index, layero) {
            if (options.yes && $.isFunction(options.yes)) {
                var iframebody = top.layer.getChildFrame('body', index);
                var iframeWin = layero.find('iframe')[0].contentWindow;
                options.yes(iframebody, iframeWin, index);
            }
        },
        cancel: function () {
            return true;
        }
    });

}

/**
 * 关闭模态窗。
 */
$.layerClose = function () {
    var index = top.layer.getFrameIndex(window.name);
    top.layer.close(index);
}

/**
 * 创建询问框。
 * @param {Object} options
 */
$.layerConfirm = function (options) {
    var defaults = {
        title: '提示',
        //skin: 'layui-layer-molv',
        content: "",
        icon: 3,
        shade: 0.3,
        anim: 4,
        btn: ['确认', '取消'],
        btnclass: ['btn btn-primary', 'btn btn-danger'],
        callback: null
    };
    var options = $.extend(defaults, options);
    top.layer.confirm(options.content, {
        title: options.title,
        icon: options.icon,
        btn: options.btn,
        btnclass: options.btnclass,
        //skin: options.skin,
        anim: options.anim
    }, function () {
        if (options.callback && $.isFunction(options.callback)) {
            options.callback();
        }
    }, function () {
        return true;
    });
}
/**
 * 创建一个信息弹窗。
 * @param {String} content 
 * @param {String} type 
 */
$.layerMsg = function (content, type, callback) {
    if (type != undefined) {
        var icon = "";
        if (type == 'warning' || type == 0) {
            icon = 0;
        }
        if (type == 'success' || type == 1) {
            icon = 1;
        }
        if (type == 'error' || type == 2) {
            icon = 2;
        }
        if (type == 'info' || type == 6) {
            icon = 6;
        }
        top.layer.msg(content, { icon: icon, time: 2000 }, function () {
            if (callback && $.isFunction(callback)) {
                callback();
            }
        });
    } else {
        top.layer.msg(content, function () {
            if (callback && $.isFunction(callback)) {
                callback();
            }
        });
    }
}

/**
 * 验证日期是否正确
 * 日期格式：yyyy-mm-dd
 */
$.checkDate = function (dateStr) {
    dateStr = dateStr.replace(/\//g, '-');
    var dateReg = /^(\d{4})-(\d{2})-(\d{2})$/;
    var rValue = dateStr.match(dateReg);
    if (rValue == null) {
        return false;
    }
    rValue[1] = parseInt(rValue[1], 10);
    rValue[2] = parseInt(rValue[2] - 1, 10);
    rValue[3] = parseInt(rValue[3], 10);
    var dateObj = new Date(rValue[1], rValue[2], rValue[3]);
    if (dateObj.getFullYear() != rValue[1] || dateObj.getMonth() != rValue[2] || dateObj.getDate() != rValue[3]) {
        return false;
    }
    return true;
}


/**
 * 绑定Select选项。
 * @param {Object} options
 */
$.fn.bindSelect = function (options) {
    var defaults = {
        id: "id",
        text: "text",
        search: true,
        //multiple: false,
        title: "请选择",
        url: "",
        param: [],
        change: null
    };
    var options = $.extend(defaults, options);
    var $element = $(this);
    if (options.url != "") {
        $.ajax({
            url: options.url,
            data: options.param,
            type: options.type,
            dataType: "json",
            async: false,
            success: function (data) {
                $.each(data, function (i) {
                    $element.append($("<option></option>").val(data[i][options.id]).html(data[i][options.text]));
                });
                $element.select2({
                    placeholder: options.title,
                    //multiple: options.multiple,
                    minimumResultsForSearch: options.search == true ? 0 : -1
                });
                $element.on("change", function (e) {
                    if (options.change != null) {
                        options.change(data[$(this).find("option:selected").index()]);
                    }
                    $("#select2-" + $element.attr('id') + "-container").html($(this).find("option:selected").text().replace(/　　/g, ''));
                });
            }
        });
    } else {
        $element.select2({
            minimumResultsForSearch: -1
        });
    }
}

/**
 * 绑定Enter提交事件。
 * @param {Object} $event 需要触发的元素或事件。
 */
$.fn.bindEnterEvent = function ($event) {
    var $selector = $(this);
    $.each($selector, function () {
        $(this).unbind("keydown").bind("keydown", function (event) {
            if (event.keyCode == 13) {
                if ($.isFunction($event)) {
                    $event();
                } else {
                    $event.click();
                }
            }
        });
    });
}

/**
 * 绑定Change提交事件。
 * @param {Object} $event 需要触发的元素或事件。
 * 
 */
$.fn.bindChangeEvent = function ($event) {
    var $selector = $(this);
    $.each($selector, function () {
        $(this).unbind("change").bind("change", function (event) {
            if ($.isFunction($event)) {
                $event();
            } else {
                $event.click();
            }
        })
    });
}

/**
 * 控制授权按钮显示隐藏。
 */
$.fn.authorizeButton = function () {
    var url = top.$("iframe:visible").attr("src");
    var modules = top.client.permission;
    var module = {};
    var childModules = [];
    for (var i = 0; i < modules.length; i++) {
        if (modules[i].Url != "") {
            if (url == modules[i].Url) {
                module = modules[i];
            }
        }
    }
    for (var i = 0; i < modules.length; i++) {
        if (modules[i].Url != "") {
            if (modules[i].ParentId == module.Id) {
                childModules.push(modules[i]);
            }
        }
    }
    if (childModules.length > 0) {
        var $toolbar = $(this);
        var _buttons = '';
        $.each(childModules, function (index, item) {
            _buttons += "<button id='" + item.EnCode + "' onclick='" + item.JsEvent + "' class=\"layui-btn layui-btn-primary layui-btn-small\">";
            _buttons += "   <i class='" + item.Icon + "' aria-hidden='true'></i> " + item.Name + "";
            _buttons += "</button>";
        });
        $toolbar.find('.layui-btn-group:last').html(_buttons);
    } else {
        var $toolbar = $(this);
        $toolbar.css('height', '50px');
    }
}


/**
 * 控制授权按钮显示隐藏。
*/
$.fn.authorizeButtonContains = function (name) {
    var url = top.$("iframe:visible").attr("src");
    var modules = top.client.permission;
    var module = {};
    var childModules = [];
    for (var i = 0; i < modules.length; i++) {
        if (modules[i].Url != "") {
            if (url == modules[i].Url) {
                module = modules[i];
            }
        }
    }
    for (var i = 0; i < modules.length; i++) {
        if (modules[i].Url != "") {
            if (modules[i].ParentId == module.Id) {
                if (modules[i].EnCode.indexOf(name) > -1)
                    childModules.push(modules[i]);
            }
        }
    }
    if (childModules.length > 0) {
        var $toolbar = $(this);
        var _buttons = '';
        $.each(childModules, function (index, item) {
            _buttons += "<button id='" + item.EnCode + "' onclick='" + item.JsEvent + "' class=\"layui-btn layui-btn-primary layui-btn-small\">";
            _buttons += "   <i class='" + item.Icon + "' aria-hidden='true'></i> " + item.Name + "";
            _buttons += "</button>";
        });
        $toolbar.find('.layui-btn-group:last').html(_buttons);
    } else {
        var $toolbar = $(this);
        $toolbar.css('height', '50px');
    }
}

/**
 * 获取数据表格选中行主键值。
 */
$.fn.gridSelectedRowValue = function () {
    var $selectedRows = $(this).children('tbody').find("input[type=checkbox]:checked");
    var result = [];
    if ($selectedRows.length > 0) {
        for (var i = 0; i < $selectedRows.length; i++) {
            result.push($selectedRows[i].value);
        }
    }
    return result;
}

/**
 * 获取URL指定参数值。
 * @param {String} name
 */
$.getQueryString = function (name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

/**
 * 序列化和反序列化表单字段。
 * @param {Object} formdate
 * @param {Function} callback 
 */
$.fn.formSerialize = function (formdate, callback) {
    var $form = $(this);
    if (!!formdate) {
        for (var key in formdate) {
            var $field = $form.find("[name=" + key + "]");
            if ($field.length == 0) {
                continue;
            }
            var value = $.trim(formdate[key]);
            var type = $field.attr('type');
            if ($field.hasClass('select2')) {
                type = "select2";
            }
            switch (type) {
                case "checkbox":
                    value == "true" ? $field.attr("checked", 'checked') : $field.removeAttr("checked");
                    break;
                case "select2":
                    if (!$field[0].multiple) {
                        $field.select2().val(value).trigger("change");
                    } else {
                        var values = value.split(',');
                        $field.select2().val(values).trigger("change");
                    }
                    break;
                case "radio":
                    $field.each(function (index, $item) {
                        if ($item.value == value) {
                            $item.checked = true;
                        }
                    });
                    break;
                default:
                    $field.val(value);
                    break;
            }

        };
        // 特殊的表单字段可以在回调函数中手动赋值。
        if (callback && $.isFunction(callback)) {
            callback(formdate);
        }
        return false;
    }
    var postdata = {};
    $form.find('input,select,textarea').each(function (r) {
        var $this = $(this);
        var id = $this.attr('id');
        var type = $this.attr('type');
        switch (type) {
            case "checkbox":
                postdata[id] = $this.is(":checked");
                break;
            default:
                var value = $this.val() == "" ? "&nbsp;" : $this.val();
                if (!$.getQueryString("id")) {
                    value = value.replace(/&nbsp;/g, '');
                }
                postdata[id] = value;
                break;
        }
    });
    //if ($('[name=__RequestVerificationToken]').length > 0) {
    //    postdata["__RequestVerificationToken"] = $('[name=__RequestVerificationToken]').val();
    //}
    return postdata;
}

/**
 * 提交表单。
 * @param {Object} options
 */
$.formSubmit = function (options) {
    var defaults = {
        url: "",
        data: {},
        type: "post",
        async: false,
        success: null,
        close: true,
        showMsg: true
    };
    var options = $.extend(defaults, options);
    $.ajax({
        url: options.url,
        data: options.data,
        type: options.type,
        async: options.async,
        dataType: "json",
        success: function (data) {
            if (options.success && $.isFunction(options.success)) {
                options.success(data);
            }
            if (options.close) {
                $.layerClose();
            }
            if (options.showMsg) {
                $.layerMsg(data.message, data.state);
            }
        },
        error: function (xhr, status, error) {
            $.layerMsg(error, "error");
        },
        beforeSend: function () {

        },
        complete: function () {

        }
    });
}


$.today = function () {
    return $.formatDate(new Date());
}
$.todayAddDays = function (days) {
    return $.formatDate($.addDays(new Date(), days));
}

/**
 * 输入日期格式与增加的天数，返回日期格式
 * @param {any} date
 * @param {any} days
 */
$.addDays = function (date, days) { 
    date = +date + 1000 * 60 * 60 * 24 * days;
    date = new Date(date);
    return date;
}

/**
 * 格式化日期格式为yyyy-MM-dd
 * @param {any} date
 */
$.formatDate = function (date) {
    var vYear = date.getFullYear();
    var vMon = date.getMonth() + 1;
    var vDay = date.getDate();
    return vYear + "-" + (vMon < 10 ? "0" + vMon : vMon) + "-" + (vDay < 10 ? "0" + vDay : vDay);
}

$.fn.rowspan = function (combined) {
    return this.each(function () {
        var that;
        $('tr', this).each(function (row) {
            $('td:eq(' + combined + ')', this).filter(':visible').each(function (col) {
                if (that != null && $(this).html() == $(that).html()) {
                    rowspan = $(that).attr("rowSpan");
                    if (rowspan == undefined) {
                        $(that).attr("rowSpan", 1);
                        rowspan = $(that).attr("rowSpan");
                    }
                    rowspan = Number(rowspan) + 1;
                    $(that).attr("rowSpan", rowspan);
                    $(this).hide();
                } else {
                    that = this;
                }
            });
        });
    });
}
//function setRowSpan(jq, thatIndex, rowspan, combinedArray) {
//    $('tr', jq).each(function (row1) {
//        if (row1 == thatIndex) {
//            for (var i = 0; i < combinedArray.length; i++) {
//                //每一行
//                $('td:eq(' + combinedArray[i] + ')', this).each(function (col) {
//                    //循环那一列所有的数据
//                    $(this).attr("rowSpan", rowspan);
//                });
//            }
//        }
//    });
//}

//function setHide(jq, thatIndex, combinedArray) {
//    $('tr', jq).each(function (row) {
//        if (row == thatIndex) {
//            for (var i = 0; i < combinedArray.length; i++) {
//                $('td:eq(' + combinedArray[i] + ')', this).each(function (col) {
//                    //循环那一列所有的数据
//                    $(this).hide();
//                });
//            }
//        }
//    });
//}

$.fn.rowspans = function (combined, combinedArray) {
    var jq = this;
    var that;
    var thatIndex = 0;
    $('tr', this).each(function (row) {
        //每一行
        var td = $('td:eq(' + combined + ')', this).filter(':visible').each(function (col) {
            //循环那一列所有的数据
            if (that != null && $(this).html() == $(that).html()) {
                rowspan = $(that).attr("rowSpan");
                if (rowspan == undefined) {
                    $(that).attr("rowSpan", 1);
                    rowspan = $(that).attr("rowSpan");
                }
                rowspan = Number(rowspan) + 1;
                $(that).attr("rowSpan", rowspan);
                //setRowSpan(jq, thatIndex, rowspan, combinedArray);
                $('tr', jq).each(function (row1) {
                    if (row1 == thatIndex) {
                        for (var i = 0; i < combinedArray.length; i++) {
                            //每一行
                            $('td:eq(' + combinedArray[i] + ')', this).each(function (col) {
                                //循环那一列所有的数据
                                $(this).attr("rowSpan", rowspan);
                            });
                        }
                    }
                });
                $(this).hide();
                //setHide(jq, row, combinedArray);
                $('tr', jq).each(function (row1) {
                    if (row1 == row) {
                        for (var i = 0; i < combinedArray.length; i++) {
                            $('td:eq(' + combinedArray[i] + ')', this).each(function (col) {
                                //循环那一列所有的数据
                                $(this).hide();
                            });
                        }
                    }
                });
            } else {
                that = this;
                thatIndex = row;
            }
        });
    });
}


$.download = function (options) {
    var config = $.extend(true, { method: 'post' }, options);
    var $iframe = $('<iframe id="down-file-iframe" />');
    var $form = $('<form target="down-file-iframe" method="' + config.method + '" />');
    $form.attr('action', config.url);
    for (var key in config.data) {
        $form.append('<input type="hidden" name="' + key + '" value="' + config.data[key] + '" />');
    }
    $iframe.append($form);
    $(document.body).append($iframe);
    $form[0].submit();
    $iframe.remove();
}
