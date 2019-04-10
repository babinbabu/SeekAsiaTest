
$(document).ready(function () {
    $.blockUI();
    var serviceURL = '/Bill/GetUserTypes';

    $.ajax({
        type: "GET",
        url: serviceURL,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: successFunc,
        error: errorFunc
    });

    function successFunc(data, status) {
        $.unblockUI();
        var sel = $('#customersel');

        $.each(data.Result, function (Text, Value) {
            sel.append('<option value="' + Value.Text + '">' + Value.Text + '</option>');
        });
    }

    function errorFunc() {
        $.unblockUI();
        alert('error');
    }
});
// Bind to the submit event of our form
$("#submitForm").submit(function(event){

    // Prevent default posting of form - put here to work in case of errors
    event.preventDefault();

    // setup some local variables
    var $form = $(this);

    // Let's select and cache all the fields
    var $inputs = $form.find("input, select, button, textarea");

    // Serialize the data in the form
    var serializedData = $form.serialize();

    // Let's disable the inputs for the duration of the Ajax request.
    // Note: we disable elements AFTER the form data has been serialized.
    // Disabled form elements will not be serialized.
    $inputs.prop("disabled", true);

    // Fire off the request to /form.php
    request = $.ajax({
        url: "/Bill/CalculateBillAmount",
        type: "post",
        data: serializedData
    });

    // Callback handler that will be called on success
    request.done(function (response, textStatus, jqXHR){

        if (response.Result != null && response.Result.Message == null)
            swal("Customer : " + response.Result.PrivilageType + "\n" + "SKU Scanned :  " + response.Result.Ads + "\n" + "Total Expected : $" + response.Result.TotalAmount);
        else if (response.Result != null && response.Result.Message != null)
            swal(response.Result.Message);
        else
            swal("An Error Occured");
    });
    // Callback handler that will be called on failure
    request.fail(function (jqXHR, textStatus, errorThrown) {
        // Log the error to the console
        console.error(
            "The following error occurred: " +
            textStatus, errorThrown
        );
        swal("An Error Occured");
    });

    // Callback handler that will be called regardless
    // if the request failed or succeeded
    request.always(function () {
        // Reenable the inputs
        $inputs.prop("disabled", false);
        $form.trigger("reset");
    });

});
