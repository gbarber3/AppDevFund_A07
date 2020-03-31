<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise06.aspx.cs" Inherits="BigFootWebApp.ExercisePages.Exercise06" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Multiple Record Lookup - Code Behind</h1>
    <div class="jumbotron">        
        <p class="lead"><b>About:</b> This page will demonstrate a multiple record query display to a GridView using code behind without using ObjectDataSource controls. 
            The page will demonstrate customization of the GridView covering templates, column selection, column headers, caption (with bootstrap formating), dataset member referencing (Eval("")) and paging.
            The page wil demonstrate the implementation of the paging event PageIndexChanging().
        </p>
    </div>

        <div class="offset-2" style="margin-left: 40px">
        <asp:Label ID="Label1" runat="server" Text="Teams: "></asp:Label>&nbsp;&nbsp;   
        <asp:DropDownList ID="TeamList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Search" runat="server" Text="Search" 
             CausesValidation="false" OnClick="Search_Click"/>
        <br /><br />
        <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        <br />

        <div class="col-md-6">
            <asp:Label runat="server" Text="Coach:" CssClass="text-right"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label id="CoachName" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Assistant Coach:" CssClass="text-right"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label id="AssistCoach" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Wins:" CssClass="text-right"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label id="WinLabel" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Losses:" CssClass="text-right"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label id="LossLabel" runat="server" ></asp:Label>
        </div>


        <h3>&nbsp;</h3>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <h3>Team Roster</h3>
        <asp:GridView ID="TeamRoster" runat="server" AutoGenerateColumns="False" BorderStyle="None" CssClass="table table-striped" AllowPaging="True" PageSize="5" OnPageIndexChanging="TeamRoster_SelectedIndexChanging"  >
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="FullName" runat="server"
                            Text='<%# Eval("FullName") %>'></asp:Label>                        
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Age">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>                       
                        <asp:Label ID="ProductName" runat="server" 
                            Text='<%# Eval("Age") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Gender">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>                       
                        <asp:Label ID="Gender" runat="server" 
                            Text='<%# Eval("GenderFormatted") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                    
                <asp:TemplateField HeaderText="Med Alert">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>                       
                        <asp:Label ID="MedicalAlertDetails" runat="server" 
                            Text='<%# Eval("MedicalAlertDetails") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
            <PagerSettings FirstPageText="Start" LastPageText="End" Mode="NumericFirstLast" PageButtonCount="3" />
            
        </asp:GridView>
 </div>


</asp:Content>
