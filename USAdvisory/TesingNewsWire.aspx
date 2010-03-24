<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeFile="TesingNewsWire.aspx.cs" Inherits="TesingNewsWire" %>


<%-- Add content controls here --%>
<head>

<script src="js/newsticker.js" type="text/javascript"></script>
<script src="facefiles/jquery-1.2.2.pack.js" type="text/javascript"></script>
<script src="facefiles/facebox.js" type="text/javascript"></script>

<script type="text/javascript">
    $(document).ready(function() {
        var options = {
            newsList: "#news",
            startDelay: 10,
            placeHolder1: " []"
        }
        $().newsTicker(options);
    });

</script>


</head>


<ul id="news">
    <li><a href="http://www.makemineatriple.com">MakeMineATriple.com</a></li>
    <li><a href="http://www.jquery.com">jQuery</a></li>
    <li>Or alternatively an item with just text</li>
</ul>