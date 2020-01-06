using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;

namespace MultiPlug.Ext.MPLib.Controllers.Apps.EventPicker
{
    [Route("")]
    class HomeController : Controller
    {
        public Response Get()
        {
            return new Response
            {
                Model = new Models.Apps.EventPicker
                {
                    Extensions = Core.Instance.MultiPlugAPI.Extensions
                },
                Template = "EventPicker_Home"
            };
        }
    }
}
