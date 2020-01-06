using System;
using MultiPlug.Extension.Core;
using MultiPlug.Base.Exchange;
using MultiPlug.Extension.Core.Theme;
using MultiPlug.Ext.MPLib.Properties;
using MultiPlug.Ext.MPLib.Controllers.Apps.EventPicker;
using MultiPlug.Extension.Core.Http;

namespace MultiPlug.Ext.MPLib
{
    public class MPLib : MultiPlugExtension, ITheme
    {
        private HttpEndpoint[] m_Apps = new HttpEndpoint[] { new EventPickerApp() };

        public MPLib()
        {
            Core.Instance.MultiPlugAPI = MultiPlugAPI;
        }

        public override HttpEndpoint[] HttpEndpoints
        {
            get
            {
                return m_Apps;
            }
        }

        public override Event[] Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Pages Pages
        {
            get
            {
                return Core.Instance;
            }
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

        public override Subscription[] Subscriptions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void Initialise()
        {
            throw new NotImplementedException();
        }

        public override void Load(KeyValuesJson[] config)
        {
            throw new NotImplementedException();
        }

        public override void OnUnhandledException(UnhandledExceptionEventArgs args)
        {
            throw new NotImplementedException();
        }

        public override object Save()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {

            throw new NotImplementedException();
        }

        public override void Shutdown()
        {
            throw new NotImplementedException();
        }

        public override void Pause()
        {
            throw new NotImplementedException();
        }
    }
}
