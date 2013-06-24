function onButtonClick(event, args) {
    'use strict';
    var currentWindow = window, browserName = currentWindow.navigator.appCodeName;
    var isMozilla = (browserName === "Mozilla");

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}