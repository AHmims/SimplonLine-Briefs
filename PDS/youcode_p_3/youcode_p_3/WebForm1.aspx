<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="youcode_p_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/bootstrap.min.css" rel="stylesheet"/>
    <title></title>
</head>
<body class="">
    <form id="form1" runat="server" class="p-4">
        <div class="row">
            <div class="col">
                <div class="form-group row">
                    <asp:Label ID="Label1" runat="server" Text="Nom: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:TextBox ID="tbNom" runat="server" CssClass="form-control col-sm-10"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label2" runat="server" Text="Prénom: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:TextBox ID="tbPrenom" runat="server" CssClass="form-control col-sm-10"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label3" runat="server" Text="Date de naissance: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <input type="date" id="dtpDN"/>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label4" runat="server" Text="Téléphone: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:TextBox ID="tbTel" runat="server" CssClass="form-control col-sm-10"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label9" runat="server" Text="Adresse: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:TextBox ID="tbAdrs" runat="server" CssClass="form-control col-sm-10"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="form-group row">
                    <asp:Label ID="Label5" runat="server" Text="Adresse mail: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:TextBox ID="tbMail" runat="server" CssClass="form-control col-sm-10"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label6" runat="server" Text="Pays: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:DropDownList ID="cbPays" runat="server" CssClass="form-control col-sm-10" OnSelectedIndexChanged="cbPays_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label7" runat="server" Text="Ville: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:DropDownList ID="cbVille" runat="server" CssClass="form-control col-sm-10"></asp:DropDownList>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label8" runat="server" Text="Spécialites: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <asp:DropDownList ID="cbSp" runat="server" CssClass="form-control col-sm-10"></asp:DropDownList>
                </div>
            </div>
        </div>
        <asp:Button ID="btnConfirm" runat="server" Text="Ajouter" CssClass="btn btn-primary mb-2" OnClick="btnConfirm_Click"/>
        <asp:Button ID="btnCancel" runat="server" Text="Anuller" CssClass="btn btn-secondary mb-2" OnClick="btnCancel_Click"/>
        <hr/>
        <div class="d-flex align-items-center">
            <asp:Label ID="Label10" runat="server" Text="Identifiant :"></asp:Label>
            <asp:DropDownList ID="cbIds" runat="server" CssClass="form-control d-inline w-25 ml-1" OnSelectedIndexChanged="cbIds_SelectedIndexChanged"></asp:DropDownList>
            <asp:Button ID="editBtn" runat="server" Text="Modifier" CssClass="btn btn-secondary ml-1" OnClick="editBtn_Click"/>
            <asp:Button ID="dltBtn" runat="server" Text="Supprimer" CssClass="btn btn-danger ml-1" OnClick="dltBtn_Click"/>
        </div>
        <hr/>
        <asp:GridView ID="dataGridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="identifiant" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:TemplateField HeaderText="identifiant" InsertVisible="False" SortExpression="identifiant">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("identifiant") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("identifiant") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="nom" SortExpression="nom">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("nom") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("nom") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="prenom" SortExpression="prenom">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("prenom") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("prenom") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="dateNaissance" SortExpression="dateNaissance">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("dateNaissance") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("dateNaissance") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="numTel" SortExpression="numTel">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("numTel") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("numTel") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="adresseMail" SortExpression="adresseMail">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("adresseMail") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("adresseMail") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="adresse" SortExpression="adresse">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("adresse") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("adresse") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="pays" SortExpression="pays">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("pays") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("pays") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ville" SortExpression="ville">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("ville") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("ville") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="specialites" SortExpression="specialites">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("specialites") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("specialites") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:youcode_p_2ConnectionString %>" SelectCommand="SELECT * FROM [apprenant]"></asp:SqlDataSource>
    </form>
</body>
</html>
