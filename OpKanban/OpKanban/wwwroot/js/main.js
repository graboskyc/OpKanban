window.captureEnter = function(btnid) {
    document.addEventListener("keyup", function(event) {
        // Number 13 is the "Enter" key on the keyboard
        if (event.keyCode === 13) {
            // Cancel the default action, if needed
            event.preventDefault();
            // Trigger the button element with a click
            document.getElementById(btnid).click();
        }
    });
}

window.openEditModal = function() {
    $('#ctr_editmodal').modal('show');
}

window.closeEditModal = function() {
    $('#ctr_editmodal').modal('hide');
}

window.openNewModal = function() {
    $('#ctr_newmodal').modal('show');
}

window.closeNewModal = function() {
    $('#ctr_newmodal').modal('hide');
}

const { shell } = require("electron")

$(document).on('click', 'a[href^="http"]', function(event) {
    event.preventDefault();
    shell.openExternal(this.href);
});