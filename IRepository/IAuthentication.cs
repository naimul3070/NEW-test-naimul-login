using test_naimul.DTO;

namespace test_naimul.IRepository
{
    public interface IAuthentication
    {
        public Task<string> LogIn(LogInDTO obj);
    }
}
