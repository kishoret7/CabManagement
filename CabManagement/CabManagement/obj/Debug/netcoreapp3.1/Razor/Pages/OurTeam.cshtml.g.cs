#pragma checksum "C:\Users\kisho\source\repos\CabManagement\CabManagement\Pages\OurTeam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7544a555e1849fced8b249f8bb475ef29a6731b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CabManagement.Pages.Pages_OurTeam), @"mvc.1.0.razor-page", @"/Pages/OurTeam.cshtml")]
namespace CabManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kisho\source\repos\CabManagement\CabManagement\Pages\_ViewImports.cshtml"
using CabManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7544a555e1849fced8b249f8bb475ef29a6731b", @"/Pages/OurTeam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34661a92a7beb7d6ab85cedd65c8110993fcf39b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OurTeam : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7544a555e1849fced8b249f8bb475ef29a6731b2943", async() => {
                WriteLiteral(@"
    <!-- Meet Our Team -->
    <section id=""team"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-6"">
                    <h2>Meet Our Team</h2>
                    <p> Voyager Cabs have been offering services since 2015. Founded by our very talented Kishore Kumar, Voyager has grown exponentially in the last couple of years. It is led by Pranav Naphad, an accomplished COO, with over 6 years experience in Management. Our young CTO Laasya Akunuru has changed the game with her new ideas in technology. </p>
                </div>
            </div>

            <Center>
");
                WriteLiteral("\r\n");
                WriteLiteral(@"                <div class=""member"">
                    <div class=""member-img"">
                        <img src=""https://scontent-ort2-2.xx.fbcdn.net/v/t1.18169-9/18881945_1477036515700423_1148121453728292519_n.jpg?_nc_cat=104&ccb=1-5&_nc_sid=8bfeb9&_nc_ohc=UxUj0k-aGDEAX9qPYOT&_nc_ht=scontent-ort2-2.xx&oh=9b3da8ad68af7b5a4530756e6187e4e7&oe=618166AC"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 1233, "\"", 1239, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"member-info\">\r\n                        <h4>PRANAV NAPHAD</h4>\r\n                        <span>COO</span>\r\n\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"                <div class=""member"">
                    <div class=""member-img"">
                        <img src=""https://scontent-ort2-2.xx.fbcdn.net/v/t1.6435-9/243762752_131491159224646_5474029400597066696_n.jpg?_nc_cat=109&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=K_u9n9VN2coAX-EPT-W&_nc_ht=scontent-ort2-2.xx&oh=cfb6d650726eb18395c773904e0acadf&oe=6184B7CA"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 1920, "\"", 1926, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"member-info\">\r\n                        <h4>KISHORE KUMAR T</h4>\r\n                        <span>CEO</span>\r\n\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("                <div class=\"member\">\r\n                    <div class=\"member-img\">\r\n                        <img src=\"https://avatars.services.sap.com/images/laasya.akunuru.png\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 2433, "\"", 2439, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""member-info"">
                        <h4>LAASYA AKUNURU</h4>
                        <span>CTO</span>

                    </div>
                </div>
               

            </Center>

           


        </div>


        


    </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<style>
    #team {
        padding: 60px 0;
        text-align: center;
        background-color: black;
        color: #fff;
    }

        #team h2 {
            position: relative;
            padding: 0px 0px 15px;
        }

        #team p {
            font-size: 15px;
            font-style: italic;
            padding: 0px;
            margin: 25px 0px 40px;
        }

        #team h2::after {
            content: '';
            border-bottom: 2px solid #fff;
            position: absolute;
            bottom: 0px;
            right: 0px;
            left: 0px;
            width: 90px;
            margin: 0 auto;
            display: block;
        }

        #team .member {
            margin-bottom: 20px;
            width: 250px;
            height: 250px;
            position: relative;
            overflow: hidden;
            background-color: #fff;
            padding: 10px;
            border-radius: 15px 0px 15px 0px;
            box-s");
            WriteLiteral(@"hadow: 0px 1px 6px 0px rgba(0, 0, 0, 0.4);
        }

            #team .member .member-info {
                display: block;
                position: absolute;
                bottom: 0px;
                left: -200px;
                transition: 0.4s;
                padding: 15px 0;
                background: rgba(0, 0, 0, 0.4);
            }

            #team .member:hover .member-info {
                left: 0px;
                right: 0px;
            }

            #team .member h4 {
                font-weight: 700;
                margin-bottom: 2px;
                font-size: 18px;
                color: #fff;
            }

            #team .member span {
                font-style: italic;
                display: block;
                font-size: 13px;
            }
</style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CabManagement.Pages.OurTeamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CabManagement.Pages.OurTeamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CabManagement.Pages.OurTeamModel>)PageContext?.ViewData;
        public CabManagement.Pages.OurTeamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591