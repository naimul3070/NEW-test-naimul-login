
using test_naimul.DbContexts;
using test_naimul.DTO;
using test_naimul.IRepository;
using System.Linq;



namespace test_naimul.Repository
{
    public class Authentication : IAuthentication
    {
        private readonly ReadWriteContext _context;
        public Authentication(ReadWriteContext Context)
        {
            _context = Context;
        }
        public async Task<string> LogIn(LogInDTO obj)
        {
            //var data = await Task.FromResult(_context.Credential.FirstOrDefault(x => x.MobileNumber == obj.MobileNumber && x.Password == obj.Password && x.IsBlock == false));

            //if (data != null)
            //    return $"Log in as {data.UserName}";
            //return $"Invalid Credential!";
            return "";
        }
    }


}
