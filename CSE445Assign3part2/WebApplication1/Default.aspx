<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>TryIt page</h2>
            </hgroup>
            <p>
               <a href="WeatherTryIt.aspx"> Weather Service</a>
                 &nbsp;&nbsp; : In whcih you input 5 digit zipcode, you can get a string of 5 days weather of this location. The service Url: <a href="http://localhost:4625/Service1.svc">http://localhost:4625/Service1.svc</a>&nbsp;&nbsp;&nbsp;&nbsp; Input: zipcode(string) output: weather (string[]) Method Name: WeatherService</p>
            <p>
               <a href="WsOperationTryIt.aspx"> WsOperation</a>
                &nbsp; : In which you input a wsdl string, you can get the name input and output types. The ServiceUrl: <a href="http://localhost:4625/Service1.svc">http://localhost:4625/Service1.svc</a> Input: wsdl url(string)&nbsp; Output: name input/output(string)</p>
            <p>
                &nbsp;</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    </asp:Content>
