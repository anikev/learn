<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  
    <div class="container">
        <h2>Список пользователей</h2>
        <form class="form-horizontal">
            <div class="form-group" >
                <label class="control-label col-sm-2" for="fName">Фамилия</label>
                <input type="text" class="form-control" id="fName" placeholder="Фамилия">
            </div>           
        </form>
        
        <table class="table table-striped">
            <thead>
            <tr>
                <th style="height: 38px">Firstname</th>
                <th style="height: 38px">Lastname</th>
                <th style="height: 38px">Email</th>
            </tr>
            </thead>
            <tbody>
            <tr>
                <td>John</td>
                <td>Doe</td>
                <td>john@example.com</td>
            </tr>
            <tr>
                <td>Mary</td>
                <td>Moe</td>
                <td>mary@example.com</td>
            </tr>
            <tr>
                <td>July</td>
                <td>Dooley</td>
                <td>july@example.com</td>
            </tr>
            </tbody>
        </table>
    </div>

</asp:Content>
