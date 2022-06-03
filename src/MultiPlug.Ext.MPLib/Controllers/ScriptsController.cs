using System.Text;
using System.Linq;
using System.Collections.Generic;
using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Ext.MPLib.Properties;

namespace MultiPlug.Ext.MPLib.Controllers
{
    [Route("scripts/*")]
    public class ScriptsController : AssetsEndpoint
    {
        public Response Get(string theScriptName)
        {
            string result = "";

            if (theScriptName == "jquery.min-3.2.1.js")
            {
                result = Resources.jquery_3_2_1_min;
            }
            else if (theScriptName == "jquery-3.2.1.js")         // TODO This needs to be removed at some point
            {
                result = Resources.jquery_3_2_1;
            }
            else if (theScriptName == "jquery-1.10.2.js")         // TODO This needs to be removed at some point
            {
                result = Resources.jquery_1_10_2_js;
            }
            else if (theScriptName == "websocket.min.js")
            {
                result = Resources.jquery_signalR_2_4_3_min;
            }
            else if (theScriptName == "bootstrap.min.js")
            {
                result = Resources.bootstrap_min;
            }
            else if (theScriptName == "jstree.min.js")
            {
                result = Resources.jstree_min_js;
            }
            else if (theScriptName == "bootstrap.js")
            {
                result = Resources.bootstrap_js;
            }
            else if (theScriptName == "eventpicker.js")
            {
                result = Resources.eventpicker_js;
            }
            else if (theScriptName == "multiplug.js")
            {
                string ConnectionID = "";

                IEnumerable<KeyValuePair<string, string>> queryStrings = null;

                if (Context != null)
                {
                    queryStrings = Context.QueryString;
                }

                if (queryStrings != null)
                {
                    var match = queryStrings.FirstOrDefault(kv => string.Compare(kv.Key, "id", true) == 0);
                    if (!string.IsNullOrEmpty(match.Value))
                    {
                        ConnectionID = match.Value;
                    }
                }

                if( ! string.IsNullOrEmpty( ConnectionID ) )
                {
                    var sb = new StringBuilder(Resources.multiplugpart1_js);
                    sb.Append(ConnectionID);
                    sb.Append(Resources.multiplugpart2_js);
                    result = sb.ToString();
                }
            }

            if (result != "")
            {
                return new Response { MediaType = "text/javascript", RawBytes = Encoding.ASCII.GetBytes(result) };
            }
            else
            {
                return new Response { StatusCode = System.Net.HttpStatusCode.NotFound };
            }
        }
    }
}
