<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="_3tierTASK.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="student" runat="server">
       <table>
            <tr>
                 <td>
                    <asp:Label ID ="LabRoll" runat="server" Text="Enter RollNo:" ></asp:Label>
                </td>
                  <td>
                    <asp:TextBox ID="txtroll" runat="server"></asp:TextBox>
                </td>
                <td></td>
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
                    <asp:Label ID ="Labdegree" runat="server" Text="Select Degree:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddDegree" runat="server" >
                        <asp:ListItem>BSCS</asp:ListItem>
                        <asp:ListItem>BSAI</asp:ListItem>
                        <asp:ListItem>BSIT</asp:ListItem>
                        <asp:ListItem>BSSE</asp:ListItem>
                    </asp:DropDownList>
                </td>
           </tr>
           <tr>
                 <td>
                    <asp:Label ID ="Labsem" runat="server" Text="Enter Semester:" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtsem" runat="server"></asp:TextBox>
                </td>
           </tr>
                <tr>
              <td>
                    <asp:Label ID ="Labshift" runat="server" Text="Select Shift:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddShift" runat="server" >
                        <asp:ListItem>Morning</asp:ListItem>
                        <asp:ListItem>Evening</asp:ListItem>
                    </asp:DropDownList>
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
                    <asp:GridView ID="GridViewStudent" runat="server"></asp:GridView>
                </td>
            </tr>

       </table>
    </form>
</body>
</html>
