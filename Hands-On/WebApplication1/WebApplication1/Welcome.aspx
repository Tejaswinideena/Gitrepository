<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WebApplication1.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="PersonalDetails" runat="server"></asp:View>
                <asp:View ID="EducationalDetails" runat="server"></asp:View>
                <asp:View ID="BankDetials" runat="server"></asp:View>
            </asp:MultiView>

        </div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </form>
</body>
</html>
