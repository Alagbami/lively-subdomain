document.addEventListener('DOMContentLoaded', function () {
    // ===== Accordions =====
    document.querySelectorAll('.academy-accordion-header').forEach(function (header) {
        header.addEventListener('click', function () {
            var accordion = header.closest('.academy-accordion');
            accordion.classList.toggle('open');
        });
    });

    // ===== Smooth scroll for in-page quick-nav pills =====
    document.querySelectorAll('a[href^="#"]').forEach(function (link) {
        link.addEventListener('click', function (e) {
            var targetId = link.getAttribute('href');
            if (targetId === '#') return;
            var target = document.querySelector(targetId);
            if (target) {
                e.preventDefault();
                var offset = 90; // account for sticky header
                var top = target.getBoundingClientRect().top + window.pageYOffset - offset;
                window.scrollTo({ top: top, behavior: 'smooth' });
            }
        });
    });
});