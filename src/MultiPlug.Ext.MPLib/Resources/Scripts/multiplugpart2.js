';

        if( ResponseId == null || ResponseId == "")
        {
            return;
        }

        hub.server.subscribe( ResponseId );

        // $(document).trigger("multiplugReady");

        var event = new CustomEvent("multiplugReady", {
        });

        window.dispatchEvent(event);

    });

}(window.jQuery, window));