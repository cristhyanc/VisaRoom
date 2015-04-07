

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


    $("#Register_Country_Value").change(function () {
        var selectedItem = $(this).val();
        var ddlStates = $("#Register_State_Value");
        ddlStates.empty();
        var ddlCities = $("#Register_City_Value");
        ddlCities.empty();
        showModalpopUp();
        $.ajax({
            cache: false,
            type: "GET",
            url: "/Services/GetStatesByCountryId", //url: "@(Url.RouteUrl("GetStatesByCountryId"))",            
            data: { "countryId": selectedItem },
        success: function (data) {

            ddlStates.html('');
            ddlStates.append($('<option></option>').val('-1').html('States'));
            $.each(data, function (id, option) {
                ddlStates.append($('<option></option>').val(option.Value).html(option.Text));
            });
            HideModalpopUp();
        },
        error: function (ex) {
            alert('Failed to retrieve states.' + ex);
            HideModalpopUp();
        }
    });
});
   
    $("#Register_State_Value").change(function () {
    var selectedItem = $(this).val();
    var ddlCities = $("#Register_City_Value");
    ddlCities.empty();
    showModalpopUp();
    $.ajax({
        cache: false,
        type: "GET",
        url: "/Services/GetCityByState",
        data: { "stateId": selectedItem },
    success: function (data) {

        ddlCities.html('');
        ddlCities.append($('<option></option>').val('-1').html('Cities'));
        $.each(data, function (id, option) {
            ddlCities.append($('<option></option>').val(option.Value).html(option.Text));
        });
        HideModalpopUp();
    },
    error: function (ex) {
        alert('Failed to retrieve states.' + ex);
        HideModalpopUp();
    }
});
});    



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

