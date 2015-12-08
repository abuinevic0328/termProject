<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxExample.aspx.cs" Inherits="termProject.AjaxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="AJAXSample1.js"></script>
    <script type="text/javascript">
        var makeChng = new MakeChange();

        function UpdateName()
        {
           
            var name = document.getElementById("name_input").value;
            
            var result = makeChng.makeRequest("UpdateField.ashx?name=" + name);
            if (result == 1)
                alert("Your name was changed successfully!");
            else
                if (result==0)
                    alert ("Your name has not been changed. An error ocurred!")
            
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Name 
    <input type="text" id="name_input" />
        <input type="button" value="Change name!" onclick="UpdateName()" />
    </div>
    </form>
</body>
</html>
