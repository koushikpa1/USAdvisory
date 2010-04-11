
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

 
function changeMenuColor(menuItem)
{
        
        var MenuItems = ['current', 'MemberZone', 'MyAccount', 'Services','Performance','ContactUs'];
        for (var i = 0; i < MenuItems.length; i++)
        {

            if (MenuItems[i] == menuItem) {
                var item = document.getElementById(menuItem);
                item.style.backgroundColor = '#3f87d1';
            }
            else {
                var item = document.getElementById(MenuItems[i]);
                item.style.backgroundColor = 'none';
            }

        }
        if(menuItem=='MemberZone')
        {
                showSubMenu();
        }
}

function showSubMenu()
{
       obj1=document.getElementById('subMenuDiv'); 
       obj1.style.display = (obj1.style.display != "block") ? "block" : "none"; 
}