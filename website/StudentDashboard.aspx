<%@ Page Title="" Language="C#" MasterPageFile="~/CourseWareMaster.master" AutoEventWireup="true" CodeFile="StudentDashboard.aspx.cs" Inherits="StudentDashboard" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
 
                        <asp:ListView ID="lstQuestion" runat="server">
                    <ItemTemplate>
        <div class="box_teacher">
            <div class="indent_title_in">
                <i class="pe-7s-anchor"></i>
              <h4><%# Eval("Title") %></h4>
                <hr />
                  <p class="font-weight-bold" style=" font-size:large;  font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif"><%# Eval("Description") %></p>
            </div>
            <div class="wrapper_indent">

                        
                        <hr />
                     
                        <div class="row">
                            <div class="container margin_60_35">
                                <div class="grid">
                                    <ul class="magnific-gallery">
                                        <li>
                                            <figure>
                                                <img src="<%# Eval("ProfilePic1") %>" alt="English">
                                                <figcaption>
                                                    <div class="caption-content">
                                                        <a href="#" title="English" data-effect="mfp-zoom-in">
                                                            <i class="pe-7s-albums"></i>
                                                            <p><%# Eval("ProfilePic1") %></p>
                                                        </a>
                                                    </div>
                                                </figcaption>
                                            </figure>
                                        </li>
                                        <li>
                                            <figure>
                                                <img src="<%# Eval("ProfilePic2") %>" alt="English">
                                                <figcaption>
                                                    <div class="caption-content">
                                                        <a href="#" title="English" data-effect="mfp-zoom-in">
                                                            <i class="pe-7s-albums"></i>
                                                            <p><%# Eval("ProfilePic2") %></p>
                                                        </a>
                                                    </div>
                                                </figcaption>
                                            </figure>
                                        </li>
                                        <li>
                                            <figure>
                                                <img src="<%# Eval("ProfilePic3") %>" alt="English">
                                                <figcaption>
                                                    <div class="caption-content">
                                                        <a href="#" title="English" data-effect="mfp-zoom-in">
                                                            <i class="pe-7s-albums"></i>
                                                            <p><%# Eval("ProfilePic3") %></p>
                                                        </a>
                                                    </div>
                                                </figcaption>
                                            </figure>
                                        </li>
                                        <li>
                                            <figure>
                                                <img src="<%# Eval("ProfilePic4") %>" alt="English">
                                                <figcaption>
                                                    <div class="caption-content">
                                                        <a href="#" title="English" data-effect="mfp-zoom-in">
                                                            <i class="pe-7s-albums"></i>
                                                            <p><%# Eval("ProfilePic4") %></p>
                                                        </a>
                                                    </div>
                                                </figcaption>
                                            </figure>
                                        </li>

                                    </ul>
                                </div>

                                <hr />
                                <h3><%# Eval("Question") %></h3>
                          
                              
                                    		<div class="card">
									
									
										<div class="card-body">
											
									<div class="row">
                                      
                                           
													<div class="col-md-3"> <asp:RadioButton ID="RadioButton1" CssClass="form-control custom-checkbox" Text='<%# Eval("Option1") %>' GroupName="schola" runat="server" AutoPostBack="true" OnCheckedChanged="RadioCheckChanged" /></div>
													
													<div class="col-md-3"><asp:RadioButton ID="RadioButton2" CssClass="form-control custom-checkbox" Text='<%# Eval("Option2") %>' GroupName="schola" runat="server" AutoPostBack="true" OnCheckedChanged="RadioCheckChanged" /></div>
													
													<div class="col-md-3"> <asp:RadioButton ID="RadioButton3" CssClass="form-control custom-checkbox" Text='<%# Eval("Option3") %>' GroupName="schola" runat="server" AutoPostBack="true" OnCheckedChanged="RadioCheckChanged" /></div>
													
													<div class="col-md-3"><asp:RadioButton ID="RadioButton4" CssClass="form-control custom-checkbox" Text='<%# Eval("Option4") %>' GroupName="schola" runat="server" AutoPostBack="true" OnCheckedChanged="RadioCheckChanged" /></div>
													
													<div class="col-md-3"><asp:HiddenField ID="lblAnswer" Value ='<%# Eval("Answer") %>' runat="server" /></div>
												
                                         
                                            
											<div class="col-md-3"><asp:HiddenField ID="HDQuestions" Value ='<%# Eval("QuestionID") %>' runat="server" /></div>
												
                                    

									</div>
											</div>
										
									
								
								</div>
                                       

                             
                                <!-- /grid gallery -->
                            </div>
                        </div>
                  
             
                <!-- End row-->
            </div>
            <!--wrapper_indent -->

            <!--wrapper_indent -->
        </div>
      </ItemTemplate>
                </asp:ListView>
           <table id="Paging" runat="server">
                    <tr>

                        <td>
                            <asp:Button ID="Button2" Visible ="false"  runat="server" Font-Bold="true" Text="Previous"  /></td>
                        <td>
                            <asp:Button ID="Button3" Visible ="false"  runat="server" Font-Bold="true" Text="Next"  /></td>
                    </tr>
                </table>

    <!-- /col -->
</asp:Content>

