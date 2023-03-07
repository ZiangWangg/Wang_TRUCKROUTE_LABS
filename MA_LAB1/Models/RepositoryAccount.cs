namespace MA_LAB1.Models
{
	public class RepositoryAccount: IAccountRepository
    {
	/*	private static List<Account> Accounts = new List<Account>();
		public static void AddData(Account a)
		{
			Accounts.Add(a);
		}


		public static IEnumerable<Account> getData => Accounts; */


        private TruckRouteDBContext _dbContext;
        public RepositoryAccount(TruckRouteDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Account> GetAllUsers => _dbContext.Users;


        public void SaveAccount(Account account)
        { 

            
            _dbContext.Users.Add(account);
            
           
            _dbContext.SaveChanges();
        }
    }
}
