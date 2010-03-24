<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeFile="DStreetUS.aspx.cs" Inherits="DStreetUS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en"> 
<head> 
<title>Facebox Demo</title> 
<script src="facefiles/jquery-1.2.2.pack.js" type="text/javascript"></script> 
<link href="facefiles/facebox.css" media="screen" rel="stylesheet" type="text/css" /> 
<script src="facefiles/facebox.js" type="text/javascript"></script> 
 
<script type="text/javascript">
    jQuery(document).ready(function($) {
        $('a[rel*=facebox]').facebox()
    })
</script> 
 
</head> 
<body> 
 
<p><a href="#mydiv" rel="facebox">View DIV with id="mydiv" on the page</a></p> 
 
<p><a href="allwatchoutnews.aspx" rel="facebox">View "External.htm" fetched via Ajax</a></p> 
 
<div id="mydiv" style="display:none"> 
This is the contents of a hidden DIV on the page, with ID="mydiv" and style set to "display:none"<br /><br /> 
<a href="http://www.dynamicdrive.com/dynamicindex4/facebox/index.htm">Facebox image and content viewer (v 1.1)</a> 
</div> 
 
</body> 
</html>