(function ($) {
	$("#color-picker").change(function () {
		$("body").css("background-color", $("#color-picker").val());
	});
})(jQuery);