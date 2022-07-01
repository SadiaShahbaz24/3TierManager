<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="_3tierTASK.Teachers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="teachers" runat="server">
        <table>
            <tr>
                 <td>
                    <asp:Label ID ="LabId" runat="server" Text="Enter ID:" ></asp:Label>
                </td>
                  <td>
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
                  <td>
                      <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

                </td>
                </tr>
           <tr>
                <td>
                    <asp:Label ID ="LabFirstName" runat="server" Text="Enter First Name:" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                </td>
              
            </tr>
             <tr>
                <td>
                    <asp:Label ID ="LabLastName" runat="server" Text="Enter Last Name:" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                </td>
             
            </tr>
           <tr>
              <td>
                    <asp:Label ID ="Labedu" runat="server" Text="Select Qualification:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddEdu" runat="server" >
                     <%--   <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">--%>
                        <asp:ListItem>Bachelor</asp:ListItem>
                        <asp:ListItem>Master</asp:ListItem>
                        <asp:ListItem>M.Phil</asp:ListItem>
                        <asp:ListItem>PHD</asp:ListItem>
                    </asp:DropDownList>
                </td>
           </tr>
              <tr>
              <td>
                    <asp:Label ID ="Labcourse" runat="server" Text="Select Course:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddCourse" runat="server" >
           <%--             <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">  --%> 
                        <asp:ListItem>Programming Fundamental</asp:ListItem>
                        <asp:ListItem>OOP</asp:ListItem>
                        <asp:ListItem>AOOP</asp:ListItem>
                         <asp:ListItem>Data Structure</asp:ListItem>
                         <asp:ListItem>DBMS</asp:ListItem>
                        <asp:ListItem>Visual    Programming</asp:ListItem>
                    </asp:DropDownList>
                </td>
           </tr>     
               <tr>
                 <td>
                    <asp:Label ID ="Labemail" runat="server" Text="Enter Email:" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr>
               <td></td>
           </tr>

           
            <tr>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" style="height: 26px" />
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                </td>

            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="result" runat="server" Text="test connection"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridViewTeacher" runat="server"></asp:GridView>
                </td>
            </tr>

       </table>
    </form>
</body>
</html>
