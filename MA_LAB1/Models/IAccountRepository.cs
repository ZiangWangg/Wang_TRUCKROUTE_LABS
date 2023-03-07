namespace MA_LAB1.Models
{
    public interface IAccountRepository
    {
        IQueryable<Account> GetAllUsers { get; }
        void SaveAccount(Account account);
    }
}
