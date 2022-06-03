(function ($, window) {

    $.multiplug = {
    };

    $.connection.hub.url = "stream";
    var hub = $.connection.wS;

    $.connection.hub.error(function (error) {
        console.error('Web Socket Error: ' + error);
    });

    $.connection.hub.logging = true;

    $.connection.wS.client.send = function (id, Payload) {
        // Required to trigger On(Dis)Connected to fire.
    };

    $.connection.wS.client.forcerefresh = function () {
        window.location.reload(true);
    };

    $.connection.hub.reconnecting(function() {
        console.warn('Web Socket Reconnecting.');

        window.dispatchEvent(new CustomEvent("multiplugReconnecting", {}));

        // TODO Move the following out of this file as it's too hard coding to the Default2016 Theme.
        try{
            $("#websocket-title").text("Connection lost.");
            $("#websocket-txt-line1").text("The connection to the MultiPlug Server has been lost. Attempts are being made to restore the connection.");
        }
        catch(err){
        }

        try{
            $('#websocket-reconnect-modal').modal('show');
        }
        catch(err){
        }

    });

    $.connection.hub.reconnected(function() {
        console.info('Web Socket Reconnected.');

        window.dispatchEvent(new CustomEvent("multiplugReconnected", {}));

        // TODO Move the following out of this file as it's too hard coding to the Default2016 Theme.
        try{
            $("#websocket-title").text("Connection Restored.");
            $("#websocket-txt-line1").text("The connection has now been restored, awaiting commands from the Server.");
        }
        catch(err){
        }
    });

    $.connection.hub.disconnected(function() {
        setTimeout(function() {
            console.warn('Disconnected, so attempting to reconnect.');
            $.connection.hub.start().done(doSubscribe);
        }, 5000); // Restart connection after 5 seconds.
    });

    $.connection.hub.start().done(doSubscribe);


    function doSubscribe()
    {
        console.info('Subscribing');
        var ResponseId = '