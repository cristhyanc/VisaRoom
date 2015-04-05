

$(document).ready(function () {

    $('.datepicker').datepicker(); //Initialise any date pickers
    $(".chosen-select").chosen();
//**************** WIZAR BOOTSTRAP***************************//
    $('#rootwizard').bootstrapWizard({
        onTabShow: function (tab, navigation, index) {
            var $total = navigation.find('li').length;
            var $current = index + 1;
            var $percent = ($current / $total) * 100;
            $('#rootwizard').find('.bar').css({ width: $percent + '%' });
        }
    });
    $('#rootwizard .finish').click(function () {
        alert('Finished!, Starting over!');
        $('#rootwizard').find("a[href*='tab1']").trigger('click');
    });
//**************** WIZAR BOOTSTRAP***************************//



   
    



});


//**************** VALIDATION SUMMARY***************************//
$(".validation-summary-errors").removeClass("validation-summary-errors");
$(".input-validation-error").removeClass("input-validation-error").parent().addClass("has-error");
//**************** VALIDATION SUMMARY***************************//



function showModalpopUp() {


    $('#pleaseWaitDialog').modal();

}

function HideModalpopUp() {

    $('#pleaseWaitDialog').modal('hide');

}
