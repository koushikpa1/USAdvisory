
function PhoneValidate(no) 
{
        alert('x');
        if (document.getElementById(no).value.search(/\d{3}\-\d{3}\-\d{4}/) == -1) 
        {
           alert("Please enter a phone number with the format xxx-xxx-xxxx.");
        }
        no.focus();
}

function checkNewNo() 
{
        var Newno = document.getElementById('txtNewNo').value;
        var NewnoConfirm = document.getElementById('txtNewNo1').value;
        alert(Newno);
        if (Newno != NewnoConfirm) 
        {
            alert("The Numbers you entered in New Number and Confirm Boxs are not same!");
        }
}

