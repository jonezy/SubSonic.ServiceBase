


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace ExampleSite.Data {
	
        /// <summary>
        /// Table: UserImage
        /// Primary Key: UserImageID
        /// </summary>

        public class UserImageTable: DatabaseTable {
            
            public UserImageTable(IDataProvider provider):base("UserImage",provider){
                ClassName = "UserImage";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UserImageID", this)
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

                Columns.Add(new DatabaseColumn("ImageName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });
                    
                
                
            }
            
            public IColumn UserImageID{
                get{
                    return this.GetColumn("UserImageID");
                }
            }
            				
   			public static string UserImageIDColumn{
			      get{
        			return "UserImageID";
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
           
            public IColumn ImageName{
                get{
                    return this.GetColumn("ImageName");
                }
            }
            				
   			public static string ImageNameColumn{
			      get{
        			return "ImageName";
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

                Columns.Add(new DatabaseColumn("Gender", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("DateOfBirth", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeansToYou", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ProfileImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
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
           
            public IColumn Gender{
                get{
                    return this.GetColumn("Gender");
                }
            }
            				
   			public static string GenderColumn{
			      get{
        			return "Gender";
      			}
		    }
           
            public IColumn DateOfBirth{
                get{
                    return this.GetColumn("DateOfBirth");
                }
            }
            				
   			public static string DateOfBirthColumn{
			      get{
        			return "DateOfBirth";
      			}
		    }
           
            public IColumn MeansToYou{
                get{
                    return this.GetColumn("MeansToYou");
                }
            }
            				
   			public static string MeansToYouColumn{
			      get{
        			return "MeansToYou";
      			}
		    }
           
            public IColumn ProfileImage{
                get{
                    return this.GetColumn("ProfileImage");
                }
            }
            				
   			public static string ProfileImageColumn{
			      get{
        			return "ProfileImage";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: News
        /// Primary Key: NewsID
        /// </summary>

        public class NewsTable: DatabaseTable {
            
            public NewsTable(IDataProvider provider):base("News",provider){
                ClassName = "News";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("NewsID", this)
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

                Columns.Add(new DatabaseColumn("Date", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Summary", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Article", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Attachment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
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
            
            public IColumn NewsID{
                get{
                    return this.GetColumn("NewsID");
                }
            }
            				
   			public static string NewsIDColumn{
			      get{
        			return "NewsID";
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
           
            public IColumn Date{
                get{
                    return this.GetColumn("Date");
                }
            }
            				
   			public static string DateColumn{
			      get{
        			return "Date";
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
           
            public IColumn Summary{
                get{
                    return this.GetColumn("Summary");
                }
            }
            				
   			public static string SummaryColumn{
			      get{
        			return "Summary";
      			}
		    }
           
            public IColumn Article{
                get{
                    return this.GetColumn("Article");
                }
            }
            				
   			public static string ArticleColumn{
			      get{
        			return "Article";
      			}
		    }
           
            public IColumn Attachment{
                get{
                    return this.GetColumn("Attachment");
                }
            }
            				
   			public static string AttachmentColumn{
			      get{
        			return "Attachment";
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
        /// Table: ProductCategory
        /// Primary Key: ProductCategoryID
        /// </summary>

        public class ProductCategoryTable: DatabaseTable {
            
            public ProductCategoryTable(IDataProvider provider):base("ProductCategory",provider){
                ClassName = "ProductCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductCategoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CategoryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn ProductCategoryID{
                get{
                    return this.GetColumn("ProductCategoryID");
                }
            }
            				
   			public static string ProductCategoryIDColumn{
			      get{
        			return "ProductCategoryID";
      			}
		    }
           
            public IColumn CategoryName{
                get{
                    return this.GetColumn("CategoryName");
                }
            }
            				
   			public static string CategoryNameColumn{
			      get{
        			return "CategoryName";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductImages
        /// Primary Key: ProductImageID
        /// </summary>

        public class ProductImagesTable: DatabaseTable {
            
            public ProductImagesTable(IDataProvider provider):base("ProductImages",provider){
                ClassName = "ProductImage";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductImageID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImagePath", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
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
                    
                
                
            }
            
            public IColumn ProductImageID{
                get{
                    return this.GetColumn("ProductImageID");
                }
            }
            				
   			public static string ProductImageIDColumn{
			      get{
        			return "ProductImageID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn ImagePath{
                get{
                    return this.GetColumn("ImagePath");
                }
            }
            				
   			public static string ImagePathColumn{
			      get{
        			return "ImagePath";
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
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Username", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
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
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
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
        /// Table: Product
        /// Primary Key: ProductID
        /// </summary>

        public class ProductTable: DatabaseTable {
            
            public ProductTable(IDataProvider provider):base("Product",provider){
                ClassName = "Product";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductCategoryID", this)
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
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("ShortDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
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

                Columns.Add(new DatabaseColumn("Thumbnail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
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
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn ProductCategoryID{
                get{
                    return this.GetColumn("ProductCategoryID");
                }
            }
            				
   			public static string ProductCategoryIDColumn{
			      get{
        			return "ProductCategoryID";
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
           
            public IColumn ShortDescription{
                get{
                    return this.GetColumn("ShortDescription");
                }
            }
            				
   			public static string ShortDescriptionColumn{
			      get{
        			return "ShortDescription";
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
           
            public IColumn Thumbnail{
                get{
                    return this.GetColumn("Thumbnail");
                }
            }
            				
   			public static string ThumbnailColumn{
			      get{
        			return "Thumbnail";
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
        
}