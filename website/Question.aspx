<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="Question" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ol class="breadcrumb">
        <li class="breadcrumb-item">
            <a href="Dashboard">Dashboard</a>
        </li>
        <li class="breadcrumb-item active">Sub Topic Questions</li>
    </ol>
    <div id="formView" runat="server">
        <div class="box_general">
            <div class="header_box">
                <h2 class="d-inline-block">New Record</h2>
                <div class="filter">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="ViewRecord" CssClass="btn btn-success "><i class="fa fa-vimeo"></i>&nbsp View Record</asp:LinkButton>


                </div>
            </div>
            <hr />
            <div class="list_general">
                <div class="box box-primary">
                    <div class="box-body box-profile">

                        <br />
                        <br />
                        <asp:Panel ID="PnlSubQuestion" runat="server">
                            <asp:HiddenField ID="rec_id" runat="server" />
                            <asp:HiddenField ID="question" runat="server" />
                            <asp:HiddenField ID="profile_pic1" runat="server" />
                            <asp:HiddenField ID="profile_pic2" runat="server" />
                            <asp:HiddenField ID="profile_pic3" runat="server" />
                            <asp:HiddenField ID="profile_pic4" runat="server" />



                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">Sub Topic Name</label>
                                </div>
                                <div class="col-md-9">

                                    <asp:DropDownList ID="sub_topicID" CssClass="form-control custom-select-sm" runat="server"></asp:DropDownList>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">Question</label>
                                </div>
                                <div class="col-md-9">
                                    <textarea id="ckEditor" runat="server" class="ckeditor"></textarea>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">option One</label>
                                </div>
                                <div class="col-md-9">

                                    <asp:TextBox ID="option1" CssClass="form-control " runat="server"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">option Two</label>
                                </div>
                                <div class="col-md-9">

                                    <asp:TextBox ID="option2" CssClass="form-control " runat="server"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">option Three</label>
                                </div>
                                <div class="col-md-9">

                                    <asp:TextBox ID="option3" CssClass="form-control " runat="server"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">option Four</label>
                                </div>
                                <div class="col-md-9">

                                    <asp:TextBox ID="option4" CssClass="form-control " runat="server"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    <label style="font-size: 12px">Answer</label>
                                </div>
                                <div class="col-md-9">

                                    <asp:TextBox ID="answer" placeholder="Answer must be same as either any of the options" CssClass="form-control " runat="server"></asp:TextBox>

                                </div>
                            </div>


                            <br />
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:LinkButton ID="lnkSaveChanges" OnClick="SaveChangesClicked" CssClass="btn btn-sm btn-primary pull-right  " runat="server"><i class="fa fa-save "></i>&nbsp Save Changes</asp:LinkButton>
                                </div>
                            </div>
                            <br />

                        </asp:Panel>



                    </div>
                </div>
            </div>
        </div>

    </div>
    <div id="TableView" runat="server">
        <div class="box_general">
            <div class="header_box">
                <h2 class="d-inline-block">View Information</h2>
                <div class="filter">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="AddNewRecordClicked" CssClass="btn btn-success "><i class="fa fa-plus"></i>&nbsp Add New Record</asp:LinkButton>


                </div>

            </div>
            <hr />
            <div class="list_general">
                <div class="box box-primary">
                    <div class="box-body box-profile">

                        <br />
                        <br />

                        <div class="table-responsive">
                            <asp:GridView ID="TableResult" runat="server" Font-Size="10px"
                                CssClass="table table-bordered table-striped catr" AutoGenerateColumns="true" AllowCustomPaging="true"
                                OnSelectedIndexChanged="tableChanged" OnRowDeleting="TableDelete"
                                EmptyDataText="There is no record for the selected item">
                                <Columns>
                                    <asp:TemplateField HeaderStyle-Width="7%" HeaderText="Delete Record" Visible="true" HeaderStyle-CssClass=" thead-default" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbDelete" runat="server" Font-Size="14px" CssClass="btn btn-sm btn-danger"
                                                CausesValidation="False" CommandName="Delete" CommandArgument='<%# Container.DataItemIndex %>'>
                                                    <i class="fa fa-trash"></i>
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderStyle-Width="5%" HeaderText="Edit Record" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbSelect" Font-Size="14px" runat="server" CssClass="btn btn-sm btn-info"
                                                CausesValidation="False" CommandName="Select" CommandArgument='<%# Container.DataItemIndex %>'>
                                                    <i class="fa fa-edit " ></i>
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                </Columns>
                            </asp:GridView>
                            <div class="Pager"></div>
                            <asp:DataList CellPadding="5" RepeatDirection="Horizontal" runat="server" ID="dlPager"
                                OnItemCommand="dlPager_ItemCommand">
                                <ItemTemplate>

                                    <nav class="pagination">
                                        <ul class="pagination">
                                            <li class="page-item ">
                                                <asp:LinkButton Enabled='<%#Eval("Enabled") %>' CssClass="page-link " runat="server" ID="lnkPageNo" Text='<%#Eval("Text") %>' CommandArgument='<%#Eval("Value") %>' CommandName="PageNo"></asp:LinkButton>

                                            </li>
                                        </ul>
                                    </nav>

                                </ItemTemplate>
                            </asp:DataList>

                        </div>


                    </div>
                </div>
            </div>
        </div>

    </div>
    <script src="js/jquery-2.2.4.min.js"></script>
    <script src="ckeditor/ckeditor.js"></script>
    <script>
        function showDelete() {
            $('#DeleteRecord').modal('show')
        }
    </script>
    <div class="modal fade" id="DeleteRecord" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabels"
        aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabels">Delete Record</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <asp:Label ID="Label1" CssClass="text-danger " runat="server" Text="Label"></asp:Label>
                </div>
                <div class="modal-footer bg-whitesmoke br">

                    <asp:LinkButton ID="lnkDelete" CssClass="btn btn-sm btn-danger" OnClick="lbDeleteYes_Click" runat="server"><i class="fa fa-trash"></i>&nbsp Delete</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
