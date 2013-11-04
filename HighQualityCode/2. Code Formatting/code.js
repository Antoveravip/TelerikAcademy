(function () {
    "use strict";
    var theLayer, positionX = 0, positionY = 0, addScroll = false, moveLeft = 10, moveTop = 15, widthX = 120, widthCorr = 150;
	var isNetscape = (navigator.appName === 'Netscape');

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;

    if (isNetscape) {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function popTip() {
        if (isNetscape) {
            theLayer = document.layers.ToolTip;
            if ((positionX + widthX) > window.innerWidth) {
                positionX = window.innerWidth - widthCorr;
            }
            theLayer.left = positionX + moveLeft;
            theLayer.top = positionY + moveTop;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.ToolTip;
            if (theLayer) {
                positionX = event.x - 5;
                positionY = event.y;
                if (addScroll) {
                    positionX = positionX + document.body.scrollLeft;
                    positionY = positionY + document.body.scrollTop;
                }
                if ((positionX + widthX) > document.body.clientWidth) {
                    positionX = positionX - widthCorr;
                }
                theLayer.style.pixelLeft = positionX + moveLeft;
                theLayer.style.pixelTop = positionY + moveTop;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function mouseMove(netscapeEvent) {
        if (isNetscape) {
            positionX = netscapeEvent.pageX - 5;
            positionY = netscapeEvent.pageY;
        } else {
            positionX = event.x - 5;
            positionY = event.y;
        }
        if (isNetscape) {
            if (document.layers.ToolTip.visibility === 'show') {
                popTip();
            }
        } else {
            if (document.all.ToolTip.style.visibility === 'visible') {
                popTip();
            }
        }
    }

    function hideTip() {
        if (isNetscape) {
            document.layers.ToolTip.visibility = 'hide';
        } else {
            document.all.ToolTip.style.visibility = 'hidden';
        }
    }

    function hideMenu1() {
        if (isNetscape) {
            document.layers.menu1.visibility = 'hide';
        } else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }

    function showMenu1() {
        if (isNetscape) {
            theLayer = document.layers.menu1;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.menu1;
            theLayer.style.visibility = 'visible';
        }
    }

    function hideMenu2() {
        if (isNetscape) {
            document.layers.menu2.visibility = 'hide';
        } else {
            document.all.menu2.style.visibility = 'hidden';
        }
    }

    function showMenu2() {
        if (isNetscape) {
            theLayer = document.layers.menu2;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.menu2;
            theLayer.style.visibility = 'visible';
        }
    }
})();