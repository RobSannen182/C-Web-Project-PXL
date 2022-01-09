using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHogeschoolPXL.TagHelpers
{
    [HtmlTargetElement("user-info")]
    public class UserInfoTagHelper : TagHelper
    {
        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;

        public UserInfoTagHelper(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var claimsPrincipal = ViewContext.HttpContext.User;
            var user = await _userManager.GetUserAsync(claimsPrincipal);
            string content = $@"<span class='nav-link text-dark'>";
            content += $@"{user.Email}";
            content += $@"</span>";
            output.TagName = "span";
            output.Content.SetHtmlContent(content);



            
        }
    }
}
