function applyMPEventPickerOnClick() {
    $(".mp-event-picker").click(function () {

        var TheValueToUpdate = $(this);

        $.get("apps/mplib/event-picker/", function (data, status) {
            $('body').append('<div id="mp-modal-eventselectbackdrop" class="mp-modal-backdrop fade show"></div>');
            $('body').prepend(data);

            $("#mp-modal-eventselectvalue").change(function () {
                TheValueToUpdate.val($(this).val());
                $("#mp-modal-eventselect").remove();
                $("#mp-modal-eventselectbackdrop").remove();
            });
        });
    });
}

applyMPEventPickerOnClick();