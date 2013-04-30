(function () {
    'use strict';

    if (!document.querySelector || !document.querySelectorAll) {
        querySelectorShim();
    }
    
    function querySelectorShim() {
        document.querySelector = function querySelector(selector) {
            switch (selector.charAt(0)) {
                case "#": {
                        return document.getElementById(selector.substring(1));
                }
                case ".": {
                        return document.getElementsByClassName(selector.substring(1))[0];
                }
                default: {
                        return document.getElementsByTagName(selector)[0];
                }
            }
        };

        document.querySelectorAll = function querySelectorAll(selector) {
            switch (selector.charAt(0)) {
                case "#": {
                        return document.getElementById(selector.substring(1));
                }
                case ".": {
                        return document.getElementsByClassName(selector.substring(1));
                }
                default: {
                        return document.getElementsByTagName(selector);
                }
            }
        };
    }
})();