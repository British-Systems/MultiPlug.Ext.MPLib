using System.Collections.Generic;
using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;
using MultiPlug.Extension.Core.Http;

namespace MultiPlug.Ext.MPLib.Controllers.Apps.EventPicker
{
    [Hidden]
    [ViewAs(ViewAs.FullScreen)]
    [Name("Event Picker")]
    [HttpEndpointType(HttpEndpointType.App)]
    public class EventPickerApp : HttpEndpoint
    {
        readonly Controller[] m_Controllers = new Controller[] { new HomeController() };

        public override IEnumerable<Controller> Controllers
        {
            get
            {
                return m_Controllers;
            }
        }
    }
}
