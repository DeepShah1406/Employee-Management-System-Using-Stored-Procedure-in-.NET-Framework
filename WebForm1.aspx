<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication01StoreProcedure17Sep2023.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2> Employee Data </h2><asp:GridView ID="gridvEmp" runat="server"></asp:GridView>
            <br />
            Employee ID : <asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox>
            <br />
            Employee Name : <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
            <br />
            Employee City : <asp:TextBox ID="txtEmpCity" runat="server"></asp:TextBox>
            <br />
            Employee Salary : <asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="tbnInsert" Text="Insert" runat="server" OnClick="tbnInsert_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" Text="Delete" runat="server" OnClick="btnDelete_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnSelect" Text="Select" runat="server" OnClick="btnSelect_Click" />
        </div>
    </form>
</body>
</html>
