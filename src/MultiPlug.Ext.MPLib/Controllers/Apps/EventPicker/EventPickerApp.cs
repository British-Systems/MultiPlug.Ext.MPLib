using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.MPLib.Controllers.Apps.EventPicker
{
    [Hidden]
    [ViewAs(ViewAs.FullScreen)]
    [Name("Event Picker")]
    [HttpEndpointType(HttpEndpointType.App)]
    public class EventPickerApp : Controller
    {
    }
}
