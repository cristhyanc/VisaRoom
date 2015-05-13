

window.imagenVacia = '/assets/UserPhotos/find_user.png';
window.mostrarVistaPrevia = function mostrarVistaPrevia() {

    var Archivos,
        Lector;

    //Para navegadores antiguos
    if (typeof FileReader !== "function") {
        return;
    }

    Archivos = jQuery('#archivo')[0].files;
    if (Archivos.length > 0) {

        Lector = new FileReader();
        Lector.onloadend = function (e) {
            var origen,
                tipo;

            //Envía la imagen a la pantalla
            origen = e.target; //objeto FileReader

            //Prepara la información sobre la imagen
            tipo = window.obtenerTipoMIME(origen.result.substring(0, 30));

           
            //Si el tipo de archivo es válido lo muestra, 
            //sino muestra un mensaje 
            if (tipo !== 'image/jpeg' && tipo !== 'image/png' && tipo !== 'image/gif') {
                jQuery('#vistaPrevia').attr('src', window.imagenVacia);
                alert('El formato de imagen no es válido: debe seleccionar una imagen JPG, PNG o GIF.');
            } else {
                jQuery('#vistaPrevia').attr('src', origen.result);
            }

        };
        Lector.onerror = function (e) {
            console.log(e)
        }
        Lector.readAsDataURL(Archivos[0]);

    } else {
        var objeto = jQuery('#archivo');
        objeto.replaceWith(objeto.val('').clone());
        jQuery('#vistaPrevia').attr('src', window.imagenVacia);
        
    };


};
//Lee el tipo MIME de la cabecera de la imagen
window.obtenerTipoMIME = function obtenerTipoMIME(cabecera) {
    return cabecera.replace(/data:([^;]+).*/, '\$1');
}


function HidePanelHowItWorks(isApplicant) {

    jQuery('#howItApplicant').hide(500);
    jQuery('#howItAgent').show();
    if (isApplicant) {
        jQuery('#howItApplicant').show(500);
        jQuery('#howItAgent').hide(500);
    }
}



$(document).ready(function () {

    $('.datepicker').datepicker(); //Initialise any date pickers
    $(".chosen-select").chosen();
    $(":file").filestyle({ input: false });
 
    //Cargamos la imagen "vacía" que actuará como Placeholder
    jQuery('#vistaPrevia').attr('src', window.imagenVacia);

    //El input del archivo lo vigilamos con un "delegado"
    jQuery('#botonera').on('change', '#archivo', function (e) {
        window.mostrarVistaPrevia();
    });

    //El botón Cancelar lo vigilamos normalmente
    jQuery('#cancelar').on('click', function (e) {
        var objeto = jQuery('#archivo');
        objeto.replaceWith(objeto.val('').clone());

        jQuery('#vistaPrevia').attr('src', window.imagenVacia);
       
    });



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

