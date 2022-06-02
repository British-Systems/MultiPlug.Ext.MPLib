(function ($, window) {

    $.multiplug = {
        // subscribedEvent : new Event('onMultiPlugViewSubscribed')
    };

    $.connection.hub.url = "stream";
    var hub = $.connection.wS;

    $.connection.hub.error(function (error) {
        console.log('Web Socket Error: ' + error);
    });

    $.connection.hub.logging = true;

    $.connection.wS.client.send = function (id, Payload) {
        // Required to trigger On(Dis)Connected to fire.
    };

    $.connection.wS.client.forcerefresh = function () {
        window.location.reload(true);
    };

    $.connection.wS.client.ping = function () {
        hub.server.pong();
    };

    $.connection.hub.reconnecting(function() {
        console.log('Web Socket Reconnecting.');

        window.dispatchEvent(new CustomEvent("multiplugReconnecting", {}));

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
        console.log('Web Socket Reconnected.');

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
            $.connection.hub.start();
        }, 5000); // Restart connection after 5 seconds.
    });

    $.connection.hub.start().done(function () {

        var ResponseId = '