/// <reference path="class.js" />
var map;
var Capital = Class.create({
    init: function (name, x, y, info, link) {
        this.name = name;
        this.x = x;
        this.y = y;
        this.info = info;
        this.link = link;
    }

});

var currentCity = 0;

var sofia = new Capital("Sofia", 42.6544, 23.3649, "This is the capitol citie of Bulgaria", 'https://en.wikipedia.org/wiki/Sofia');
var berlin = new Capital("Berlin", 52.5233, 13.4127, "This is the capitol citie of Germany", 'http://en.wikipedia.org/wiki/Berlin');
var paris = new Capital("Paris", 48.8742, 2.3470, "This is the capitol citie of France", 'https://en.wikipedia.org/wiki/Paris');
var ottawa = new Capital("Ottawa", 45.417, -75.7, "Ottawa (Listeni/ˈɒtəwə/ or /ˈɒtəwɑː/) is the capital of Canada, and the fourth largest city in the country.", 'https://en.wikipedia.org/wiki/Ottawa');
var washington = new Capital("Washington", 38.895111, -77.036667, "Washington, D.C., formally the District of Columbia and commonly referred to as Washington,", 'https://en.wikipedia.org/wiki/Washington,_D.C.');
var madrid = new Capital("Madrid", 40.4000, 356.3000, "This is the capitol citie of Spain", 'http://en.wikipedia.org/wiki/Madrid');
var belgrade = new Capital("Belgrade", 44.8206, 20.4622, "This is the capitol citie of Serbia", 'http://en.wikipedia.org/wiki/Belgrade');
var bucharest = new Capital("Bucharest", 44.4167, 26.1000, "This is the capitol citie of Romenia", 'https://en.wikipedia.org/wiki/Bucharest');
var budapest = new Capital("Budapest", 47.5000, 19.0500, "This is the capitol citie of Hungary", 'http://en.wikipedia.org/wiki/Budapest');
var prague = new Capital("Prague", 50.0833, 14.4167, "This is the capitol citie of Czech Republic", 'http://en.wikipedia.org/wiki/Prague');

var capitals = [sofia, berlin, paris, ottawa, washington, madrid, belgrade, bucharest, budapest, prague];

(function visualiseCities() {
    var container = document.getElementById("citiesContainer");

    container.onclick = function (ev) {

        if (ev.target instanceof HTMLAnchorElement) {
            currentCity = parseInt(ev.target.id);
            initialize();
        }
    };

    for (var i = 0; i < capitals.length; i++) {
        container.innerHTML += "<li><a href='#' class='cityLinc' id=" + i + ">" + capitals[i].name + "</a></li>";

    }

}());

function nextCity() {
    currentCity += 1;
    if (currentCity >= capitals.length) {
        currentCity = 0;
    }
    initialize();
};

function prevCity() {
    currentCity -= 1;
    if (currentCity < 0) {
        currentCity = capitals.length - 1;
    }
    initialize();
};

function initialize() {
    var x = capitals[currentCity].x;
    var y = capitals[currentCity].y;
    var z = 7;

    var mapOptions = {
        zoom: z,
        center: new google.maps.LatLng(x, y),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map = new google.maps.Map(document.getElementById('map-canvas'),
        mapOptions);

    var contentString = '<div id="content">' +
     capitals[currentCity].description +
     ' for more info: ' +
     '<br/>' +
     '<a href="' +
     capitals[currentCity].link +
     '">Click Here</a>' +
      '</div>';

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    var marker = new google.maps.Marker({
        position: map.getCenter(),
        map: map,
        title: capitals[currentCity].name
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.open(map, marker);
    });
}
google.maps.event.addDomListener(window, 'load', initialize());