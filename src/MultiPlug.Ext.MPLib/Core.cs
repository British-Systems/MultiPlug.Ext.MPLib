using MultiPlug.Base.Exchange;

namespace MultiPlug.Ext.MPLib
{
    public class Core
    {
        private static Core m_Instance = null;

        public IMultiPlugAPI MultiPlugAPI { get; set; }

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
    }
}
