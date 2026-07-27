/**
 * Global File Upload Utility
 * Handles Drag & Drop and System File Selection
 */

class FileUploader {
    constructor(dropzoneId, options = {}) {
        this.dropzone = document.getElementById(dropzoneId);
        if (!this.dropzone) return;

        this.options = {
            maxFiles: options.maxFiles || 5,
            maxSizeMB: options.maxSizeMB || 50,
            allowedTypes: options.allowedTypes || [],
            onFilesAdded: options.onFilesAdded || null,
            ...options
        };

        this.files = [];
        this.init();
    }

    init() {
        // Create hidden file input
        this.input = document.createElement('input');
        this.input.type = 'file';
        this.input.multiple = this.options.maxFiles > 1;
        this.input.style.display = 'none';
        this.dropzone.appendChild(this.input);

        // Bind events
        this.bindEvents();
    }

    bindEvents() {
        // Click to upload
        const addBtn = this.dropzone.querySelector('.add-file-btn');
        const trigger = addBtn || this.dropzone;

        trigger.addEventListener('click', (e) => {
            e.preventDefault();
            e.stopPropagation();
            this.input.click();
        });

        // Dropzone events
        this.dropzone.addEventListener('dragover', (e) => {
            e.preventDefault();
            this.dropzone.classList.add('drag-over');
        });

        this.dropzone.addEventListener('dragleave', () => {
            this.dropzone.classList.remove('drag-over');
        });

        this.dropzone.addEventListener('drop', (e) => {
            e.preventDefault();
            this.dropzone.classList.remove('drag-over');
            this.handleFiles(e.dataTransfer.files);
        });

        this.input.addEventListener('change', () => {
            this.handleFiles(this.input.files);
        });
    }

    handleFiles(fileList) {
        const newFiles = Array.from(fileList);

        // Basic validation
        const validatedFiles = newFiles.filter(file => {
            const sizeMB = file.size / (1024 * 1024);
            if (sizeMB > this.options.maxSizeMB) {
                alert(`File ${file.name} exceeds ${this.options.maxSizeMB}MB limit.`);
                return false;
            }
            return true;
        });

        // Append new files while respecting the limit
        this.files = [...this.files, ...validatedFiles].slice(0, this.options.maxFiles);

        // Clear input value so selecting the same file again triggers 'change'
        this.input.value = '';

        if (this.options.onFilesAdded) {
            this.options.onFilesAdded(this.files);
        }

        this.updateUI();
    }

    updateUI() {
        // Optional: show list of files in the dropzone or elsewhere
        console.log('Files in uploader:', this.files);
    }

    getFiles() {
        return this.files;
    }

    clear() {
        this.files = [];
        this.input.value = '';
        this.updateUI();
    }
}

// Export to global scope
window.FileUploader = FileUploader;
