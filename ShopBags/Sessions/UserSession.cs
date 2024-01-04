namespace ShopBags.Sessions
{
    public class UserSession
    {
        private static UserSession _instance;

        public int id { get; private set; }
        public string email { get; private set; }
        public string username { get; private set; }
        public bool isAdmin { get; private set; }
        public bool isEditor { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        public void SetUserData(int userId, string userName, string userEmail, bool admin, bool editor)
        {
            id = userId;
            username = userName;
            email = userEmail;
            isAdmin = admin;
            isEditor = editor;
        }

    }
}
