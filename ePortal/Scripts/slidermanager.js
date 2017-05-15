$.getScript('slider.js', function () {
    $(document).omSlider({
        slider: $('.slider'),
        dots: $('.dots'),
        next: $('.btn-right'),
        pre: $('.btn-left'),
        timer: 5000,
        showtime: 1000
    });
});
