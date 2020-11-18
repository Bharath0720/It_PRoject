function checkForEmptyFieldsLogin() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    if (username == "" || password == "") {
        alert("ERROR");
    }

}
