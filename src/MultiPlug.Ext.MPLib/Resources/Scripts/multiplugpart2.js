';

        if( ResponseId == null || ResponseId == "")
        {
            return;
        }

        hub.server.subscribe( ResponseId );

        window.dispatchEvent(new CustomEvent("multiplugReady", {}));
    };

}(window.jQuery, window));