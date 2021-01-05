using System.Text;
using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Ext.MPLib.Properties;

namespace MultiPlug.Ext.MPLib.Controllers
{
    [Route("styles/*")]
    public class StylesController : AssetsEndpoint
    {
        public Response Get(string FileName)
        {
            string result = string.Empty;

            if (FileName == "bootstrap.min.css")
            {
                result = Resources.bootstrap_min_css;
            }
            else if (FileName == "jstree.style.min.css")
            {
                result = Resources.jstree_style_min_css;
            }

            if (result != string.Empty)
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
