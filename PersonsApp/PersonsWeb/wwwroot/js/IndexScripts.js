$(function () {

    $('.select').change(function () {
        if ($(this).val() == "Single") {
            $('#single').modal('show');          
        }

        if ($(this).val() == "Married") {
            $('#married').modal('show');
        }
       
        $(this).addClass('chosen')
    });

    $('.btnCancel').click(function() {
        $('select.chosen').val("-Select-");
        $('.modal').modal('hide');
        $('select.chosen').removeClass('chosen')
    });

    $('#btnSaveSingle').click(function() {     

        const element = $('select.chosen');
        
        const form = $(element).parent();
        const data = $(form).serialize();
            $.ajax({
                method: "POST",
                url: $(form).attr("action"),
                data: $(form).serialize()
            }).done((response) =>  {
                console.log("submited");
            });
              
        $(element).prop('disabled', true);
        $(element).removeClass('chosen');
            $('#single').modal('hide');
    });

    $('#btnSaveMarried').click(function() {
        const element = $('select.chosen');
        console.log(element);

        const text = $(element).find('option[value="Married"]').text() + ' (' + $('#DataList').val() + ')';
        console.log(text);
        $(element).find('option[value="Married"]').text(text)
        $(element).find('option[value="Married"]').val(text)

        const form = $(element).parent();
        const data = $(form).serialize();
            $.ajax({
                method: "POST",
                url: $(form).attr("action"),
                data: $(form).serialize()
            }).done((response) =>  {
                console.log("submited");
            });

        $(element).prop('disabled', true);
        $(element).removeClass('chosen');
        $('#married').modal('hide');
        $('#DataList').val('');
    });         
});