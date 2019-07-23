namespace SULS.Services
{
    public interface ISubmissionsServices
    {
        void CreateSubmissions(string code, string userId, string problemId);
    }
}