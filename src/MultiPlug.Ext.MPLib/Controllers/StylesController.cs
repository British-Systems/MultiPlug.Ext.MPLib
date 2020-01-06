using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Ext.MPLib.Properties;
using System.Text;

namespace MultiPlug.Theme.MultiPlugLibrary.Controllers
{
    [Route("styles/*")]
    public class StylesController : Controller
    {
        public Response Get(string FileName)
        {
            string result = "";

            if (FileName == "bootstrap.min.css")
            {
                result = Resources.bootstrap_min_css;
            }
            else if (FileName == "jstree.style.min.css")
            {
                result = Resources.jstree_style_min_css;
            }


            if (result != "")
            {
                return new Response { MediaType = "text/css", RawBytes = Encoding.ASCII.GetBytes(result) };
            }
            else
            {
                return new Response { StatusCode = System.Net.HttpStatusCode.NotFound };
            }
        }
    }
}
