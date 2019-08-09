namespace Quark.Common
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; }

        protected UserAuthenticated()
        {
            
        }

        public UserAuthenticated(string email)
        {
            Email = email;
        }
    }
}