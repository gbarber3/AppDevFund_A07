<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise07.aspx.cs" Inherits="BigFootWebApp.ExercisePages.Exercise07" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Multiple Record Lookup - ODS</h1>
    <div class="jumbotron">        
        <p class="lead"><b>About:</b> Multiple record query using ODS.
        </p>
    </div>

    <asp:Label ID="label2" runat="server" Text="Enter player age:">
                    </asp:Label>
                    <asp:TextBox ID="PlayerAge" runat="server" MaxLength="2"></asp:TextBox>

                    &nbsp;
    <asp:RadioButtonList ID="GenderSelect" runat="server">
        <asp:ListItem Value="F">Female</asp:ListItem>
        <asp:ListItem Value="M">Male</asp:ListItem>
    </asp:RadioButtonList>
&nbsp;

                    <asp:Button ID="SearchAge" runat="server" Text="Search"/>

    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldGender" runat="server" ControlToValidate="GenderSelect" ErrorMessage="Gender is Required"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldAge" runat="server" ControlToValidate="PlayerAge" ErrorMessage="Age is Required"></asp:RequiredFieldValidator>
    <br />
    <asp:RangeValidator ID="RangeValidatorAge" runat="server" Type="Integer" ControlToValidate="PlayerAge" ErrorMessage="The league only has players between age 5 and 15" MaximumValue="15" MinimumValue="5"></asp:RangeValidator>
    <br />
    <asp:ObjectDataSource ID="PlayerDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Player_GetByAgeGender" TypeName="FSISSystem.GBarb.BLL.PlayerController">
        <SelectParameters>
            <asp:ControlParameter ControlID="PlayerAge" DefaultValue="0" Name="age" PropertyName="Text" Type="Int32" />
            <asp:ControlParameter ControlID="GenderSelect" DefaultValue="&quot;M&quot;" Name="gender" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="TeamODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Team_List" TypeName="FSISSystem.GBarb.BLL.TeamController"></asp:ObjectDataSource>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="PlayerDataSource" AllowPaging="True" PageSize="5">
        <Columns>
            <asp:BoundField DataField="PlayerID" HeaderText="ID" SortExpression="PlayerID" />
            <asp:BoundField DataField="FullName" HeaderText="Name" ReadOnly="True" SortExpression="FullName" />
            <asp:BoundField DataField="TeamID" HeaderText="TeamID" SortExpression="TeamID" />
            <asp:TemplateField HeaderText="Team" SortExpression="TeamID">
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="TeamODS" DataTextField="TeamName" DataValueField="TeamID" SelectedValue=<%# Eval("TeamID")%> >
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
