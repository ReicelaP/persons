$('#btnCancelForm').click(function () {
    $('.modal').modal('hide');
});

$('#btnAddPhone').click(function () {
    $('.phones').first().clone().appendTo('.dynamic-body-phone').show();
    attach_delete();
});

$('#btnAddAddress').click(function () {
    $('.addresses').first().clone().appendTo('.dynamic-body-address').show();
    attach_delete();
});

function attach_delete() {
    $('.remove').off();
    $('.remove').click(function () {
        $(this).closest('.form-group').remove();
    });
};

$("#txtPhone").val("");

$("#txtPhoneAdd").val("");

$("#txtAddress").val("");

$("#txtAddressAdd").val("");