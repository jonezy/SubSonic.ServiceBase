


using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;

namespace ExampleSite.Data
{
    public partial class ExampleSiteDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public ExampleSiteDB() 
        { 
            DataProvider = ProviderFactory.GetProvider("ExampleSite");
            Init();
        }

        public ExampleSiteDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public ExampleSiteDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<Country> Countries { get; set; }
        public Query<Contest> Contests { get; set; }
        public Query<City> Cities { get; set; }
        public Query<UserProfileCategory> UserProfileCategories { get; set; }
        public Query<DealCategory> DealCategories { get; set; }
        public Query<UserProfileMetaCategory> UserProfileMetaCategories { get; set; }
        public Query<StateOrRegion> StateOrRegions { get; set; }
        public Query<UserProfileMetaEducation> UserProfileMetaEducations { get; set; }
        public Query<DailyDealSubscriber> DailyDealSubscribers { get; set; }
        public Query<Region> Regions { get; set; }
        public Query<UserProfileMetaEmploymentStatus> UserProfileMetaEmploymentStatuses { get; set; }
        public Query<UserCredit> UserCredits { get; set; }
        public Query<UserProfileMetaIncome> UserProfileMetaIncomes { get; set; }
        public Query<UserAuthorization> UserAuthorizations { get; set; }
        public Query<OrderHistory> OrderHistories { get; set; }
        public Query<Cart> Carts { get; set; }
        public Query<Vendor> Vendors { get; set; }
        public Query<UserProfile> UserProfiles { get; set; }
        public Query<UserDetail> UserDetails { get; set; }
        public Query<DealVendor> DealVendors { get; set; }
        public Query<DealInRegion> DealInRegions { get; set; }
        public Query<PurchasedDeal> PurchasedDeals { get; set; }
        public Query<CartItem> CartItems { get; set; }
        public Query<UserProfilePlace> UserProfilePlaces { get; set; }
        public Query<Html> Htmls { get; set; }
        public Query<User> Users { get; set; }
        public Query<Deal> Deals { get; set; }
        public Query<TigerFact> TigerFacts { get; set; }
        public Query<UserProfileMetaRelationshipStatus> UserProfileMetaRelationshipStatuses { get; set; }
        public Query<UserRole> UserRoles { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            Countries = new Query<Country>(provider);
            Contests = new Query<Contest>(provider);
            Cities = new Query<City>(provider);
            UserProfileCategories = new Query<UserProfileCategory>(provider);
            DealCategories = new Query<DealCategory>(provider);
            UserProfileMetaCategories = new Query<UserProfileMetaCategory>(provider);
            StateOrRegions = new Query<StateOrRegion>(provider);
            UserProfileMetaEducations = new Query<UserProfileMetaEducation>(provider);
            DailyDealSubscribers = new Query<DailyDealSubscriber>(provider);
            Regions = new Query<Region>(provider);
            UserProfileMetaEmploymentStatuses = new Query<UserProfileMetaEmploymentStatus>(provider);
            UserCredits = new Query<UserCredit>(provider);
            UserProfileMetaIncomes = new Query<UserProfileMetaIncome>(provider);
            UserAuthorizations = new Query<UserAuthorization>(provider);
            OrderHistories = new Query<OrderHistory>(provider);
            Carts = new Query<Cart>(provider);
            Vendors = new Query<Vendor>(provider);
            UserProfiles = new Query<UserProfile>(provider);
            UserDetails = new Query<UserDetail>(provider);
            DealVendors = new Query<DealVendor>(provider);
            DealInRegions = new Query<DealInRegion>(provider);
            PurchasedDeals = new Query<PurchasedDeal>(provider);
            CartItems = new Query<CartItem>(provider);
            UserProfilePlaces = new Query<UserProfilePlace>(provider);
            Htmls = new Query<Html>(provider);
            Users = new Query<User>(provider);
            Deals = new Query<Deal>(provider);
            TigerFacts = new Query<TigerFact>(provider);
            UserProfileMetaRelationshipStatuses = new Query<UserProfileMetaRelationshipStatus>(provider);
            UserRoles = new Query<UserRole>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new CountryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContestTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CityTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileCategoriesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DealCategoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileMetaCategoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new StateOrRegionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileMetaEducationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DailyDealSubscriberTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new RegionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileMetaEmploymentStatusTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserCreditTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileMetaIncomeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserAuthorizationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new OrderHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CartTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VendorTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserDetailTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DealVendorTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DealInRegionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PurchasedDealsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CartItemTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfilePlacesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HtmlTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DealTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TigerFactTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserProfileMetaRelationshipStatusTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UserRoleTable(DataProvider));
            }
            #endregion
        }
    }
}