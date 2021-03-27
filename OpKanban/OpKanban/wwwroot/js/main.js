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

window.detectModalClose = function() {
    $('#ctr_editmodal').on('hidden.bs.modal', function () {
        console.log("Modal closed ");
    });    
}

window.openTheModal = function(id) {
    $('#ctr_editmodal').modal('show');
}

window.closeTheModal = function(id) {
    $('#ctr_editmodal').modal('hide');
}