// Slider
var slides = document.querySelectorAll('.carousel-inner .carousel-item');
var currentSlide = 0;
var slideInterval = setInterval(nextSlide,2000);
function nextSlide(){
    slides[currentSlide].className = 'carousel-item';
    currentSlide = (currentSlide+1)%slides.length;
    slides[currentSlide].className = 'carousel-item active';
};


// Calendar
$(function() {
    var start = moment().subtract(29, 'days');
    var end = moment();
    function cb(start, end) {
        $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
    }
    $('#reportrange').daterangepicker({
        startDate: start,
        endDate: end,
        ranges: {
           'Today': [moment(), moment()],
           'Tomorrow': [moment().add(1, 'days'), moment().add(1, 'days')],
           'This Week': [moment(), moment().add(6, 'days')],
           'This Month': [moment().startOf('month'), moment().endOf('month')]
        }
    }, cb);
    cb(start, end);
});

// 