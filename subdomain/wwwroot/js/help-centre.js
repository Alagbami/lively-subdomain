document.addEventListener('DOMContentLoaded', function () {

    // Search Overlay Toggle
    const searchToggle = document.getElementById('searchToggle');
    const searchOverlay = document.getElementById('searchOverlay');
    const closeSearch = document.getElementById('closeSearch');

    if (searchToggle && searchOverlay) {
        searchToggle.addEventListener('click', function (e) {
            e.preventDefault();
            searchOverlay.style.display = 'flex';
            document.body.classList.add('search-open');
        });
    }

    if (closeSearch && searchOverlay) {
        closeSearch.addEventListener('click', function () {
            searchOverlay.style.display = 'none';
            document.body.classList.remove('search-open');
        });
    }

    // Blue Accordion
    document.querySelectorAll('.article-accordion__trigger').forEach(trigger => {
        trigger.addEventListener('click', () => {
            const item = trigger.closest('.article-accordion__item');
            const icon = trigger.querySelector('.article-accordion__icon');
            const isCollapsed = item.classList.toggle('is-collapsed');
            icon.textContent = isCollapsed ? '+' : '−';
        });
    });

    // Yellow Accordion
    document.querySelectorAll('.article-accordion-yellow__trigger').forEach(trigger => {
        trigger.addEventListener('click', () => {
            const item = trigger.closest('.article-accordion-yellow__item');
            const icon = trigger.querySelector('.article-accordion-yellow__icon');
            const isCollapsed = item.classList.toggle('is-collapsed');
            icon.textContent = isCollapsed ? '+' : '−';
        });
    });

    // Grey Accordion
    document.querySelectorAll('.article-accordion-grey__trigger').forEach(trigger => {
        trigger.addEventListener('click', () => {
            const item = trigger.closest('.article-accordion-grey__item');
            const icon = trigger.querySelector('.article-accordion-grey__icon');
            const isCollapsed = item.classList.toggle('is-collapsed');
            icon.textContent = isCollapsed ? '+' : '−';
        });
    });

});

/* =========================================================
   ARTICLE TABS
   Works with the .article-tabs markup.
   - click a tab  -> shows its panel, hides the others
   - keyboard     -> Left/Right/Home/End move between tabs
   - no dependencies (vanilla JS)
   Add this to your site JS (or include as a separate file
   in the article layout).
   ========================================================= */
(function () {
    'use strict';

    function activate(tabs, panels, index) {
        tabs.forEach(function (tab, i) {
            var on = i === index;
            tab.classList.toggle('is-active', on);
            tab.setAttribute('aria-selected', on ? 'true' : 'false');
            tab.setAttribute('tabindex', on ? '0' : '-1');
        });
        panels.forEach(function (panel, i) {
            panel.classList.toggle('is-active', i === index);
            panel.hidden = i !== index;
        });
    }

    function initTabGroup(group) {
        var tabs = Array.prototype.slice.call(group.querySelectorAll('.article-tabs__tab'));
        var panels = Array.prototype.slice.call(group.querySelectorAll('.article-tabs__panel'));
        if (!tabs.length || tabs.length !== panels.length) { return; }

        // wire up ARIA
        var nav = group.querySelector('.article-tabs__nav');
        if (nav) { nav.setAttribute('role', 'tablist'); }

        tabs.forEach(function (tab, i) {
            tab.setAttribute('role', 'tab');
            if (!tab.id) { tab.id = 'tab-' + Math.random().toString(36).slice(2, 9); }
            panels[i].setAttribute('role', 'tabpanel');
            panels[i].setAttribute('aria-labelledby', tab.id);

            tab.addEventListener('click', function () { activate(tabs, panels, i); });

            tab.addEventListener('keydown', function (e) {
                var next = null;
                if (e.key === 'ArrowRight') { next = (i + 1) % tabs.length; }
                else if (e.key === 'ArrowLeft') { next = (i - 1 + tabs.length) % tabs.length; }
                else if (e.key === 'Home') { next = 0; }
                else if (e.key === 'End') { next = tabs.length - 1; }
                if (next !== null) {
                    e.preventDefault();
                    activate(tabs, panels, next);
                    tabs[next].focus();
                }
            });
        });

        // honour a pre-set .is-active tab, otherwise open the first one
        var start = tabs.findIndex(function (t) { return t.classList.contains('is-active'); });
        activate(tabs, panels, start < 0 ? 0 : start);
    }

    function init() {
        document.querySelectorAll('.article-tabs').forEach(initTabGroup);
    }

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', init);
    } else {
        init();
    }

    /* =========================================================
   ARTICLE TABS
   Works with the .article-tabs markup.
   - click a tab  -> shows its panel, hides the others
   - keyboard     -> Left/Right/Home/End move between tabs
   - no dependencies (vanilla JS)
   ========================================================= */
    (function () {
        'use strict';

        function activate(tabs, panels, index) {
            tabs.forEach(function (tab, i) {
                var on = i === index;
                tab.classList.toggle('is-active', on);
                tab.setAttribute('aria-selected', on ? 'true' : 'false');
                tab.setAttribute('tabindex', on ? '0' : '-1');
            });
            panels.forEach(function (panel, i) {
                panel.classList.toggle('is-active', i === index);
                panel.hidden = i !== index;
            });
        }

        function initTabGroup(group) {
            var tabs = Array.prototype.slice.call(group.querySelectorAll('.article-tabs__tab'));
            var panels = Array.prototype.slice.call(group.querySelectorAll('.article-tabs__panel'));
            if (!tabs.length || tabs.length !== panels.length) { return; }

            // wire up ARIA
            var nav = group.querySelector('.article-tabs__nav');
            if (nav) { nav.setAttribute('role', 'tablist'); }

            tabs.forEach(function (tab, i) {
                tab.setAttribute('role', 'tab');
                if (!tab.id) { tab.id = 'tab-' + Math.random().toString(36).slice(2, 9); }
                panels[i].setAttribute('role', 'tabpanel');
                panels[i].setAttribute('aria-labelledby', tab.id);

                tab.addEventListener('click', function () { activate(tabs, panels, i); });

                tab.addEventListener('keydown', function (e) {
                    var next = null;
                    if (e.key === 'ArrowRight') { next = (i + 1) % tabs.length; }
                    else if (e.key === 'ArrowLeft') { next = (i - 1 + tabs.length) % tabs.length; }
                    else if (e.key === 'Home') { next = 0; }
                    else if (e.key === 'End') { next = tabs.length - 1; }
                    if (next !== null) {
                        e.preventDefault();
                        activate(tabs, panels, next);
                        tabs[next].focus();
                    }
                });
            });

            // honour a pre-set .is-active tab, otherwise open the first one
            var start = tabs.findIndex(function (t) { return t.classList.contains('is-active'); });
            activate(tabs, panels, start < 0 ? 0 : start);
        }

        function init() {
            document.querySelectorAll('.article-tabs').forEach(initTabGroup);
        }

        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', init);
        } else {
            init();
        }
    })();
})();
