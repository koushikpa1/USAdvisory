// JScript File
var currentRow;
var oldBackgroundColor;
function DeleteRow(row, rowId,spname,imageButton)            
{
    currentRow = row; //allow to access the row in bigger scope
    currentRow.originalcolor=currentRow.style.backgroundColor; //hold on to the original background color
    
    imageButton.blur(); //remove the focus (and border) from the imageButton 

    if (Sys.Browser.agent == Sys.Browser.InternetExplorer) //Sys.Browser is currently not documented but very handy
        currentRow.style.backgroundColor = "#FFFF90"; 
    else
        AjaxControlToolkit.Animation.ColorAnimation.play(currentRow, .2, 20, "style", "backgroundColor", "#FFFFFF", "#FFFF90");
    
    //ask for confirmation
    var ok = confirm('Are you sure you want to delete  ' + rowId + ' ?');    
    if (ok)                        
    {   
        //change the trashcan icon into an animated  ajax loading icon     
        imageButton.src = "../ajax-loader.gif";//'<%=ResolveClientUrl("images/ajax-loader.gif") %>';
        //call the webservice execute the delete action
        GridViewRowDeleteWebService.DeleteRow(rowId,spname,OnSuccess);
    }
    else
    {
        //user changed doesn't want to delete - let's reset all styling
        var animations = new Array();
        //the goal is here to set the original color back
        //unfortunatly accepts the AnimationExtender only HEX values for colors
        //I couldn't find a way to retrieve the HEX value of the original color
        Array.add(animations, new AjaxControlToolkit.Animation.ColorAnimation(currentRow, .2, 20, "style", "backgroundColor", "#FFFF90", "#FFFFFF"));
        Array.add(animations, new AjaxControlToolkit.Animation.ScriptAction(currentRow, 0, 0, "currentRow.style.backgroundColor=currentRow.originalcolor;"));                     
        AjaxControlToolkit.Animation.SequenceAnimation.play(currentRow, 0, 0, animations, 1);
    }            
    
    return false;
}

function OnSuccess(result)
{
    //this event is triggerd when the webservice call finished succesfully
    //since all animations are play asyncrounsly we use the SequenceAnimation    
    var animations = new Array();
    Array.add(animations, new AjaxControlToolkit.Animation.ColorAnimation(currentRow, .5, 20, "style", "backgroundColor", "#FFFF90", "#FFFFFF"));
    Array.add(animations, new AjaxControlToolkit.Animation.ColorAnimation(currentRow, .5, 20, "style", "color", "#000000", "#FFFFFF"));        
    Array.add(animations, new AjaxControlToolkit.Animation.HideAction(currentRow, 0, 0));
    AjaxControlToolkit.Animation.SequenceAnimation.play(currentRow, 0, 0, animations, 1);
}       

