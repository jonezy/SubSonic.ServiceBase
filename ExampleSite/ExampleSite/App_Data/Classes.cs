


using System;
using System.ComponentModel;
using System.Linq;

namespace ExampleSite.Data
{
    
    
    
    
    /// <summary>
    /// A class which represents the UserImage table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserImage 
    /// </summary>

	public partial class UserImage: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserImage(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserImageIDChanging(int value);
        partial void OnUserImageIDChanged();
		
		private int _UserImageID;
		public int UserImageID { 
		    get{
		        return _UserImageID;
		    } 
		    set{
		        this.OnUserImageIDChanging(value);
                this.SendPropertyChanging();
                this._UserImageID = value;
                this.SendPropertyChanged("UserImageID");
                this.OnUserImageIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
		
		private int _UserID;
		public int UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnImageNameChanging(string value);
        partial void OnImageNameChanged();
		
		private string _ImageName;
		public string ImageName { 
		    get{
		        return _ImageName;
		    } 
		    set{
		        this.OnImageNameChanging(value);
                this.SendPropertyChanging();
                this._ImageName = value;
                this.SendPropertyChanged("ImageName");
                this.OnImageNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Users
                       where items.UserID == _UserID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the UserProfile table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfile 
    /// </summary>

	public partial class UserProfile: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfile(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileIDChanging(int value);
        partial void OnUserProfileIDChanged();
		
		private int _UserProfileID;
		public int UserProfileID { 
		    get{
		        return _UserProfileID;
		    } 
		    set{
		        this.OnUserProfileIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileID = value;
                this.SendPropertyChanged("UserProfileID");
                this.OnUserProfileIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
		
		private int _UserID;
		public int UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
		
		private string _FirstName;
		public string FirstName { 
		    get{
		        return _FirstName;
		    } 
		    set{
		        this.OnFirstNameChanging(value);
                this.SendPropertyChanging();
                this._FirstName = value;
                this.SendPropertyChanged("FirstName");
                this.OnFirstNameChanged();
		    }
		}
		
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
		
		private string _LastName;
		public string LastName { 
		    get{
		        return _LastName;
		    } 
		    set{
		        this.OnLastNameChanging(value);
                this.SendPropertyChanging();
                this._LastName = value;
                this.SendPropertyChanged("LastName");
                this.OnLastNameChanged();
		    }
		}
		
        partial void OnGenderChanging(string value);
        partial void OnGenderChanged();
		
		private string _Gender;
		public string Gender { 
		    get{
		        return _Gender;
		    } 
		    set{
		        this.OnGenderChanging(value);
                this.SendPropertyChanging();
                this._Gender = value;
                this.SendPropertyChanged("Gender");
                this.OnGenderChanged();
		    }
		}
		
        partial void OnDateOfBirthChanging(DateTime? value);
        partial void OnDateOfBirthChanged();
		
		private DateTime? _DateOfBirth;
		public DateTime? DateOfBirth { 
		    get{
		        return _DateOfBirth;
		    } 
		    set{
		        this.OnDateOfBirthChanging(value);
                this.SendPropertyChanging();
                this._DateOfBirth = value;
                this.SendPropertyChanged("DateOfBirth");
                this.OnDateOfBirthChanged();
		    }
		}
		
        partial void OnMeansToYouChanging(string value);
        partial void OnMeansToYouChanged();
		
		private string _MeansToYou;
		public string MeansToYou { 
		    get{
		        return _MeansToYou;
		    } 
		    set{
		        this.OnMeansToYouChanging(value);
                this.SendPropertyChanging();
                this._MeansToYou = value;
                this.SendPropertyChanged("MeansToYou");
                this.OnMeansToYouChanged();
		    }
		}
		
        partial void OnProfileImageChanging(string value);
        partial void OnProfileImageChanged();
		
		private string _ProfileImage;
		public string ProfileImage { 
		    get{
		        return _ProfileImage;
		    } 
		    set{
		        this.OnProfileImageChanging(value);
                this.SendPropertyChanging();
                this._ProfileImage = value;
                this.SendPropertyChanged("ProfileImage");
                this.OnProfileImageChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Users
                       where items.UserID == _UserID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the News table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.News 
    /// </summary>

	public partial class News: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public News(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnNewsIDChanging(int value);
        partial void OnNewsIDChanged();
		
		private int _NewsID;
		public int NewsID { 
		    get{
		        return _NewsID;
		    } 
		    set{
		        this.OnNewsIDChanging(value);
                this.SendPropertyChanging();
                this._NewsID = value;
                this.SendPropertyChanged("NewsID");
                this.OnNewsIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
		
		private int _UserID;
		public int UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnDateChanging(DateTime value);
        partial void OnDateChanged();
		
		private DateTime _Date;
		public DateTime Date { 
		    get{
		        return _Date;
		    } 
		    set{
		        this.OnDateChanging(value);
                this.SendPropertyChanging();
                this._Date = value;
                this.SendPropertyChanged("Date");
                this.OnDateChanged();
		    }
		}
		
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
		
		private string _Title;
		public string Title { 
		    get{
		        return _Title;
		    } 
		    set{
		        this.OnTitleChanging(value);
                this.SendPropertyChanging();
                this._Title = value;
                this.SendPropertyChanged("Title");
                this.OnTitleChanged();
		    }
		}
		
        partial void OnSummaryChanging(string value);
        partial void OnSummaryChanged();
		
		private string _Summary;
		public string Summary { 
		    get{
		        return _Summary;
		    } 
		    set{
		        this.OnSummaryChanging(value);
                this.SendPropertyChanging();
                this._Summary = value;
                this.SendPropertyChanged("Summary");
                this.OnSummaryChanged();
		    }
		}
		
        partial void OnArticleChanging(string value);
        partial void OnArticleChanged();
		
		private string _Article;
		public string Article { 
		    get{
		        return _Article;
		    } 
		    set{
		        this.OnArticleChanging(value);
                this.SendPropertyChanging();
                this._Article = value;
                this.SendPropertyChanged("Article");
                this.OnArticleChanged();
		    }
		}
		
        partial void OnAttachmentChanging(string value);
        partial void OnAttachmentChanged();
		
		private string _Attachment;
		public string Attachment { 
		    get{
		        return _Attachment;
		    } 
		    set{
		        this.OnAttachmentChanging(value);
                this.SendPropertyChanging();
                this._Attachment = value;
                this.SendPropertyChanged("Attachment");
                this.OnAttachmentChanged();
		    }
		}
		
        partial void OnIsActiveChanging(bool value);
        partial void OnIsActiveChanged();
		
		private bool _IsActive;
		public bool IsActive { 
		    get{
		        return _IsActive;
		    } 
		    set{
		        this.OnIsActiveChanging(value);
                this.SendPropertyChanging();
                this._IsActive = value;
                this.SendPropertyChanged("IsActive");
                this.OnIsActiveChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Users
                       where items.UserID == _UserID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductCategory table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.ProductCategory 
    /// </summary>

	public partial class ProductCategory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductCategory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductCategoryIDChanging(int value);
        partial void OnProductCategoryIDChanged();
		
		private int _ProductCategoryID;
		public int ProductCategoryID { 
		    get{
		        return _ProductCategoryID;
		    } 
		    set{
		        this.OnProductCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._ProductCategoryID = value;
                this.SendPropertyChanged("ProductCategoryID");
                this.OnProductCategoryIDChanged();
		    }
		}
		
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
		
		private string _CategoryName;
		public string CategoryName { 
		    get{
		        return _CategoryName;
		    } 
		    set{
		        this.OnCategoryNameChanging(value);
                this.SendPropertyChanging();
                this._CategoryName = value;
                this.SendPropertyChanged("CategoryName");
                this.OnCategoryNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Products
                       where items.ProductCategoryID == _ProductCategoryID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductImages table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.ProductImage 
    /// </summary>

	public partial class ProductImage: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductImage(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductImageIDChanging(int value);
        partial void OnProductImageIDChanged();
		
		private int _ProductImageID;
		public int ProductImageID { 
		    get{
		        return _ProductImageID;
		    } 
		    set{
		        this.OnProductImageIDChanging(value);
                this.SendPropertyChanging();
                this._ProductImageID = value;
                this.SendPropertyChanged("ProductImageID");
                this.OnProductImageIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnImagePathChanging(string value);
        partial void OnImagePathChanged();
		
		private string _ImagePath;
		public string ImagePath { 
		    get{
		        return _ImagePath;
		    } 
		    set{
		        this.OnImagePathChanging(value);
                this.SendPropertyChanging();
                this._ImagePath = value;
                this.SendPropertyChanged("ImagePath");
                this.OnImagePathChanged();
		    }
		}
		
        partial void OnIsFeaturedChanging(bool value);
        partial void OnIsFeaturedChanged();
		
		private bool _IsFeatured;
		public bool IsFeatured { 
		    get{
		        return _IsFeatured;
		    } 
		    set{
		        this.OnIsFeaturedChanging(value);
                this.SendPropertyChanging();
                this._IsFeatured = value;
                this.SendPropertyChanged("IsFeatured");
                this.OnIsFeaturedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the User table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.User 
    /// </summary>

	public partial class User: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public User(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
		
		private int _UserID;
		public int UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnUserRoleIDChanging(int value);
        partial void OnUserRoleIDChanged();
		
		private int _UserRoleID;
		public int UserRoleID { 
		    get{
		        return _UserRoleID;
		    } 
		    set{
		        this.OnUserRoleIDChanging(value);
                this.SendPropertyChanging();
                this._UserRoleID = value;
                this.SendPropertyChanged("UserRoleID");
                this.OnUserRoleIDChanged();
		    }
		}
		
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
		
		private string _Username;
		public string Username { 
		    get{
		        return _Username;
		    } 
		    set{
		        this.OnUsernameChanging(value);
                this.SendPropertyChanging();
                this._Username = value;
                this.SendPropertyChanged("Username");
                this.OnUsernameChanged();
		    }
		}
		
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
		
		private string _Password;
		public string Password { 
		    get{
		        return _Password;
		    } 
		    set{
		        this.OnPasswordChanging(value);
                this.SendPropertyChanging();
                this._Password = value;
                this.SendPropertyChanged("Password");
                this.OnPasswordChanged();
		    }
		}
		
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
		
		private string _Email;
		public string Email { 
		    get{
		        return _Email;
		    } 
		    set{
		        this.OnEmailChanging(value);
                this.SendPropertyChanging();
                this._Email = value;
                this.SendPropertyChanged("Email");
                this.OnEmailChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime value);
        partial void OnCreatedDateChanged();
		
		private DateTime _CreatedDate;
		public DateTime CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnResetVerificationChanging(Guid? value);
        partial void OnResetVerificationChanged();
		
		private Guid? _ResetVerification;
		public Guid? ResetVerification { 
		    get{
		        return _ResetVerification;
		    } 
		    set{
		        this.OnResetVerificationChanging(value);
                this.SendPropertyChanging();
                this._ResetVerification = value;
                this.SendPropertyChanged("ResetVerification");
                this.OnResetVerificationChanged();
		    }
		}
		
        partial void OnIsActiveChanging(bool value);
        partial void OnIsActiveChanged();
		
		private bool _IsActive;
		public bool IsActive { 
		    get{
		        return _IsActive;
		    } 
		    set{
		        this.OnIsActiveChanging(value);
                this.SendPropertyChanging();
                this._IsActive = value;
                this.SendPropertyChanged("IsActive");
                this.OnIsActiveChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<News> News
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.News
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<UserAuthorization> UserAuthorizations
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserAuthorizations
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<UserImage> UserImages
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserImages
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<UserProfile> UserProfiles
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfiles
                       where items.UserID == _UserID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Product table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Product 
    /// </summary>

	public partial class Product: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Product(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnProductCategoryIDChanging(int value);
        partial void OnProductCategoryIDChanged();
		
		private int _ProductCategoryID;
		public int ProductCategoryID { 
		    get{
		        return _ProductCategoryID;
		    } 
		    set{
		        this.OnProductCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._ProductCategoryID = value;
                this.SendPropertyChanged("ProductCategoryID");
                this.OnProductCategoryIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnShortDescriptionChanging(string value);
        partial void OnShortDescriptionChanged();
		
		private string _ShortDescription;
		public string ShortDescription { 
		    get{
		        return _ShortDescription;
		    } 
		    set{
		        this.OnShortDescriptionChanging(value);
                this.SendPropertyChanging();
                this._ShortDescription = value;
                this.SendPropertyChanged("ShortDescription");
                this.OnShortDescriptionChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnThumbnailChanging(string value);
        partial void OnThumbnailChanged();
		
		private string _Thumbnail;
		public string Thumbnail { 
		    get{
		        return _Thumbnail;
		    } 
		    set{
		        this.OnThumbnailChanging(value);
                this.SendPropertyChanging();
                this._Thumbnail = value;
                this.SendPropertyChanged("Thumbnail");
                this.OnThumbnailChanged();
		    }
		}
		
        partial void OnIsActiveChanging(bool value);
        partial void OnIsActiveChanged();
		
		private bool _IsActive;
		public bool IsActive { 
		    get{
		        return _IsActive;
		    } 
		    set{
		        this.OnIsActiveChanging(value);
                this.SendPropertyChanging();
                this._IsActive = value;
                this.SendPropertyChanged("IsActive");
                this.OnIsActiveChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductImage> ProductImages
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.ProductImages
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductCategory> ProductCategories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.ProductCategories
                       where items.ProductCategoryID == _ProductCategoryID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the UserAuthorization table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserAuthorization 
    /// </summary>

	public partial class UserAuthorization: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserAuthorization(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserAuthorizationIDChanging(int value);
        partial void OnUserAuthorizationIDChanged();
		
		private int _UserAuthorizationID;
		public int UserAuthorizationID { 
		    get{
		        return _UserAuthorizationID;
		    } 
		    set{
		        this.OnUserAuthorizationIDChanging(value);
                this.SendPropertyChanging();
                this._UserAuthorizationID = value;
                this.SendPropertyChanged("UserAuthorizationID");
                this.OnUserAuthorizationIDChanged();
		    }
		}
		
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
		
		private int _UserID;
		public int UserID { 
		    get{
		        return _UserID;
		    } 
		    set{
		        this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._UserID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
		    }
		}
		
        partial void OnServiceChanging(string value);
        partial void OnServiceChanged();
		
		private string _Service;
		public string Service { 
		    get{
		        return _Service;
		    } 
		    set{
		        this.OnServiceChanging(value);
                this.SendPropertyChanging();
                this._Service = value;
                this.SendPropertyChanged("Service");
                this.OnServiceChanged();
		    }
		}
		
        partial void OnScreenNameChanging(string value);
        partial void OnScreenNameChanged();
		
		private string _ScreenName;
		public string ScreenName { 
		    get{
		        return _ScreenName;
		    } 
		    set{
		        this.OnScreenNameChanging(value);
                this.SendPropertyChanging();
                this._ScreenName = value;
                this.SendPropertyChanged("ScreenName");
                this.OnScreenNameChanged();
		    }
		}
		
        partial void OnTokenChanging(string value);
        partial void OnTokenChanged();
		
		private string _Token;
		public string Token { 
		    get{
		        return _Token;
		    } 
		    set{
		        this.OnTokenChanging(value);
                this.SendPropertyChanging();
                this._Token = value;
                this.SendPropertyChanged("Token");
                this.OnTokenChanged();
		    }
		}
		
        partial void OnTokenSecretChanging(string value);
        partial void OnTokenSecretChanged();
		
		private string _TokenSecret;
		public string TokenSecret { 
		    get{
		        return _TokenSecret;
		    } 
		    set{
		        this.OnTokenSecretChanging(value);
                this.SendPropertyChanging();
                this._TokenSecret = value;
                this.SendPropertyChanged("TokenSecret");
                this.OnTokenSecretChanged();
		    }
		}
		
        partial void OnIsLoginAccountChanging(bool? value);
        partial void OnIsLoginAccountChanged();
		
		private bool? _IsLoginAccount;
		public bool? IsLoginAccount { 
		    get{
		        return _IsLoginAccount;
		    } 
		    set{
		        this.OnIsLoginAccountChanging(value);
                this.SendPropertyChanging();
                this._IsLoginAccount = value;
                this.SendPropertyChanged("IsLoginAccount");
                this.OnIsLoginAccountChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<User> Users
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Users
                       where items.UserID == _UserID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
}