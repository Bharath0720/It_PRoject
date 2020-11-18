function checkForEmptyFieldsLogin() {
    var rollno = document.getElementById("roll").value;
    var fname = document.getElementById("fname").value;
    var gender = document.getElementById("gender").value;
    var password = document.getElementById("password").value;
    var cnic = document.getElementById("cnic").value;
    var discipline = document.getElementById("discipline").value;
    var city = document.getElementById("city").value;
    var birthday = document.getElementById("birthday").value;
    if (fname == "" || gender == "" || rol == "" || password == "" || city == "" || cnic == "" || discipline == "") {
        alert("ERROR");
    }
 


}
function TcheckForEmptyFieldsLogin() {
    var fname = document.getElementById("email").value;
    var gender = document.getElementById("gender").value;
    var password = document.getElementById("password").value;
    var cnic = document.getElementById("cnic").value;
    var discipline = document.getElementById("discipline").value;
    var city = document.getElementById("city").value;
    var birthday = document.getElementById("birthday").value;
    if (fname == "" || gender == "" || rol == "" || password == "" || city == "" || cnic == "" || discipline == "") {
        alert("ERROR");
    }



}
function passwordLen() {
    if (strlen(document.getElementById("password").value) < 8)
        alert("WEEK PASSWORD");
}

