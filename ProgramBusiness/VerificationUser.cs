using ProgramData;
namespace ProgramBusiness
{
    public class VerificationUser
    {
        public bool VerifyUser(string Username, string Password)
        {
            UserData dataService = new UserData();
            var result = dataService.GetUser(Username,Password);

            return result.Username != null ? true : false;
        }

    }
}

        