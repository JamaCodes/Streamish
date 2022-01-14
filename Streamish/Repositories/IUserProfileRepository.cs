using Streamish.Models;

namespace Streamish.Repositories
{
    public interface IUserProfileRepository
    {
        void Add(UserProfile user);
        void Delete(int id);
        UserProfile GetByFirebaseUserId(string firebaseUserId);
        void Update(UserProfile user);
    }
}