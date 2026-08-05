document.addEventListener('DOMContentLoaded', function () {
    // 1. Reusable Dropdown Initialization
    function initCustomDropdown(id, hiddenInputId, onSelectCallback) {
        const wrapper = document.getElementById(id);
        if (!wrapper) return;

        const trigger = wrapper.querySelector('.custom-select-trigger');
        const options = wrapper.querySelectorAll('.custom-option');
        const valueSpan = wrapper.querySelector('span');
        const hiddenInput = document.getElementById(hiddenInputId);

        trigger.addEventListener('click', function (e) {
            e.stopPropagation();
            wrapper.classList.toggle('open');
        });

        options.forEach(option => {
            option.addEventListener('click', function (e) {
                e.stopPropagation();
                const value = this.getAttribute('data-value');
                const text = this.textContent;

                if (valueSpan) valueSpan.textContent = text;
                if (hiddenInput) {
                    hiddenInput.value = value;
                    hiddenInput.dispatchEvent(new Event('change'));
                }

                options.forEach(opt => opt.classList.remove('selected'));
                this.classList.add('selected');

                wrapper.classList.remove('open');

                if (onSelectCallback) onSelectCallback(value);
            });
        });

        document.addEventListener('click', function (e) {
            if (!wrapper.contains(e.target)) {
                wrapper.classList.remove('open');
            }
        });
    }

    // 2. Main Dropdown visibility logic
    const dsaForm = document.getElementById('dsaReportForm');
    const tsForm = document.getElementById('trustSafetyForm');

    function toggleForms(value) {
        if (dsaForm) dsaForm.style.display = (value === "1") ? 'flex' : 'none';
        if (tsForm) tsForm.style.display = (value === "2") ? 'flex' : 'none';
    }

    initCustomDropdown('requestDropdown', 'RequestTypeId', function (val) {
        toggleForms(val);
    });

    // 3. Initialize all sub-dropdowns
    initCustomDropdown('regionDropdown', 'Region');
    initCustomDropdown('confirmationDropdown', 'IsIllegalContent');
    initCustomDropdown('helpDropdown', 'HelpOption');
    initCustomDropdown('countryDropdown', 'Country');
    initCustomDropdown('appealDropdown', 'IsAppealing');

    // 4. File Uploader Helper
    const initUploader = (id) => {
        if (!document.getElementById(id)) return;

        const zone = new FileUploader(id, {
            maxFiles: 5,
            maxSizeMB: 50,
            onFilesAdded: (files) => {
                const zoneElement = document.getElementById(id);
                const text = zoneElement.querySelector('.dropzone-text');
                if (files.length > 0) {
                    text.innerHTML = `<span class="text-primary">${files.length} file(s) selected</span> - <a href="#" class="clear-link text-danger small">Clear</a>`;
                    text.querySelector('.clear-link').onclick = (e) => {
                        e.preventDefault();
                        e.stopPropagation();
                        zone.clear();
                        text.innerHTML = `<a href="#" class="add-file-btn">Add file</a> or drop file here.`;
                    };
                } else {
                    text.innerHTML = `<a href="#" class="add-file-btn">Add file</a> or drop file here.`;
                }
            }
        });
        return zone;
    };

    // 5. Submit Button Enablement
    function checkFormValidity(formId, buttonSelector) {
        const form = document.getElementById(formId);
        if (!form) return;

        const submitBtn = form.querySelector(buttonSelector);
        if (!submitBtn) return;

        function validate() {
            const requiredInputs = form.querySelectorAll('input[required], textarea[required]');
            let allFilled = true;

            requiredInputs.forEach(input => {
                if (!input.value.trim()) allFilled = false;
            });

            const requiredHiddenIds = [
                'Region', 'IsIllegalContent',
                'HelpOption', 'Country', 'IsAppealing'
            ];

            requiredHiddenIds.forEach(id => {
                const hidden = form.querySelector('#' + id);
                if (hidden && !hidden.value.trim()) allFilled = false;
            });

            submitBtn.disabled = !allFilled;
        }

        form.querySelectorAll('input[required], textarea[required]').forEach(input => {
            input.addEventListener('input', validate);
        });

        form.querySelectorAll('input[type="hidden"]').forEach(hidden => {
            hidden.addEventListener('change', validate);
        });

        validate();
    }

    checkFormValidity('dsaReportForm', '.btn-submit-form');
    checkFormValidity('trustSafetyForm', '.btn-submit-form');
});