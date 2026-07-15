document.addEventListener('DOMContentLoaded', function () {
    // Accordions
    document.querySelectorAll('.cacademy-accordion-header').forEach(function (header) {
        header.addEventListener('click', function () {
            header.closest('.cacademy-accordion').classList.toggle('open');
        });
    });

    // Smooth scroll for in-page quick-nav pills
    document.querySelectorAll('a[href^="#"]').forEach(function (link) {
        link.addEventListener('click', function (e) {
            var targetId = link.getAttribute('href');
            if (targetId === '#') return;
            var target = document.querySelector(targetId);
            if (target) {
                e.preventDefault();
                var top = target.getBoundingClientRect().top + window.pageYOffset - 90;
                window.scrollTo({ top: top, behavior: 'smooth' });
            }
        });
    });
});