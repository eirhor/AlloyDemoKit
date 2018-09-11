using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using AlloyDemoKit.Models.Pages;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyDemoKit.Areas.TvpDemo.Models
{
    [ContentType(DisplayName = "Tvp Demo Start page", GUID = "531C0C02-DC5B-475C-9723-E8828D7E00C7", GroupName = Global.GroupNames.Specialized)]
    public class StartPage: StartPageBase
    {
        [Display(Name = "Tvp heading", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string TvpHeading { get; set; }
    }
}