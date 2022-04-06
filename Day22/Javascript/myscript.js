function Login() {
    var uName = document.getElementById("txtLogin").value;
    var pwd = document.getElementById("txtPassword").value;

    if(uName == "")
    {
        document.getElementById("errMessage").innerText = "Please Enter User Name";
    }
    if(pwd == "")
    {
        document.getElementById("errMessage").innerText = "Please Enter Password";
    }
    if(uName == "" && pwd == "")
    {
        document.getElementById("errMessage").innerText = "Please Enter Your Credentials";
    }

    if(uName == "Nikhil" && pwd == "Admin")
    {
        document.getElementById("errMessage").innerText = "Welcome " + uName;
    }
 }