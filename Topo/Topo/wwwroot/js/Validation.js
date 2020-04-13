document.addEventListener("DOMContentLoaded", function () {

    var Email = document.getElementById("Email");
    var RepPassword = document.getElementById("RepPassword");
    var Password = document.getElementById("Password");
    var form = document.getElementById("form-sub");

    function ChceckPassword(pass) {
        pass.nextElementSibling.innerText = "";

        if (pass.value == "") {
            pass.nextElementSibling.innerText += "pole wymagane,";
        }
        if (pass.value.length < 6) {
            pass.nextElementSibling.innerText += " za krótkie hasło";
        }
        if (pass.value.length > 30) {
            pass.nextElementSibling.innerText += "za długie hasło";
        }
    }

    function ChceckRepPassword(repPass) {

        repPass.nextElementSibling.innerText = "";

        if (repPass.value == "") {
            repPass.nextElementSibling.innerText += "pole wymagane";
        }
        if (repPass.value != Password.value) {
            if (repPass.nextElementSibling.innerText != "")
                repPass.nextElementSibling.innerText += ","

            repPass.nextElementSibling.innerText += " podane hasła się różnią";
        }
    }

    function CheckEmail(email) {

        email.nextElementSibling.innerText = "";

        if (email.value == "") {
            email.nextElementSibling.innerText += "pole wymagane";
        }
        if (email.value.length < 6) {
            if (email.nextElementSibling.innerText != "")
                email.nextElementSibling.innerText += ","

            email.nextElementSibling.innerText += " za krótki email";
        }
        if (email.value.length > 30) {

            email.nextElementSibling.innerText += " za długi email";
        }
        if (!email.value.includes("@")) {
            if (email.nextElementSibling.innerText != "")
                email.nextElementSibling.innerText += ","

            email.nextElementSibling.innerText += " błędny adres email";
        }
    }

    Password.addEventListener("focusout", function () {
        ChceckPassword(Password);
        ChceckRepPassword(RepPassword);
    });

    RepPassword.addEventListener("focusout", function () {
        ChceckRepPassword(RepPassword);
        ChceckPassword(Password);
    });

    Email.addEventListener("focusout", function () {
        CheckEmail(Email);
    });

    form.addEventListener("submit", function (event) {
        event.preventDefault();

        if (Email.nextElementSibling.innerText == "" && Password.nextElementSibling.innerText == "" && RepPassword.nextElementSibling.innerText == "") {
            form.submit();
        }
    })

});