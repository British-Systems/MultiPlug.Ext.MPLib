function applyMPEventPickerOnClick() {
    $(".mp-event-picker").click(function () {

        var TheValueToUpdate = $(this);

        $.get("apps/multiplug.ext.mplib/event-picker/", function (data, status) {
            $('body').append('<div id="mp-modal-eventselectbackdrop" class="mp-modal-backdrop fade show"></div>');
            $('body').prepend(data);

            $("#mp-modal-eventselectvalue").change(function () {
                $("#mp-modal-eventid-input").val($(this).val());
            });

            $("#mp-modal-btn-apply").click(function () {
                TheValueToUpdate.val($("#mp-modal-eventid-input").val());
                $("#mp-modal-eventselect").remove();
                $("#mp-modal-eventselectbackdrop").remove();
            });

            $("#mp-modal-eventid-input").val(TheValueToUpdate.val());
        });
    });
}

applyMPEventPickerOnClick();