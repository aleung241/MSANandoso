function contactButtonClick() {
    console.log("submitted!");
    document.getElementById("contactNameBox").value = "";
    document.getElementById("contactEmailBox").value = "";
    document.getElementById("contactMessageBox").value = "";
    swal("Submitted", "Thank you for your time. We will get back to you within 3-5 business days", "success");
}