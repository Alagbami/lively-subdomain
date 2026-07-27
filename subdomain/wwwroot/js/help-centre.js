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