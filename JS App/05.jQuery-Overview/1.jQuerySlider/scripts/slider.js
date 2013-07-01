(function ($) {
    var Slider = {
        init: function (time) {
            _self = this;
            this.enlarged = 0;
            this.setOfSlides = [];
            this.time = time;
            this.slider = $('#jQslider');
        },
        addSlide: function (code) {
            this.setOfSlides.push(code);
        },
        previous: function () {
            clearInterval(auto);
            auto = setInterval(_self.tick, _self.time);
            if(crnt > 0) {
                current.hide();
                current = current.prev().show();
                crnt -= 1;
            } else {
                crnt = _self.setOfSlides.length - 1;
                current.hide();
                current = $('#slides').children().last();
                current.show();
            }
        },
        next: function(){
            clearInterval(auto);
            auto = setInterval(_self.tick, _self.time);
            if(crnt < _self.setOfSlides.length - 1) {
                current = current.next().show();
                current.prev().hide();
                crnt += 1;
            } else {
                crnt = 0;
                $('#slides').children().last().hide();
                current = $('#slides').children().first();
                current.show();
            }

        },
        tick: function() {
           _self.next();
        },
        initButtons: function () {
            var prevbtn = $("<button></button>");
            var nextbtn = $("<button></button>");
            prevbtn.attr('id', 'btn-prev');
            nextbtn.attr('id', 'btn-next');
            prevbtn.on('click', this.previous);
            nextbtn.on('click', this.next);
            this.slider.prepend(prevbtn);
            this.slider.append(nextbtn);
        },
        render: function () {
            this.slider.append('<div id="slides"></div>');
            var slides = $('#slides');
            for (var i = 0; i < this.setOfSlides.length; i++) {
                var slide = $('<div id="slide"></div>');
                slide.append($(this.setOfSlides[i])).hide();
                slides.append(slide);
            }
            slides.children().first().show();
            current = slides.children().first();
            crnt = 0;

            this.initButtons();

            auto = setInterval(this.tick, this.time);
        }
    }
	
	var slider = Object.create(Slider);
    slider.init(5000);
    
	slider.addSlide('<img src="images/slider_4.jpg">');
    slider.addSlide('<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam rutrum enim et mi ultricies, a sagittis velit bibendum. Etiam vitae velit feugiat, tempus turpis quis, laoreet tellus. Aliquam sodales mi massa, in dictum enim aliquam ac. Cras accumsan justo vitae massa accumsan egestas. Sed bibendum, diam id rhoncus malesuada, nunc mauris ultricies ligula, id feugiat felis nunc quis nisi. Sed imperdiet id turpis blandit feugiat. Praesent tempor vestibulum consequat. Nunc at turpis odio. Ut semper pharetra lorem vel iaculis. Aliquam eget mi id felis hendrerit ullamcorper. Vivamus vehicula, eros id aliquam semper, nulla dui aliquam lorem, ac tempus magna libero interdum tortor. Proin tempor congue tincidunt. Pellentesque at tincidunt ligula, ut feugiat enim. Nam eleifend velit nec facilisis bibendum. Nulla tempus dictum lacus, nec tempor eros venenatis vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam rutrum enim et mi ultricies, a sagittis velit bibendum. Etiam vitae velit feugiat, tempus turpis quis, laoreet tellus. Aliquam sodales mi massa, in dictum enim aliquam ac. Cras accumsan justo vitae massa accumsan egestas. Sed bibendum, diam id rhoncus malesuada, nunc mauris ultricies ligula, id feugiat felis nunc quis nisi. Sed imperdiet id turpis blandit feugiat. Praesent tempor vestibulum consequat. Nunc at turpis odio. Ut semper pharetra lorem vel iaculis. Aliquam eget mi id felis hendrerit ullamcorper. Vivamus vehicula, eros id aliquam semper, nulla dui aliquam lorem, ac tempus magna libero interdum tortor. Proin tempor congue tincidunt. Pellentesque at tincidunt ligula, ut feugiat enim. Nam eleifend velit nec facilisis bibendum. Nulla tempus dictum lacus, nec tempor eros venenatis vel.</p>');
    slider.addSlide("<div><h1>Test: HTML Text with titile</h1></div>");
	slider.addSlide('<ul>Usefull links:<li><a href="http://www.google.com">Google</a></li><li><a href="https://www.youtube.com/">YouTube</a></li><li><a href="http://forums.academy.telerik.com/">Telerik Academy Forum</a></li></ul>');
    slider.addSlide('<div class="post"><div id="home-content" class="clearfix row"><section class="eight columns"><h2 class="block">What is jQuery?</h2><p>jQuery is a fast, small, and feature-rich JavaScript library. It makes things like HTML document traversal and manipulation, event handling,	animation, and Ajax much simpler with an easy-to-use API that works across a multitude of browsers. With a combination of versatility and extensibility, jQuery has changed the way that millions of people write JavaScript.</p><h2 class="block">Who is Using jQuery</h2><ul class="row" id="whos-using"><li class="three columns"><a class="wordpress" href="http://wordpress.org">WordPress</a></li><li class="three columns"><a class="mediatemple" href="http://mediatemple.com">MediaTemple</a></li><li class="three columns"><a class="backbone" href="http://backbonejs.org/">Backbone.js</a></li><li class="three columns"><a class="wikipedia" href="http://www.wikipedia.org/">Wikipedia</a></li></ul><h2 class="block">Other jQuery Foundation Projects</h2><section class="project-tiles row"><div class="project-tile six columns color secondary-orange"><a href="//jqueryui.com" class="jqueryui small logo">jQueryUI</a></div><div class="project-tile six columns color secondary-green"><a href="//jquerymobile.com" class="jquery-mobile small logo">jQuery Mobile</a></div></section><section class="project-tiles row"><div class="project-tile six columns color qunit-secondary-purple"><a href="//qunitjs.com" class="qunitjs small logo">QUnit</a></div><div class="project-tile six columns color sizzle-red"><a href="//sizzlejs.com" class="sizzlejs small logo">Sizzle</a></div></section></section><aside class="four columns resources"><h3>Resources</h3><ul><li><a href="http://api.jquery.com">jQuery Core API Documentation</a></li><li><a href="http://learn.jquery.com">jQuery Learning Center</a></li><li><a href="http://blog.jquery.com">jQuery Blog</a></li><li><a href="http://contribute.jquery.com">Contribute to jQuery</a></li><li><a href="http://jquery.org">About the jQuery Foundation</a></li><li><a href="http://bugs.jquery.com">Browse or Submit jQuery Bugs</a></li><li class="try-jquery"><a href="http://try.jquery.com">Try jQuery</a></li></ul></aside></div></div>');

    slider.render();
})(jQuery);
