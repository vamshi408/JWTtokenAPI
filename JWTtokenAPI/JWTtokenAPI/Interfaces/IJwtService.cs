namespace JWTtokenAPI.Interfaces
{
    //To generage token based on user credentials
    public interface IJwtService
    {
        string Authentication(string username, string password);
    }
}
