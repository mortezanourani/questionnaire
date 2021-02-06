
function postData() {
    $.ajax({
        type: 'post',
        url: $(this).attr('action'),
        contentType: 'application/x-www-form-urlencoded; charset=utf-8',
        data: $('form').serialize(),
        success: function (result) {
            window.location.replace(result);
        }
    });
}

$('document').ready(function () {
    $('.coronapositive-group').hide();
});

$('.infection-group #positive').change(function () {
    if ($('.infection-group #positive').prop('checked') == true) {
        $('.coronapositive-group').show();
    } else {
        $('.coronapositive-group').hide();
    }
});

$('.infection-group #negative').change(function () {
    if ($('.infection-group #negative').prop('checked') == true) {
        $('.coronapositive-group').hide();
    } else {
        $('.coronapositive-group').show();
    }
});



$('input').change(function () {
    $(this).parent().removeClass('unanswered');
});

$('input').keypress(function () {
    $(this).parent().removeClass('unanswered');
});

$('input[name=infection]').change(function () {
    $(this).parent().removeClass('unanswered');
    if ($('input[name=infection]:checked').val() == 0) {
        $('.coronapositive-group').removeClass('unanswered');
        $('.coronapositive-group input').prop('checked', false);
    }
});

$('#unanswered').change(function () {
    if ($('#unanswered').prop('checked') == true) {
        $('.underlying-group input').prop('checked', false);
        $('#unanswered').prop('checked', true);
    }
});

$('.underlying-group input').change(function () {
    if ($(this).attr('id') != 'unanswered') {
        $('#unanswered').prop('checked', false);
    }
});

$('.newssources-group input[type=text]').keypress(function () {
    if ($(this).val() != "")
        $(this).prev().prev().prop('checked', true);
});

$('.frm-identification').submit(function (evnt) {
    evnt.preventDefault();

    if ($('input[name=age]:checked').val() == undefined) { $('.age-group').addClass('unanswered'); }
    if ($('input[name=gender]:checked').val() == undefined) { $('.gender-group').addClass('unanswered'); }
    if ($('input[name=province]').val() == '') { $('.province-group').addClass('unanswered'); }
    if ($('input[name=marital]:checked').val() == undefined) { $('.marital-group').addClass('unanswered'); }
    if ($('input[name=job]:checked').val() == undefined) { $('.job-group').addClass('unanswered'); }
    if ($('input[name=income]:checked').val() == undefined) { $('.income-group').addClass('unanswered'); }
    if ($('input[name=education]:checked').val() == undefined) { $('.education-group').addClass('unanswered'); }
    if ($('input[name=infection]:checked').val() == undefined) { $('.infection-group').addClass('unanswered'); }
    if ($('input[name=infection]:checked').val() == 1) {
        if ($('input[name=disease]:checked').val() == undefined) { $('.disease-group').addClass('unanswered'); }
        if ($('input[name=diagnosis]:checked').val() == undefined) { $('.diagnosis-group').addClass('unanswered'); }
        if ($('input[name=duration]:checked').val() == undefined) { $('.duration-group').addClass('unanswered'); }
    }
    // if ($('.underlying-group input:checked').val() == undefined) { $('.underlying-group').addClass('unanswered'); }
    // if ($('.newssources-group input:checked').val() == undefined) { $('.newssources-group').addClass('unanswered'); }

    if ($('div').hasClass('unanswered')) {
        $('body').css('overflow', 'hidden');
        $('#promoteDialog').show();
    } else {
        postData();
    }
});

$('.frm-questions').submit(function (evnt) {
    evnt.preventDefault();

    $('input[type=radio]').parent().addClass('unanswered');
    $('input:checked').parent().removeClass('unanswered');

    if ($('div').hasClass('unanswered')) {
        $('body').css('overflow', 'hidden');
        $('#promoteDialog').show();
    } else {
        postData();
    }
});

$('#promoteDialog .cancel').click(function () {
    $('#promoteDialog').hide();
    $('body').css('overflow', 'visible');
});

$('#promoteDialog .accept').click(function () {
    postData();
});
