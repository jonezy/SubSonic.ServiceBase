


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace ExampleSite.Data {
	
        /// <summary>
        /// Table: Country
        /// Primary Key: CountryId
        /// </summary>

        public class CountryTable: DatabaseTable {
            
            public CountryTable(IDataProvider provider):base("Country",provider){
                ClassName = "Country";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Code", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("PhoneCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4
                });
                    
                
                
            }
            
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn Code{
                get{
                    return this.GetColumn("Code");
                }
            }
            				
   			public static string CodeColumn{
			      get{
        			return "Code";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn PhoneCode{
                get{
                    return this.GetColumn("PhoneCode");
                }
            }
            				
   			public static string PhoneCodeColumn{
			      get{
        			return "PhoneCode";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Contest
        /// Primary Key: ContestID
        /// </summary>

        public class ContestTable: DatabaseTable {
            
            public ContestTable(IDataProvider provider):base("Contest",provider){
                ClassName = "Contest";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ContestID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("EmailAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("AgreedToTerms", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("KeepUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TimeStamp", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ContestID{
                get{
                    return this.GetColumn("ContestID");
                }
            }
            				
   			public static string ContestIDColumn{
			      get{
        			return "ContestID";
      			}
		    }
           
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
            				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
           
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
            				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
           
            public IColumn EmailAddress{
                get{
                    return this.GetColumn("EmailAddress");
                }
            }
            				
   			public static string EmailAddressColumn{
			      get{
        			return "EmailAddress";
      			}
		    }
           
            public IColumn AgreedToTerms{
                get{
                    return this.GetColumn("AgreedToTerms");
                }
            }
            				
   			public static string AgreedToTermsColumn{
			      get{
        			return "AgreedToTerms";
      			}
		    }
           
            public IColumn KeepUpdated{
                get{
                    return this.GetColumn("KeepUpdated");
                }
            }
            				
   			public static string KeepUpdatedColumn{
			      get{
        			return "KeepUpdated";
      			}
		    }
           
            public IColumn TimeStamp{
                get{
                    return this.GetColumn("TimeStamp");
                }
            }
            				
   			public static string TimeStampColumn{
			      get{
        			return "TimeStamp";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: City
        /// Primary Key: CityId
        /// </summary>

        public class CityTable: DatabaseTable {
            
            public CityTable(IDataProvider provider):base("City",provider){
                ClassName = "City";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("Prov", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 6
                });
                    
                
                
            }
            
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn Prov{
                get{
                    return this.GetColumn("Prov");
                }
            }
            				
   			public static string ProvColumn{
			      get{
        			return "Prov";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfileCategories
        /// Primary Key: UserProfileCategoryID
        /// </summary>

        public class UserProfileCategoriesTable: DatabaseTable {
            
            public UserProfileCategoriesTable(IDataProvider provider):base("UserProfileCategories",provider){
                ClassName = "UserProfileCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileCategoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserProfileMetaCategoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserProfileCategoryID{
                get{
                    return this.GetColumn("UserProfileCategoryID");
                }
            }
            				
   			public static string UserProfileCategoryIDColumn{
			      get{
        			return "UserProfileCategoryID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn UserProfileMetaCategoryID{
                get{
                    return this.GetColumn("UserProfileMetaCategoryID");
                }
            }
            				
   			public static string UserProfileMetaCategoryIDColumn{
			      get{
        			return "UserProfileMetaCategoryID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: DealCategory
        /// Primary Key: DealCategoryID
        /// </summary>

        public class DealCategoryTable: DatabaseTable {
            
            public DealCategoryTable(IDataProvider provider):base("DealCategory",provider){
                ClassName = "DealCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DealCategoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CateogryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }
            
            public IColumn DealCategoryID{
                get{
                    return this.GetColumn("DealCategoryID");
                }
            }
            				
   			public static string DealCategoryIDColumn{
			      get{
        			return "DealCategoryID";
      			}
		    }
           
            public IColumn CateogryName{
                get{
                    return this.GetColumn("CateogryName");
                }
            }
            				
   			public static string CateogryNameColumn{
			      get{
        			return "CateogryName";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfileMetaCategory
        /// Primary Key: UserProfileMetaCategoryID
        /// </summary>

        public class UserProfileMetaCategoryTable: DatabaseTable {
            
            public UserProfileMetaCategoryTable(IDataProvider provider):base("UserProfileMetaCategory",provider){
                ClassName = "UserProfileMetaCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileMetaCategoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParentID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });
                    
                
                
            }
            
            public IColumn UserProfileMetaCategoryID{
                get{
                    return this.GetColumn("UserProfileMetaCategoryID");
                }
            }
            				
   			public static string UserProfileMetaCategoryIDColumn{
			      get{
        			return "UserProfileMetaCategoryID";
      			}
		    }
           
            public IColumn ParentID{
                get{
                    return this.GetColumn("ParentID");
                }
            }
            				
   			public static string ParentIDColumn{
			      get{
        			return "ParentID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: StateOrRegion
        /// Primary Key: StateOrRegionId
        /// </summary>

        public class StateOrRegionTable: DatabaseTable {
            
            public StateOrRegionTable(IDataProvider provider):base("StateOrRegion",provider){
                ClassName = "StateOrRegion";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StateOrRegionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Abbreviation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 6
                });
                    
                
                
            }
            
            public IColumn StateOrRegionId{
                get{
                    return this.GetColumn("StateOrRegionId");
                }
            }
            				
   			public static string StateOrRegionIdColumn{
			      get{
        			return "StateOrRegionId";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn Abbreviation{
                get{
                    return this.GetColumn("Abbreviation");
                }
            }
            				
   			public static string AbbreviationColumn{
			      get{
        			return "Abbreviation";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfileMetaEducation
        /// Primary Key: UserProfileMetaEducationID
        /// </summary>

        public class UserProfileMetaEducationTable: DatabaseTable {
            
            public UserProfileMetaEducationTable(IDataProvider provider):base("UserProfileMetaEducation",provider){
                ClassName = "UserProfileMetaEducation";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileMetaEducationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });
                    
                
                
            }
            
            public IColumn UserProfileMetaEducationID{
                get{
                    return this.GetColumn("UserProfileMetaEducationID");
                }
            }
            				
   			public static string UserProfileMetaEducationIDColumn{
			      get{
        			return "UserProfileMetaEducationID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: DailyDealSubscriber
        /// Primary Key: DailyDealSubscriberID
        /// </summary>

        public class DailyDealSubscriberTable: DatabaseTable {
            
            public DailyDealSubscriberTable(IDataProvider provider):base("DailyDealSubscriber",provider){
                ClassName = "DailyDealSubscriber";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DailyDealSubscriberID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmailAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateOrRegion", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreationDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DailyDealSubscriberID{
                get{
                    return this.GetColumn("DailyDealSubscriberID");
                }
            }
            				
   			public static string DailyDealSubscriberIDColumn{
			      get{
        			return "DailyDealSubscriberID";
      			}
		    }
           
            public IColumn EmailAddress{
                get{
                    return this.GetColumn("EmailAddress");
                }
            }
            				
   			public static string EmailAddressColumn{
			      get{
        			return "EmailAddress";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn StateOrRegion{
                get{
                    return this.GetColumn("StateOrRegion");
                }
            }
            				
   			public static string StateOrRegionColumn{
			      get{
        			return "StateOrRegion";
      			}
		    }
           
            public IColumn CreationDate{
                get{
                    return this.GetColumn("CreationDate");
                }
            }
            				
   			public static string CreationDateColumn{
			      get{
        			return "CreationDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Region
        /// Primary Key: RegionID
        /// </summary>

        public class RegionTable: DatabaseTable {
            
            public RegionTable(IDataProvider provider):base("Region",provider){
                ClassName = "Region";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("RegionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateOrRegionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RegionName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("UrlSlug", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 80
                });

                Columns.Add(new DatabaseColumn("IsDefault", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActive", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn RegionID{
                get{
                    return this.GetColumn("RegionID");
                }
            }
            				
   			public static string RegionIDColumn{
			      get{
        			return "RegionID";
      			}
		    }
           
            public IColumn StateOrRegionID{
                get{
                    return this.GetColumn("StateOrRegionID");
                }
            }
            				
   			public static string StateOrRegionIDColumn{
			      get{
        			return "StateOrRegionID";
      			}
		    }
           
            public IColumn RegionName{
                get{
                    return this.GetColumn("RegionName");
                }
            }
            				
   			public static string RegionNameColumn{
			      get{
        			return "RegionName";
      			}
		    }
           
            public IColumn UrlSlug{
                get{
                    return this.GetColumn("UrlSlug");
                }
            }
            				
   			public static string UrlSlugColumn{
			      get{
        			return "UrlSlug";
      			}
		    }
           
            public IColumn IsDefault{
                get{
                    return this.GetColumn("IsDefault");
                }
            }
            				
   			public static string IsDefaultColumn{
			      get{
        			return "IsDefault";
      			}
		    }
           
            public IColumn IsActive{
                get{
                    return this.GetColumn("IsActive");
                }
            }
            				
   			public static string IsActiveColumn{
			      get{
        			return "IsActive";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfileMetaEmploymentStatus
        /// Primary Key: UserProfileMetaEmploymentStatusID
        /// </summary>

        public class UserProfileMetaEmploymentStatusTable: DatabaseTable {
            
            public UserProfileMetaEmploymentStatusTable(IDataProvider provider):base("UserProfileMetaEmploymentStatus",provider){
                ClassName = "UserProfileMetaEmploymentStatus";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileMetaEmploymentStatusID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn UserProfileMetaEmploymentStatusID{
                get{
                    return this.GetColumn("UserProfileMetaEmploymentStatusID");
                }
            }
            				
   			public static string UserProfileMetaEmploymentStatusIDColumn{
			      get{
        			return "UserProfileMetaEmploymentStatusID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserCredit
        /// Primary Key: UserCreditID
        /// </summary>

        public class UserCreditTable: DatabaseTable {
            
            public UserCreditTable(IDataProvider provider):base("UserCredit",provider){
                ClassName = "UserCredit";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserCreditID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Credits", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserCreditID{
                get{
                    return this.GetColumn("UserCreditID");
                }
            }
            				
   			public static string UserCreditIDColumn{
			      get{
        			return "UserCreditID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn Credits{
                get{
                    return this.GetColumn("Credits");
                }
            }
            				
   			public static string CreditsColumn{
			      get{
        			return "Credits";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfileMetaIncome
        /// Primary Key: UserProfileMetaIncomeID
        /// </summary>

        public class UserProfileMetaIncomeTable: DatabaseTable {
            
            public UserProfileMetaIncomeTable(IDataProvider provider):base("UserProfileMetaIncome",provider){
                ClassName = "UserProfileMetaIncome";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileMetaIncomeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });
                    
                
                
            }
            
            public IColumn UserProfileMetaIncomeID{
                get{
                    return this.GetColumn("UserProfileMetaIncomeID");
                }
            }
            				
   			public static string UserProfileMetaIncomeIDColumn{
			      get{
        			return "UserProfileMetaIncomeID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserAuthorization
        /// Primary Key: UserAuthorizationID
        /// </summary>

        public class UserAuthorizationTable: DatabaseTable {
            
            public UserAuthorizationTable(IDataProvider provider):base("UserAuthorization",provider){
                ClassName = "UserAuthorization";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserAuthorizationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Service", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ScreenName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Token", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("TokenSecret", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("IsLoginAccount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserAuthorizationID{
                get{
                    return this.GetColumn("UserAuthorizationID");
                }
            }
            				
   			public static string UserAuthorizationIDColumn{
			      get{
        			return "UserAuthorizationID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn Service{
                get{
                    return this.GetColumn("Service");
                }
            }
            				
   			public static string ServiceColumn{
			      get{
        			return "Service";
      			}
		    }
           
            public IColumn ScreenName{
                get{
                    return this.GetColumn("ScreenName");
                }
            }
            				
   			public static string ScreenNameColumn{
			      get{
        			return "ScreenName";
      			}
		    }
           
            public IColumn Token{
                get{
                    return this.GetColumn("Token");
                }
            }
            				
   			public static string TokenColumn{
			      get{
        			return "Token";
      			}
		    }
           
            public IColumn TokenSecret{
                get{
                    return this.GetColumn("TokenSecret");
                }
            }
            				
   			public static string TokenSecretColumn{
			      get{
        			return "TokenSecret";
      			}
		    }
           
            public IColumn IsLoginAccount{
                get{
                    return this.GetColumn("IsLoginAccount");
                }
            }
            				
   			public static string IsLoginAccountColumn{
			      get{
        			return "IsLoginAccount";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: OrderHistory
        /// Primary Key: OrderHistoryID
        /// </summary>

        public class OrderHistoryTable: DatabaseTable {
            
            public OrderHistoryTable(IDataProvider provider):base("OrderHistory",provider){
                ClassName = "OrderHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("OrderHistoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PayPalTransactionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Amount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TimeStamp", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn OrderHistoryID{
                get{
                    return this.GetColumn("OrderHistoryID");
                }
            }
            				
   			public static string OrderHistoryIDColumn{
			      get{
        			return "OrderHistoryID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn PayPalTransactionID{
                get{
                    return this.GetColumn("PayPalTransactionID");
                }
            }
            				
   			public static string PayPalTransactionIDColumn{
			      get{
        			return "PayPalTransactionID";
      			}
		    }
           
            public IColumn Amount{
                get{
                    return this.GetColumn("Amount");
                }
            }
            				
   			public static string AmountColumn{
			      get{
        			return "Amount";
      			}
		    }
           
            public IColumn TimeStamp{
                get{
                    return this.GetColumn("TimeStamp");
                }
            }
            				
   			public static string TimeStampColumn{
			      get{
        			return "TimeStamp";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Cart
        /// Primary Key: CartID
        /// </summary>

        public class CartTable: DatabaseTable {
            
            public CartTable(IDataProvider provider):base("Cart",provider){
                ClassName = "Cart";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CartID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CartID{
                get{
                    return this.GetColumn("CartID");
                }
            }
            				
   			public static string CartIDColumn{
			      get{
        			return "CartID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Vendor
        /// Primary Key: VendorID
        /// </summary>

        public class VendorTable: DatabaseTable {
            
            public VendorTable(IDataProvider provider):base("Vendor",provider){
                ClassName = "Vendor";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParentVendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Biography", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Address1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Address2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("PostalZip", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateOrProvince", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Website", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("IsActive", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn ParentVendorID{
                get{
                    return this.GetColumn("ParentVendorID");
                }
            }
            				
   			public static string ParentVendorIDColumn{
			      get{
        			return "ParentVendorID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn Biography{
                get{
                    return this.GetColumn("Biography");
                }
            }
            				
   			public static string BiographyColumn{
			      get{
        			return "Biography";
      			}
		    }
           
            public IColumn Address1{
                get{
                    return this.GetColumn("Address1");
                }
            }
            				
   			public static string Address1Column{
			      get{
        			return "Address1";
      			}
		    }
           
            public IColumn Address2{
                get{
                    return this.GetColumn("Address2");
                }
            }
            				
   			public static string Address2Column{
			      get{
        			return "Address2";
      			}
		    }
           
            public IColumn PostalZip{
                get{
                    return this.GetColumn("PostalZip");
                }
            }
            				
   			public static string PostalZipColumn{
			      get{
        			return "PostalZip";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn StateOrProvince{
                get{
                    return this.GetColumn("StateOrProvince");
                }
            }
            				
   			public static string StateOrProvinceColumn{
			      get{
        			return "StateOrProvince";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
            				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
           
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
            				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
           
            public IColumn Website{
                get{
                    return this.GetColumn("Website");
                }
            }
            				
   			public static string WebsiteColumn{
			      get{
        			return "Website";
      			}
		    }
           
            public IColumn IsActive{
                get{
                    return this.GetColumn("IsActive");
                }
            }
            				
   			public static string IsActiveColumn{
			      get{
        			return "IsActive";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfile
        /// Primary Key: UserProfileID
        /// </summary>

        public class UserProfileTable: DatabaseTable {
            
            public UserProfileTable(IDataProvider provider):base("UserProfile",provider){
                ClassName = "UserProfile";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Sex", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("Age", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("EducationID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmploymentStatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IncomeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RelationshipStatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HomeOwner", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HaveChildren", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HavePets", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserProfileID{
                get{
                    return this.GetColumn("UserProfileID");
                }
            }
            				
   			public static string UserProfileIDColumn{
			      get{
        			return "UserProfileID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn Sex{
                get{
                    return this.GetColumn("Sex");
                }
            }
            				
   			public static string SexColumn{
			      get{
        			return "Sex";
      			}
		    }
           
            public IColumn Age{
                get{
                    return this.GetColumn("Age");
                }
            }
            				
   			public static string AgeColumn{
			      get{
        			return "Age";
      			}
		    }
           
            public IColumn EducationID{
                get{
                    return this.GetColumn("EducationID");
                }
            }
            				
   			public static string EducationIDColumn{
			      get{
        			return "EducationID";
      			}
		    }
           
            public IColumn EmploymentStatusID{
                get{
                    return this.GetColumn("EmploymentStatusID");
                }
            }
            				
   			public static string EmploymentStatusIDColumn{
			      get{
        			return "EmploymentStatusID";
      			}
		    }
           
            public IColumn IncomeID{
                get{
                    return this.GetColumn("IncomeID");
                }
            }
            				
   			public static string IncomeIDColumn{
			      get{
        			return "IncomeID";
      			}
		    }
           
            public IColumn RelationshipStatusID{
                get{
                    return this.GetColumn("RelationshipStatusID");
                }
            }
            				
   			public static string RelationshipStatusIDColumn{
			      get{
        			return "RelationshipStatusID";
      			}
		    }
           
            public IColumn HomeOwner{
                get{
                    return this.GetColumn("HomeOwner");
                }
            }
            				
   			public static string HomeOwnerColumn{
			      get{
        			return "HomeOwner";
      			}
		    }
           
            public IColumn HaveChildren{
                get{
                    return this.GetColumn("HaveChildren");
                }
            }
            				
   			public static string HaveChildrenColumn{
			      get{
        			return "HaveChildren";
      			}
		    }
           
            public IColumn HavePets{
                get{
                    return this.GetColumn("HavePets");
                }
            }
            				
   			public static string HavePetsColumn{
			      get{
        			return "HavePets";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserDetail
        /// Primary Key: UserDetailID
        /// </summary>

        public class UserDetailTable: DatabaseTable {
            
            public UserDetailTable(IDataProvider provider):base("UserDetail",provider){
                ClassName = "UserDetail";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserDetailID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateOrProvince", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Region", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BillingAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn UserDetailID{
                get{
                    return this.GetColumn("UserDetailID");
                }
            }
            				
   			public static string UserDetailIDColumn{
			      get{
        			return "UserDetailID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
            				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
           
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
            				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn StateOrProvince{
                get{
                    return this.GetColumn("StateOrProvince");
                }
            }
            				
   			public static string StateOrProvinceColumn{
			      get{
        			return "StateOrProvince";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Region{
                get{
                    return this.GetColumn("Region");
                }
            }
            				
   			public static string RegionColumn{
			      get{
        			return "Region";
      			}
		    }
           
            public IColumn BillingAddress{
                get{
                    return this.GetColumn("BillingAddress");
                }
            }
            				
   			public static string BillingAddressColumn{
			      get{
        			return "BillingAddress";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: DealVendor
        /// Primary Key: DealVendorID
        /// </summary>

        public class DealVendorTable: DatabaseTable {
            
            public DealVendorTable(IDataProvider provider):base("DealVendor",provider){
                ClassName = "DealVendor";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DealVendorID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DealID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DealVendorID{
                get{
                    return this.GetColumn("DealVendorID");
                }
            }
            				
   			public static string DealVendorIDColumn{
			      get{
        			return "DealVendorID";
      			}
		    }
           
            public IColumn DealID{
                get{
                    return this.GetColumn("DealID");
                }
            }
            				
   			public static string DealIDColumn{
			      get{
        			return "DealID";
      			}
		    }
           
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: DealInRegion
        /// Primary Key: DealInRegion
        /// </summary>

        public class DealInRegionTable: DatabaseTable {
            
            public DealInRegionTable(IDataProvider provider):base("DealInRegion",provider){
                ClassName = "DealInRegion";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DealInRegion", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DealID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RegionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DealInRegion{
                get{
                    return this.GetColumn("DealInRegion");
                }
            }
            				
   			public static string DealInRegionColumn{
			      get{
        			return "DealInRegion";
      			}
		    }
           
            public IColumn DealID{
                get{
                    return this.GetColumn("DealID");
                }
            }
            				
   			public static string DealIDColumn{
			      get{
        			return "DealID";
      			}
		    }
           
            public IColumn RegionID{
                get{
                    return this.GetColumn("RegionID");
                }
            }
            				
   			public static string RegionIDColumn{
			      get{
        			return "RegionID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: PurchasedDeals
        /// Primary Key: PurchasedDealID
        /// </summary>

        public class PurchasedDealsTable: DatabaseTable {
            
            public PurchasedDealsTable(IDataProvider provider):base("PurchasedDeals",provider){
                ClassName = "PurchasedDeal";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PurchasedDealID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrderHistoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DealID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Quantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Price", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SerialNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn PurchasedDealID{
                get{
                    return this.GetColumn("PurchasedDealID");
                }
            }
            				
   			public static string PurchasedDealIDColumn{
			      get{
        			return "PurchasedDealID";
      			}
		    }
           
            public IColumn OrderHistoryID{
                get{
                    return this.GetColumn("OrderHistoryID");
                }
            }
            				
   			public static string OrderHistoryIDColumn{
			      get{
        			return "OrderHistoryID";
      			}
		    }
           
            public IColumn DealID{
                get{
                    return this.GetColumn("DealID");
                }
            }
            				
   			public static string DealIDColumn{
			      get{
        			return "DealID";
      			}
		    }
           
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn Quantity{
                get{
                    return this.GetColumn("Quantity");
                }
            }
            				
   			public static string QuantityColumn{
			      get{
        			return "Quantity";
      			}
		    }
           
            public IColumn Price{
                get{
                    return this.GetColumn("Price");
                }
            }
            				
   			public static string PriceColumn{
			      get{
        			return "Price";
      			}
		    }
           
            public IColumn SerialNumber{
                get{
                    return this.GetColumn("SerialNumber");
                }
            }
            				
   			public static string SerialNumberColumn{
			      get{
        			return "SerialNumber";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: CartItem
        /// Primary Key: CartItemID
        /// </summary>

        public class CartItemTable: DatabaseTable {
            
            public CartItemTable(IDataProvider provider):base("CartItem",provider){
                ClassName = "CartItem";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CartItemID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CartID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DealID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Qty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Price", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CartItemID{
                get{
                    return this.GetColumn("CartItemID");
                }
            }
            				
   			public static string CartItemIDColumn{
			      get{
        			return "CartItemID";
      			}
		    }
           
            public IColumn CartID{
                get{
                    return this.GetColumn("CartID");
                }
            }
            				
   			public static string CartIDColumn{
			      get{
        			return "CartID";
      			}
		    }
           
            public IColumn DealID{
                get{
                    return this.GetColumn("DealID");
                }
            }
            				
   			public static string DealIDColumn{
			      get{
        			return "DealID";
      			}
		    }
           
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn Qty{
                get{
                    return this.GetColumn("Qty");
                }
            }
            				
   			public static string QtyColumn{
			      get{
        			return "Qty";
      			}
		    }
           
            public IColumn Price{
                get{
                    return this.GetColumn("Price");
                }
            }
            				
   			public static string PriceColumn{
			      get{
        			return "Price";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfilePlaces
        /// Primary Key: UserProfilePlacesID
        /// </summary>

        public class UserProfilePlacesTable: DatabaseTable {
            
            public UserProfilePlacesTable(IDataProvider provider):base("UserProfilePlaces",provider){
                ClassName = "UserProfilePlace";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfilePlacesID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RegionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserProfilePlacesID{
                get{
                    return this.GetColumn("UserProfilePlacesID");
                }
            }
            				
   			public static string UserProfilePlacesIDColumn{
			      get{
        			return "UserProfilePlacesID";
      			}
		    }
           
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn RegionID{
                get{
                    return this.GetColumn("RegionID");
                }
            }
            				
   			public static string RegionIDColumn{
			      get{
        			return "RegionID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Html
        /// Primary Key: HtmlID
        /// </summary>

        public class HtmlTable: DatabaseTable {
            
            public HtmlTable(IDataProvider provider):base("Html",provider){
                ClassName = "Html";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("HtmlID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Slug", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("HtmlText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1073741823
                });
                    
                
                
            }
            
            public IColumn HtmlID{
                get{
                    return this.GetColumn("HtmlID");
                }
            }
            				
   			public static string HtmlIDColumn{
			      get{
        			return "HtmlID";
      			}
		    }
           
            public IColumn Slug{
                get{
                    return this.GetColumn("Slug");
                }
            }
            				
   			public static string SlugColumn{
			      get{
        			return "Slug";
      			}
		    }
           
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
            				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
           
            public IColumn HtmlText{
                get{
                    return this.GetColumn("HtmlText");
                }
            }
            				
   			public static string HtmlTextColumn{
			      get{
        			return "HtmlText";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: User
        /// Primary Key: UserID
        /// </summary>

        public class UserTable: DatabaseTable {
            
            public UserTable(IDataProvider provider):base("User",provider){
                ClassName = "User";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserRoleID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Username", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("CreationDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ResetVerification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActive", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UserID{
                get{
                    return this.GetColumn("UserID");
                }
            }
            				
   			public static string UserIDColumn{
			      get{
        			return "UserID";
      			}
		    }
           
            public IColumn UserRoleID{
                get{
                    return this.GetColumn("UserRoleID");
                }
            }
            				
   			public static string UserRoleIDColumn{
			      get{
        			return "UserRoleID";
      			}
		    }
           
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
            				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
           
            public IColumn Username{
                get{
                    return this.GetColumn("Username");
                }
            }
            				
   			public static string UsernameColumn{
			      get{
        			return "Username";
      			}
		    }
           
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
            				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
           
            public IColumn CreationDate{
                get{
                    return this.GetColumn("CreationDate");
                }
            }
            				
   			public static string CreationDateColumn{
			      get{
        			return "CreationDate";
      			}
		    }
           
            public IColumn ResetVerification{
                get{
                    return this.GetColumn("ResetVerification");
                }
            }
            				
   			public static string ResetVerificationColumn{
			      get{
        			return "ResetVerification";
      			}
		    }
           
            public IColumn IsActive{
                get{
                    return this.GetColumn("IsActive");
                }
            }
            				
   			public static string IsActiveColumn{
			      get{
        			return "IsActive";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Deal
        /// Primary Key: DealID
        /// </summary>

        public class DealTable: DatabaseTable {
            
            public DealTable(IDataProvider provider):base("Deal",provider){
                ClassName = "Deal";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DealID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CategoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("StreetTigerThinks", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Picture", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("OriginalPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DealPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VendorCut", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Qty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LimitPerCustomer", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActiveAfterQtySold", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PublishDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CloseDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceFee", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CharityServiceFee", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Taxes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsFeatured", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsSticky", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsSoldOut", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActivated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActive", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DealID{
                get{
                    return this.GetColumn("DealID");
                }
            }
            				
   			public static string DealIDColumn{
			      get{
        			return "DealID";
      			}
		    }
           
            public IColumn CategoryID{
                get{
                    return this.GetColumn("CategoryID");
                }
            }
            				
   			public static string CategoryIDColumn{
			      get{
        			return "CategoryID";
      			}
		    }
           
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
            				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
            public IColumn StreetTigerThinks{
                get{
                    return this.GetColumn("StreetTigerThinks");
                }
            }
            				
   			public static string StreetTigerThinksColumn{
			      get{
        			return "StreetTigerThinks";
      			}
		    }
           
            public IColumn Picture{
                get{
                    return this.GetColumn("Picture");
                }
            }
            				
   			public static string PictureColumn{
			      get{
        			return "Picture";
      			}
		    }
           
            public IColumn OriginalPrice{
                get{
                    return this.GetColumn("OriginalPrice");
                }
            }
            				
   			public static string OriginalPriceColumn{
			      get{
        			return "OriginalPrice";
      			}
		    }
           
            public IColumn DealPrice{
                get{
                    return this.GetColumn("DealPrice");
                }
            }
            				
   			public static string DealPriceColumn{
			      get{
        			return "DealPrice";
      			}
		    }
           
            public IColumn VendorCut{
                get{
                    return this.GetColumn("VendorCut");
                }
            }
            				
   			public static string VendorCutColumn{
			      get{
        			return "VendorCut";
      			}
		    }
           
            public IColumn Qty{
                get{
                    return this.GetColumn("Qty");
                }
            }
            				
   			public static string QtyColumn{
			      get{
        			return "Qty";
      			}
		    }
           
            public IColumn LimitPerCustomer{
                get{
                    return this.GetColumn("LimitPerCustomer");
                }
            }
            				
   			public static string LimitPerCustomerColumn{
			      get{
        			return "LimitPerCustomer";
      			}
		    }
           
            public IColumn ActiveAfterQtySold{
                get{
                    return this.GetColumn("ActiveAfterQtySold");
                }
            }
            				
   			public static string ActiveAfterQtySoldColumn{
			      get{
        			return "ActiveAfterQtySold";
      			}
		    }
           
            public IColumn PublishDate{
                get{
                    return this.GetColumn("PublishDate");
                }
            }
            				
   			public static string PublishDateColumn{
			      get{
        			return "PublishDate";
      			}
		    }
           
            public IColumn CloseDate{
                get{
                    return this.GetColumn("CloseDate");
                }
            }
            				
   			public static string CloseDateColumn{
			      get{
        			return "CloseDate";
      			}
		    }
           
            public IColumn ServiceFee{
                get{
                    return this.GetColumn("ServiceFee");
                }
            }
            				
   			public static string ServiceFeeColumn{
			      get{
        			return "ServiceFee";
      			}
		    }
           
            public IColumn CharityServiceFee{
                get{
                    return this.GetColumn("CharityServiceFee");
                }
            }
            				
   			public static string CharityServiceFeeColumn{
			      get{
        			return "CharityServiceFee";
      			}
		    }
           
            public IColumn Taxes{
                get{
                    return this.GetColumn("Taxes");
                }
            }
            				
   			public static string TaxesColumn{
			      get{
        			return "Taxes";
      			}
		    }
           
            public IColumn IsFeatured{
                get{
                    return this.GetColumn("IsFeatured");
                }
            }
            				
   			public static string IsFeaturedColumn{
			      get{
        			return "IsFeatured";
      			}
		    }
           
            public IColumn IsSticky{
                get{
                    return this.GetColumn("IsSticky");
                }
            }
            				
   			public static string IsStickyColumn{
			      get{
        			return "IsSticky";
      			}
		    }
           
            public IColumn IsSoldOut{
                get{
                    return this.GetColumn("IsSoldOut");
                }
            }
            				
   			public static string IsSoldOutColumn{
			      get{
        			return "IsSoldOut";
      			}
		    }
           
            public IColumn IsActivated{
                get{
                    return this.GetColumn("IsActivated");
                }
            }
            				
   			public static string IsActivatedColumn{
			      get{
        			return "IsActivated";
      			}
		    }
           
            public IColumn IsActive{
                get{
                    return this.GetColumn("IsActive");
                }
            }
            				
   			public static string IsActiveColumn{
			      get{
        			return "IsActive";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TigerFact
        /// Primary Key: TigerFactID
        /// </summary>

        public class TigerFactTable: DatabaseTable {
            
            public TigerFactTable(IDataProvider provider):base("TigerFact",provider){
                ClassName = "TigerFact";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TigerFactID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FactTitle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Fact", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn TigerFactID{
                get{
                    return this.GetColumn("TigerFactID");
                }
            }
            				
   			public static string TigerFactIDColumn{
			      get{
        			return "TigerFactID";
      			}
		    }
           
            public IColumn FactTitle{
                get{
                    return this.GetColumn("FactTitle");
                }
            }
            				
   			public static string FactTitleColumn{
			      get{
        			return "FactTitle";
      			}
		    }
           
            public IColumn Fact{
                get{
                    return this.GetColumn("Fact");
                }
            }
            				
   			public static string FactColumn{
			      get{
        			return "Fact";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserProfileMetaRelationshipStatus
        /// Primary Key: UserProfileMetaRelationshipStatusID
        /// </summary>

        public class UserProfileMetaRelationshipStatusTable: DatabaseTable {
            
            public UserProfileMetaRelationshipStatusTable(IDataProvider provider):base("UserProfileMetaRelationshipStatus",provider){
                ClassName = "UserProfileMetaRelationshipStatus";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserProfileMetaRelationshipStatusID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn UserProfileMetaRelationshipStatusID{
                get{
                    return this.GetColumn("UserProfileMetaRelationshipStatusID");
                }
            }
            				
   			public static string UserProfileMetaRelationshipStatusIDColumn{
			      get{
        			return "UserProfileMetaRelationshipStatusID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UserRole
        /// Primary Key: UserRoleID
        /// </summary>

        public class UserRoleTable: DatabaseTable {
            
            public UserRoleTable(IDataProvider provider):base("UserRole",provider){
                ClassName = "UserRole";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserRoleID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RoleName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn UserRoleID{
                get{
                    return this.GetColumn("UserRoleID");
                }
            }
            				
   			public static string UserRoleIDColumn{
			      get{
        			return "UserRoleID";
      			}
		    }
           
            public IColumn RoleName{
                get{
                    return this.GetColumn("RoleName");
                }
            }
            				
   			public static string RoleNameColumn{
			      get{
        			return "RoleName";
      			}
		    }
           
                    
        }
        
}