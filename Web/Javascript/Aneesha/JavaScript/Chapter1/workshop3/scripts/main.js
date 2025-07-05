function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;

    var namePattern = /^[A-Za-z\s]+$/;
    var phonePattern = /^\+\d{10,15}$/;
    var websitePattern = /^(https?:\/\/)?(www\.)?[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,}([\/\w \.-]*)*\/?$/;
    if (name === "") {
        alert("Please Enter Name");
        return false;
    }
    if (!namePattern.test(name)) {
        alert("Please enter a valid full name (letters and spaces only)");
        return false;
    }
     
  
    if(email==null || email=="")
    {
        alert("Please Enter Email");
        return false;
    }
    if(phone==null  || phone=="")
    {
        alert("Please Enter Phone Number");
        return false;
    }

    if(!phonePattern.test(phone)){
        alert("Please enter a valid 10-digit Indian mobile number");
        return false;
    }
    if(role=="" || role==null)
    {
        alert("Please Enter Role");
        return false;
    }
    if(location==null || location=="")
    {
        alert("Please Enter Location");
        return false;
    }
    
if (website == null || website == "") {
    alert("Please Enter Website");
    return false;
}
if (!websitePattern.test(website)) {
    alert("Please enter a valid website URL (e.g. https://example.com)");
    return false;
}

function validateMail()
{
    const pattern= /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
   if(!pattern.test(email))
   {
        alert("Please enter valid mail");
        return false;
   }
   return true;
}

