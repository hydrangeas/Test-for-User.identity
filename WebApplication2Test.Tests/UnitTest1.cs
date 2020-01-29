using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;
using System.Security.Principal;
using WebApplication2.Pages;

namespace WebApplication2Test.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ユーザー名を取得できる()
        {
            var httpContext = new DefaultHttpContext()
            {
                User = new ClaimsPrincipal(new GenericIdentity("Akira"))
            };

            var actionContext = new ActionContext(
                httpContext,
                new RouteData(),
                new PageActionDescriptor(),
                new ModelStateDictionary());

            var indexModel = new IndexModel() { PageContext = new PageContext(actionContext) };
            indexModel.OnGet();

            indexModel.UserName.Is("Akira");
        }
    }
}
