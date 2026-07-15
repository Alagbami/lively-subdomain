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
});
