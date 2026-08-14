(function () {
    'use strict';

    // ─── Collapse / Expand ───────────────────────────────────
    var docTitles = document.querySelectorAll('.sidebar-doc-title');

    docTitles.forEach(function (title) {
        // Only attach collapse to non-link doc titles (the active/current doc)
        if (!title.querySelector('a')) {
            title.addEventListener('click', function () {
                var list = title.nextElementSibling;
                if (!list || !list.classList.contains('sidebar-section-list')) return;

                var isCollapsed = list.classList.contains('is-collapsed');
                var icon = title.querySelector('.chevron-icon');

                if (isCollapsed) {
                    // Expand
                    list.classList.remove('is-collapsed');
                    if (icon) icon.src = '/img/arrow-up.svg';
                } else {
                    // Collapse
                    list.classList.add('is-collapsed');
                    if (icon) icon.src = '/img/arrow-down.svg';
                }
            });
        }
    });

    // ─── Scroll-spy ──────────────────────────────────────────
    var sidebarLinks = document.querySelectorAll('.sidebar-link');
    var sections = document.querySelectorAll('.legal-section');

    if (!sidebarLinks.length || !sections.length) return;

    var linkMap = {};
    sidebarLinks.forEach(function (link) {
        var sectionId = link.getAttribute('data-section');
        if (sectionId) linkMap[sectionId] = link;
    });

    function setActiveLink(id) {
        sidebarLinks.forEach(function (link) {
            link.classList.remove('is-active');
        });
        if (linkMap[id]) {
            linkMap[id].classList.add('is-active');

            var sidebar = document.querySelector('.legal-sidebar');
            var activeLink = linkMap[id];
            if (sidebar && activeLink) {
                var linkTop = activeLink.offsetTop;
                var sidebarScrollTop = sidebar.scrollTop;
                var sidebarHeight = sidebar.clientHeight;
                if (linkTop < sidebarScrollTop || linkTop > sidebarScrollTop + sidebarHeight) {
                    sidebar.scrollTo({ top: linkTop - 60, behavior: 'smooth' });
                }
            }
        }
    }

    var observer = new IntersectionObserver(function (entries) {
        entries.forEach(function (entry) {
            if (entry.isIntersecting) {
                setActiveLink(entry.target.id);
            }
        });
    }, {
        rootMargin: '0px 0px -60% 0px',
        threshold: 0
    });

    sections.forEach(function (section) {
        observer.observe(section);
    });

    // ─── Smooth scroll on click ──────────────────────────────
    sidebarLinks.forEach(function (link) {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            var targetId = link.getAttribute('data-section');
            var target = document.getElementById(targetId);
            if (target) {
                target.scrollIntoView({ behavior: 'smooth' });
                setActiveLink(targetId);
            }
        });
    });

})();