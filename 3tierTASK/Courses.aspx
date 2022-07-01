<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="_3tierTASK.Courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="course" runat="server">
        <table>
            <tr>
                 <td>
                    <asp:Label ID ="LabId" runat="server" Text="Enter Course ID:" ></asp:Label>
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
                    <asp:Label ID ="Labcourse" runat="server" Text="Select Course Name:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddCourse" runat="server" >
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
                    <asp:Label ID ="Labcredit" runat="server" Text="Select Credit Hour:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddCredit" runat="server" >
                        <asp:ListItem>2+0</asp:ListItem>
                        <asp:ListItem>3+0</asp:ListItem>
                        <asp:ListItem>3+1</asp:ListItem>
                       
                    </asp:DropDownList>
                </td>
           </tr>
                  <tr>
               <td>
                    <asp:Label ID ="Labtype" runat="server" Text="Select Type:" ></asp:Label>
               </td>
               <td>
                    <asp:DropDownList ID="ddType" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Compulsory</asp:ListItem>
                        <asp:ListItem>Elective</asp:ListItem>
                    </asp:DropDownList>
                </td>
             
            </tr>
           
               <tr>
                 <td>
                    <asp:Label ID ="LabdeptId" runat="server" Text="Enter Department ID:" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtdeptId" runat="server"></asp:TextBox>
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
                    <asp:GridView ID="GridViewCourse" runat="server"></asp:GridView>
                </td>
            </tr>

       </table>
    </form>
</body>
</html>
