using MultiPlug.Extension.Core;
using MultiPlug.Ext.MPLib.Properties;
using MultiPlug.Extension.Core.Http;

namespace MultiPlug.Ext.MPLib
{
    public class MPLib : MultiPlugExtension
    {
        public MPLib()
        {
            Core.Instance.MultiPlugAPI = this.MultiPlugAPI;
        }

        public override RazorTemplate[] RazorTemplates
        {
            get
            {
                return new RazorTemplate[]
                {
                    new RazorTemplate("EventPicker_Home", Resources.EventPicker_html)
                };
            }
        }
    }
}
