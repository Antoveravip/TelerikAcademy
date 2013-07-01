(function ($) {
	$("#before").click(function () {
		$("<li class='li-imp'></li>").
			css("background-color", "#6699aa").
			insertBefore($(".li-imp").first())		
	});

	$("#after").click(function () {
		$("<li class='li-imp'></li>").
			css("background-color", "#aacccc").
			insertAfter($(".li-imp").last())
	});
})(jQuery);