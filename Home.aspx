<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true"
    CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>
                <div id="templatemo_content_panel_1">
                    <div id="templatemo_news_section">
                        <h1>
                            Site's News</h1>
                        <h3>
                            Real Estate Investment</h3>
                        <div class="templatemo_news_box">
                            <p>
                                Real estate investing involves the purchase, ownership, management, rental and/or
                                sale of real estate for profit. Real Estate has traditionally outperformed Wall
                                Street equity market. A street by street knowledge of the market make it perfect
                                for small savvy investors.</p>
                        </div>
                    </div>
                    <!-- end of news section -->
                    <div id="templatemo_section_1_1">
                        <div id="SliderName_2" class="SliderName_2">
                            <img src="img/s1.jpg" width="400" height="150" alt="Demo2 first" title="Demo2 first"
                                usemap="#img1map" />
                            <div class="SliderName_2Description">
                                Featured model: <strong>Charlize Theron</strong></div>
                            <img src="img/s2.jpg" width="400" height="150" alt="Demo2 second" title="Demo2 second" />
                            <div class="SliderName_2Description">
                                Featured model: <strong>Charlize Theron</strong></div>
                            <img src="img/s3.jpg" width="400" height="150" alt="Demo2 third" title="Demo2 third" />
                            <div class="SliderName_2Description">
                                Featured model: <strong>Charlize Theron</strong></div>
                            <img src="img/sample.jpg" width="400" height="150" alt="Demo2 fourth" title="Demo2 fourth" />
                            <div class="SliderName_2Description">
                                Featured model: <strong>Charlize Theron</strong></div>
                        </div>
                        <div class="c">
                        </div>
                        <div id="SliderNameNavigation_2">
                        </div>
                        <div class="c">
                        </div>
                        <script type="text/javascript">
                            effectsDemo2 = 'rain,stairs,fade';
                            var demoSlider_2 = Sliderman.slider({ container: 'SliderName_2', width: 400, height: 150, effects: effectsDemo2,
                                display: {
                                    autoplay: 3000,
                                    loading: { background: '#000000', opacity: 0.5, image: 'img/loading.gif' },
                                    buttons: { hide: true, opacity: 1, prev: { className: 'SliderNamePrev_2', label: '' }, next: { className: 'SliderNameNext_2', label: ''} },
                                    description: { hide: true, background: '#000000', opacity: 0.4, height: 50, position: 'bottom' },
                                    navigation: { container: 'SliderNameNavigation_2', label: '<img src="img/clear.gif" />' }
                                }
                            });
                        </script>
                        <div class="c">
                        </div>
                    </div>
                    <div class="c">
                    </div>
                </div>
                <div class="c">
                </div>
                </div> </div>
                <!-- end of section 1 -->
                <div class="cleaner_with_height">
                </div>
                </div>
            </td>
        </tr>
    </table>
    <table width="100%" align="right">
        <tr align="center">
            <td align="center">
                <div id="templatemo_content_panel_2">
                    <div class="templatemo_section_2">
                        <img src="images/templatemo_image_01.jpg" alt="image" align="left" />
                        
                        <h4>
                            Garmez Villa</h4>
                        <p>
                            Built Up Area : 1100 Sq. Feet | Plot Area : 1050 Sq. Feet Bedrooms 3</p>
                        <p>
                            Powai, Mumbai</p>
                    </div>
                    <div class="templatemo_section_2">
                        <img src="images/templatemo_image_02.jpg" alt="image" />
                       
                        <h4>
                            Creek Villa</h4>
                        <p>
                            Built Up Area : 1000 Sq. Feet | Plot Area : 1000 Sq. Feet Bedrooms : 2
                        </p>
                        <p>
                            Andheri East, Mumbai</p>
                    </div>
                    <div class="templatemo_section_2">
                        <img src="images/templatemo_image_03.jpg" alt="image" />
                        
                        <h4>
                            Lake Villa</h4>
                        <p>
                            Built Up Area : 1200 Sq. Feet | Plot Area : 1220 Sq. Feet Bedrooms : 3
                        </p>
                        <p>
                            Ghatkopar West, Mumbai</p>
                    </div>
                    <div class="cleaner_with_height">
                        &nbsp;&nbsp;&nbsp;
                    </div>
                </div>
            </td>
        </tr>
    </table>
    <!-- end of content panel 2 -->
</asp:Content>
