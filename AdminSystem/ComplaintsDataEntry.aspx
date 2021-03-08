<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ComplaintsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblComplaintsID" runat="server" Text="Complaints ID" width="212px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtComplaintsID" runat="server" width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="212px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server" width="168px"></asp:TextBox>
            <br />
            <br />
           
            <asp:Label ID="lblCustomerFullName" runat="server" Text="Customer Full Name" width="212px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerFullName" runat="server" width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblComplaintDate" runat="server" Text="Complaint Date" width="212px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtComplaintDate" runat="server" width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblComplaintDescription" runat="server" Text="Complaint Description" width="212px"></asp:Label>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtComplaintDescription" runat="server" width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkIssueSolved" runat="server" Text="IssueSolved" width="212px" />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
