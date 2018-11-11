using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiabeticProject.Infrastructure;
using DiabeticProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using Xunit;

namespace DiabeticMed.UnitTests.infrastructure
{
  public  class PageLinkTagHelperTests
    {

        
        public void Can_generate_PageLinks()
        {
            //arrange
            var urlhelper = new Mock<IUrlHelper>();
            urlhelper.SetupSequence(x => x.Action(It.IsAny<UrlActionContext>()))
                .Returns("Test/Page1").Returns("Test/Page2").Returns("Test/Page3");
            var urlhelperFactor=new Mock<IUrlHelperFactory>();
            urlhelperFactor.Setup(f => f.GetUrlHelper(It.IsAny<ActionContext>())).Returns(urlhelper.Object);

            PageLinkTagHelper helper = new PageLinkTagHelper(urlhelperFactor.Object)
            {
                PageModel = new PagingInfo()
                {
                    CurrentPage = 2,
                    TotalItems = 28,
                    ItemsPerPage = 10
                },
                PageAction = "Test"
            };
            TagHelperContext ctx=new TagHelperContext(
                new TagHelperAttributeList(),new Dictionary<object, object>()," ");
            var content = new Mock<TagHelperContext>();

           // TagHelperOutput output = new TagHelperOutput("div",
               // new TagHelperAttributeList(), (cache, encoder) => Task.FromResult(content.Object));
                                                       
        }
    }
}
