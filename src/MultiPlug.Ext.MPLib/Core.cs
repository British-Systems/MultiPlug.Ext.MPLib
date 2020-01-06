using System;
using System.Collections.Generic;
using MultiPlug.Base.Exchange;
using MultiPlug.Theme.MultiPlugLibrary.Controllers;
using MultiPlug.Theme.Default2016.Controllers;
using MultiPlug.Extension.Core.Theme;

namespace MultiPlug.Ext.MPLib
{
    public class Core : Pages
    {
        private static Core m_Instance = null;

        public MultiPlugAPI MultiPlugAPI { get; set; }


        private Type[] m_Controllers = new Type[]
        {
            typeof(ImagesController),
            typeof(ScriptsController),
            typeof(StylesController)
        };

        public static Core Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Core();
                }
                return m_Instance;
            }
        }

        private Core()
        {
        }

        public override StringContainer Authorisation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //public override IEnumerable<Controller> Controllers
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public override IEnumerable<Type> ControllersMultiThread
        {
            get
            {
                return m_Controllers;
            }
        }

        public override StringContainer FrameApp
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer FrameExtension
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer HomeApps
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer HomeExtensions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer HomeSettings
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer InternalServerError
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer Layout
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer NotFoundApp
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer NotFoundExtension
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer NotFoundGlobal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsAdd
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsApps
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsExtensions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsHosting
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsHousekeeping
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsPerformance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsRecipes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsSecurity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsSystem
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StringContainer SettingsUpdate
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
