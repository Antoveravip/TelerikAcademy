function generateRandomColor() {
        'use strict';
        var red, green, blue, color;

        red = (Math.random() * 256) | 0;
        green = (Math.random() * 256) | 0;
        blue = (Math.random() * 256) | 0;

        color = "rgb(" + red + "," + green + "," + blue + ")";

        return color;
 }

function generateDiv(rotatableDiv) {
        'use strict';
        var maxWidth, maxHeight, topPos, leftPos;

        rotatableDiv.style.position = "absolute";
        angle += changeAngle;

        maxWidth = screen.width - 100;
        maxHeight = screen.height - 300;
        topPos = Math.floor(maxHeight / divNumber) + (Math.cos(angle) * radius);
        rotatableDiv.style.top = topPos + "px";

        leftPos = Math.floor(maxWidth / divNumber) + (Math.sin(angle) * radius);
        rotatableDiv.style.left = leftPos + "px";

        //rotatableDiv.style.backgroundColor = generateRandomColor();
        //rotatableDiv.style.borderColor = generateRandomColor();
        rotatableDiv.style.backgroundColor = "rgb(132, 203, 244)";
        rotatableDiv.style.borderColor = "rgb(0, 0, 0)";
        rotatableDiv.style.border = "2px solid";			
}

function generateRotatableDivs(divNumber) {
        'use strict';

        for (var i = 0; i < divNumber; i++) {
            var rotatableDiv = document.createElement("div");
            rotatableDiv.classList.add("rotatable-div");
            generateDiv(rotatableDiv);
            docFragment.appendChild(rotatableDiv);
        }
}

function onStartDivsRotation(e) {
        if (!e) e = window.event;

        timer = setInterval(function () {
            for (var i = 0, divLength = rotatableDivs.length;  i < divLength; i++) {
                    generateDiv(rotatableDivs[i]);
            }
        }, 100);

        if (e.preventDefault) {
                e.preventDefault();
        }
        return false;
}

function onStopDivsRotation(e) {
        if (!e) e = window.event;

        clearInterval(timer);
        document.getElementById("btn-stop").disabled = true;

        if (e.preventDefault) {
                e.preventDefault();
        }
        return false;
}