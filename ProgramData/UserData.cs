using AccVerifier;

namespace ProgramData
{
    public class UserData
    {
        List<AccModel> Users = new List<AccModel>();

        public UserData()
        {
            CreateData();
        }
        private void CreateData()
        {

            AccModel user1 = new AccModel { Username = "jether21", Password = "mwuah" };
            AccModel user2 = new AccModel { Username = "missallsunday", Password = "ilovegothmilf" };

            Users.Add(user1);
            Users.Add(user2);

        }

        public AccModel GetUser(string username, string password)
        {
            AccModel foundUser = new AccModel();
            foreach (var user in Users)
            {
                if (user.Username == username && password == user.Password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}