namespace ShopBags.Sessions
{
    internal class AppSession
    {
        private static AppSession _instance;

        public bool isDebug {  get; private set; }

        private AppSession()
        {
            isDebug = false;
        }

        public static AppSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppSession();
                }
                return _instance;
            }
        }
    }
}
