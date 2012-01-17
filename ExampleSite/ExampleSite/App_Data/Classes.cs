


using System;
using System.ComponentModel;
using System.Linq;

namespace ExampleSite.Data
{
    
    
    
    
    /// <summary>
    /// A class which represents the Country table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Country 
    /// </summary>

	public partial class Country: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Country(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCountryIdChanging(int value);
        partial void OnCountryIdChanged();
		
		private int _CountryId;
		public int CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
		
		private string _Code;
		public string Code { 
		    get{
		        return _Code;
		    } 
		    set{
		        this.OnCodeChanging(value);
                this.SendPropertyChanging();
                this._Code = value;
                this.SendPropertyChanged("Code");
                this.OnCodeChanged();
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
		
        partial void OnPhoneCodeChanging(string value);
        partial void OnPhoneCodeChanged();
		
		private string _PhoneCode;
		public string PhoneCode { 
		    get{
		        return _PhoneCode;
		    } 
		    set{
		        this.OnPhoneCodeChanging(value);
                this.SendPropertyChanging();
                this._PhoneCode = value;
                this.SendPropertyChanged("PhoneCode");
                this.OnPhoneCodeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<DailyDealSubscriber> DailyDealSubscribers
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DailyDealSubscribers
                       where items.Country == _CountryId
                       select items;
            }
        }

        public IQueryable<StateOrRegion> StateOrRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.StateOrRegions
                       where items.CountryId == _CountryId
                       select items;
            }
        }

        public IQueryable<UserDetail> UserDetails
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserDetails
                       where items.Country == _CountryId
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Vendors
                       where items.Country == _CountryId
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
    /// A class which represents the Contest table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Contest 
    /// </summary>

	public partial class Contest: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Contest(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnContestIDChanging(int value);
        partial void OnContestIDChanged();
		
		private int _ContestID;
		public int ContestID { 
		    get{
		        return _ContestID;
		    } 
		    set{
		        this.OnContestIDChanging(value);
                this.SendPropertyChanging();
                this._ContestID = value;
                this.SendPropertyChanged("ContestID");
                this.OnContestIDChanged();
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
		
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
		
		private string _EmailAddress;
		public string EmailAddress { 
		    get{
		        return _EmailAddress;
		    } 
		    set{
		        this.OnEmailAddressChanging(value);
                this.SendPropertyChanging();
                this._EmailAddress = value;
                this.SendPropertyChanged("EmailAddress");
                this.OnEmailAddressChanged();
		    }
		}
		
        partial void OnAgreedToTermsChanging(bool value);
        partial void OnAgreedToTermsChanged();
		
		private bool _AgreedToTerms;
		public bool AgreedToTerms { 
		    get{
		        return _AgreedToTerms;
		    } 
		    set{
		        this.OnAgreedToTermsChanging(value);
                this.SendPropertyChanging();
                this._AgreedToTerms = value;
                this.SendPropertyChanged("AgreedToTerms");
                this.OnAgreedToTermsChanged();
		    }
		}
		
        partial void OnKeepUpdatedChanging(bool value);
        partial void OnKeepUpdatedChanged();
		
		private bool _KeepUpdated;
		public bool KeepUpdated { 
		    get{
		        return _KeepUpdated;
		    } 
		    set{
		        this.OnKeepUpdatedChanging(value);
                this.SendPropertyChanging();
                this._KeepUpdated = value;
                this.SendPropertyChanged("KeepUpdated");
                this.OnKeepUpdatedChanged();
		    }
		}
		
        partial void OnTimeStampChanging(DateTime value);
        partial void OnTimeStampChanged();
		
		private DateTime _TimeStamp;
		public DateTime TimeStamp { 
		    get{
		        return _TimeStamp;
		    } 
		    set{
		        this.OnTimeStampChanging(value);
                this.SendPropertyChanging();
                this._TimeStamp = value;
                this.SendPropertyChanged("TimeStamp");
                this.OnTimeStampChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
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
    /// A class which represents the City table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.City 
    /// </summary>

	public partial class City: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public City(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCityIdChanging(int value);
        partial void OnCityIdChanged();
		
		private int _CityId;
		public int CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
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
		
        partial void OnProvChanging(string value);
        partial void OnProvChanged();
		
		private string _Prov;
		public string Prov { 
		    get{
		        return _Prov;
		    } 
		    set{
		        this.OnProvChanging(value);
                this.SendPropertyChanging();
                this._Prov = value;
                this.SendPropertyChanged("Prov");
                this.OnProvChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserDetail> UserDetails
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserDetails
                       where items.City == _CityId
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Vendors
                       where items.City == _CityId
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
    /// A class which represents the UserProfileCategories table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfileCategory 
    /// </summary>

	public partial class UserProfileCategory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfileCategory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileCategoryIDChanging(int value);
        partial void OnUserProfileCategoryIDChanged();
		
		private int _UserProfileCategoryID;
		public int UserProfileCategoryID { 
		    get{
		        return _UserProfileCategoryID;
		    } 
		    set{
		        this.OnUserProfileCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileCategoryID = value;
                this.SendPropertyChanged("UserProfileCategoryID");
                this.OnUserProfileCategoryIDChanged();
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
		
        partial void OnUserProfileMetaCategoryIDChanging(int value);
        partial void OnUserProfileMetaCategoryIDChanged();
		
		private int _UserProfileMetaCategoryID;
		public int UserProfileMetaCategoryID { 
		    get{
		        return _UserProfileMetaCategoryID;
		    } 
		    set{
		        this.OnUserProfileMetaCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileMetaCategoryID = value;
                this.SendPropertyChanged("UserProfileMetaCategoryID");
                this.OnUserProfileMetaCategoryIDChanged();
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

        public IQueryable<UserProfileMetaCategory> UserProfileMetaCategories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileMetaCategories
                       where items.UserProfileMetaCategoryID == _UserProfileMetaCategoryID
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
    /// A class which represents the DealCategory table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.DealCategory 
    /// </summary>

	public partial class DealCategory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public DealCategory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDealCategoryIDChanging(int value);
        partial void OnDealCategoryIDChanged();
		
		private int _DealCategoryID;
		public int DealCategoryID { 
		    get{
		        return _DealCategoryID;
		    } 
		    set{
		        this.OnDealCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._DealCategoryID = value;
                this.SendPropertyChanged("DealCategoryID");
                this.OnDealCategoryIDChanged();
		    }
		}
		
        partial void OnCateogryNameChanging(string value);
        partial void OnCateogryNameChanged();
		
		private string _CateogryName;
		public string CateogryName { 
		    get{
		        return _CateogryName;
		    } 
		    set{
		        this.OnCateogryNameChanging(value);
                this.SendPropertyChanging();
                this._CateogryName = value;
                this.SendPropertyChanged("CateogryName");
                this.OnCateogryNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Deal> Deals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Deals
                       where items.CategoryID == _DealCategoryID
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
    /// A class which represents the UserProfileMetaCategory table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfileMetaCategory 
    /// </summary>

	public partial class UserProfileMetaCategory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfileMetaCategory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileMetaCategoryIDChanging(int value);
        partial void OnUserProfileMetaCategoryIDChanged();
		
		private int _UserProfileMetaCategoryID;
		public int UserProfileMetaCategoryID { 
		    get{
		        return _UserProfileMetaCategoryID;
		    } 
		    set{
		        this.OnUserProfileMetaCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileMetaCategoryID = value;
                this.SendPropertyChanged("UserProfileMetaCategoryID");
                this.OnUserProfileMetaCategoryIDChanged();
		    }
		}
		
        partial void OnParentIDChanging(int? value);
        partial void OnParentIDChanged();
		
		private int? _ParentID;
		public int? ParentID { 
		    get{
		        return _ParentID;
		    } 
		    set{
		        this.OnParentIDChanging(value);
                this.SendPropertyChanging();
                this._ParentID = value;
                this.SendPropertyChanged("ParentID");
                this.OnParentIDChanged();
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
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserProfileCategory> UserProfileCategories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileCategories
                       where items.UserProfileMetaCategoryID == _UserProfileMetaCategoryID
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
    /// A class which represents the StateOrRegion table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.StateOrRegion 
    /// </summary>

	public partial class StateOrRegion: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public StateOrRegion(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnStateOrRegionIdChanging(int value);
        partial void OnStateOrRegionIdChanged();
		
		private int _StateOrRegionId;
		public int StateOrRegionId { 
		    get{
		        return _StateOrRegionId;
		    } 
		    set{
		        this.OnStateOrRegionIdChanging(value);
                this.SendPropertyChanging();
                this._StateOrRegionId = value;
                this.SendPropertyChanged("StateOrRegionId");
                this.OnStateOrRegionIdChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int value);
        partial void OnCountryIdChanged();
		
		private int _CountryId;
		public int CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
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
		
        partial void OnAbbreviationChanging(string value);
        partial void OnAbbreviationChanged();
		
		private string _Abbreviation;
		public string Abbreviation { 
		    get{
		        return _Abbreviation;
		    } 
		    set{
		        this.OnAbbreviationChanging(value);
                this.SendPropertyChanging();
                this._Abbreviation = value;
                this.SendPropertyChanged("Abbreviation");
                this.OnAbbreviationChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Country> Countries
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Countries
                       where items.CountryId == _CountryId
                       select items;
            }
        }

        public IQueryable<DailyDealSubscriber> DailyDealSubscribers
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DailyDealSubscribers
                       where items.StateOrRegion == _StateOrRegionId
                       select items;
            }
        }

        public IQueryable<Region> Regions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Regions
                       where items.StateOrRegionID == _StateOrRegionId
                       select items;
            }
        }

        public IQueryable<UserDetail> UserDetails
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserDetails
                       where items.StateOrProvince == _StateOrRegionId
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Vendors
                       where items.StateOrProvince == _StateOrRegionId
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
    /// A class which represents the UserProfileMetaEducation table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfileMetaEducation 
    /// </summary>

	public partial class UserProfileMetaEducation: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfileMetaEducation(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileMetaEducationIDChanging(int value);
        partial void OnUserProfileMetaEducationIDChanged();
		
		private int _UserProfileMetaEducationID;
		public int UserProfileMetaEducationID { 
		    get{
		        return _UserProfileMetaEducationID;
		    } 
		    set{
		        this.OnUserProfileMetaEducationIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileMetaEducationID = value;
                this.SendPropertyChanged("UserProfileMetaEducationID");
                this.OnUserProfileMetaEducationIDChanged();
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
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserProfile> UserProfiles
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfiles
                       where items.UserProfileID == _UserProfileMetaEducationID
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
    /// A class which represents the DailyDealSubscriber table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.DailyDealSubscriber 
    /// </summary>

	public partial class DailyDealSubscriber: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public DailyDealSubscriber(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDailyDealSubscriberIDChanging(int value);
        partial void OnDailyDealSubscriberIDChanged();
		
		private int _DailyDealSubscriberID;
		public int DailyDealSubscriberID { 
		    get{
		        return _DailyDealSubscriberID;
		    } 
		    set{
		        this.OnDailyDealSubscriberIDChanging(value);
                this.SendPropertyChanging();
                this._DailyDealSubscriberID = value;
                this.SendPropertyChanged("DailyDealSubscriberID");
                this.OnDailyDealSubscriberIDChanged();
		    }
		}
		
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
		
		private string _EmailAddress;
		public string EmailAddress { 
		    get{
		        return _EmailAddress;
		    } 
		    set{
		        this.OnEmailAddressChanging(value);
                this.SendPropertyChanging();
                this._EmailAddress = value;
                this.SendPropertyChanged("EmailAddress");
                this.OnEmailAddressChanged();
		    }
		}
		
        partial void OnCountryChanging(int? value);
        partial void OnCountryChanged();
		
		private int? _Country;
		public int? Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateOrRegionChanging(int? value);
        partial void OnStateOrRegionChanged();
		
		private int? _StateOrRegion;
		public int? StateOrRegion { 
		    get{
		        return _StateOrRegion;
		    } 
		    set{
		        this.OnStateOrRegionChanging(value);
                this.SendPropertyChanging();
                this._StateOrRegion = value;
                this.SendPropertyChanged("StateOrRegion");
                this.OnStateOrRegionChanged();
		    }
		}
		
        partial void OnCreationDateChanging(DateTime value);
        partial void OnCreationDateChanged();
		
		private DateTime _CreationDate;
		public DateTime CreationDate { 
		    get{
		        return _CreationDate;
		    } 
		    set{
		        this.OnCreationDateChanging(value);
                this.SendPropertyChanging();
                this._CreationDate = value;
                this.SendPropertyChanged("CreationDate");
                this.OnCreationDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Country> Countries
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Countries
                       where items.CountryId == _Country
                       select items;
            }
        }

        public IQueryable<StateOrRegion> StateOrRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.StateOrRegions
                       where items.StateOrRegionId == _StateOrRegion
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
    /// A class which represents the Region table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Region 
    /// </summary>

	public partial class Region: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Region(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnRegionIDChanging(int value);
        partial void OnRegionIDChanged();
		
		private int _RegionID;
		public int RegionID { 
		    get{
		        return _RegionID;
		    } 
		    set{
		        this.OnRegionIDChanging(value);
                this.SendPropertyChanging();
                this._RegionID = value;
                this.SendPropertyChanged("RegionID");
                this.OnRegionIDChanged();
		    }
		}
		
        partial void OnStateOrRegionIDChanging(int value);
        partial void OnStateOrRegionIDChanged();
		
		private int _StateOrRegionID;
		public int StateOrRegionID { 
		    get{
		        return _StateOrRegionID;
		    } 
		    set{
		        this.OnStateOrRegionIDChanging(value);
                this.SendPropertyChanging();
                this._StateOrRegionID = value;
                this.SendPropertyChanged("StateOrRegionID");
                this.OnStateOrRegionIDChanged();
		    }
		}
		
        partial void OnRegionNameChanging(string value);
        partial void OnRegionNameChanged();
		
		private string _RegionName;
		public string RegionName { 
		    get{
		        return _RegionName;
		    } 
		    set{
		        this.OnRegionNameChanging(value);
                this.SendPropertyChanging();
                this._RegionName = value;
                this.SendPropertyChanged("RegionName");
                this.OnRegionNameChanged();
		    }
		}
		
        partial void OnUrlSlugChanging(string value);
        partial void OnUrlSlugChanged();
		
		private string _UrlSlug;
		public string UrlSlug { 
		    get{
		        return _UrlSlug;
		    } 
		    set{
		        this.OnUrlSlugChanging(value);
                this.SendPropertyChanging();
                this._UrlSlug = value;
                this.SendPropertyChanged("UrlSlug");
                this.OnUrlSlugChanged();
		    }
		}
		
        partial void OnIsDefaultChanging(bool value);
        partial void OnIsDefaultChanged();
		
		private bool _IsDefault;
		public bool IsDefault { 
		    get{
		        return _IsDefault;
		    } 
		    set{
		        this.OnIsDefaultChanging(value);
                this.SendPropertyChanging();
                this._IsDefault = value;
                this.SendPropertyChanged("IsDefault");
                this.OnIsDefaultChanged();
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
        public IQueryable<DealInRegion> DealInRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DealInRegions
                       where items.RegionID == _RegionID
                       select items;
            }
        }

        public IQueryable<UserDetail> UserDetails
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserDetails
                       where items.Region == _RegionID
                       select items;
            }
        }

        public IQueryable<UserProfilePlace> UserProfilePlaces
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfilePlaces
                       where items.RegionID == _RegionID
                       select items;
            }
        }

        public IQueryable<StateOrRegion> StateOrRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.StateOrRegions
                       where items.StateOrRegionId == _StateOrRegionID
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
    /// A class which represents the UserProfileMetaEmploymentStatus table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfileMetaEmploymentStatus 
    /// </summary>

	public partial class UserProfileMetaEmploymentStatus: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfileMetaEmploymentStatus(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileMetaEmploymentStatusIDChanging(int value);
        partial void OnUserProfileMetaEmploymentStatusIDChanged();
		
		private int _UserProfileMetaEmploymentStatusID;
		public int UserProfileMetaEmploymentStatusID { 
		    get{
		        return _UserProfileMetaEmploymentStatusID;
		    } 
		    set{
		        this.OnUserProfileMetaEmploymentStatusIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileMetaEmploymentStatusID = value;
                this.SendPropertyChanged("UserProfileMetaEmploymentStatusID");
                this.OnUserProfileMetaEmploymentStatusIDChanged();
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
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserProfile> UserProfiles
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfiles
                       where items.EmploymentStatusID == _UserProfileMetaEmploymentStatusID
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
    /// A class which represents the UserCredit table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserCredit 
    /// </summary>

	public partial class UserCredit: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserCredit(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserCreditIDChanging(int value);
        partial void OnUserCreditIDChanged();
		
		private int _UserCreditID;
		public int UserCreditID { 
		    get{
		        return _UserCreditID;
		    } 
		    set{
		        this.OnUserCreditIDChanging(value);
                this.SendPropertyChanging();
                this._UserCreditID = value;
                this.SendPropertyChanged("UserCreditID");
                this.OnUserCreditIDChanged();
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
		
        partial void OnCreditsChanging(decimal value);
        partial void OnCreditsChanged();
		
		private decimal _Credits;
		public decimal Credits { 
		    get{
		        return _Credits;
		    } 
		    set{
		        this.OnCreditsChanging(value);
                this.SendPropertyChanging();
                this._Credits = value;
                this.SendPropertyChanged("Credits");
                this.OnCreditsChanged();
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
    /// A class which represents the UserProfileMetaIncome table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfileMetaIncome 
    /// </summary>

	public partial class UserProfileMetaIncome: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfileMetaIncome(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileMetaIncomeIDChanging(int value);
        partial void OnUserProfileMetaIncomeIDChanged();
		
		private int _UserProfileMetaIncomeID;
		public int UserProfileMetaIncomeID { 
		    get{
		        return _UserProfileMetaIncomeID;
		    } 
		    set{
		        this.OnUserProfileMetaIncomeIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileMetaIncomeID = value;
                this.SendPropertyChanged("UserProfileMetaIncomeID");
                this.OnUserProfileMetaIncomeIDChanged();
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
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserProfile> UserProfiles
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfiles
                       where items.IncomeID == _UserProfileMetaIncomeID
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
	
    
    
    /// <summary>
    /// A class which represents the OrderHistory table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.OrderHistory 
    /// </summary>

	public partial class OrderHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public OrderHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnOrderHistoryIDChanging(int value);
        partial void OnOrderHistoryIDChanged();
		
		private int _OrderHistoryID;
		public int OrderHistoryID { 
		    get{
		        return _OrderHistoryID;
		    } 
		    set{
		        this.OnOrderHistoryIDChanging(value);
                this.SendPropertyChanging();
                this._OrderHistoryID = value;
                this.SendPropertyChanged("OrderHistoryID");
                this.OnOrderHistoryIDChanged();
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
		
        partial void OnPayPalTransactionIDChanging(string value);
        partial void OnPayPalTransactionIDChanged();
		
		private string _PayPalTransactionID;
		public string PayPalTransactionID { 
		    get{
		        return _PayPalTransactionID;
		    } 
		    set{
		        this.OnPayPalTransactionIDChanging(value);
                this.SendPropertyChanging();
                this._PayPalTransactionID = value;
                this.SendPropertyChanged("PayPalTransactionID");
                this.OnPayPalTransactionIDChanged();
		    }
		}
		
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
		
		private decimal _Amount;
		public decimal Amount { 
		    get{
		        return _Amount;
		    } 
		    set{
		        this.OnAmountChanging(value);
                this.SendPropertyChanging();
                this._Amount = value;
                this.SendPropertyChanged("Amount");
                this.OnAmountChanged();
		    }
		}
		
        partial void OnTimeStampChanging(DateTime value);
        partial void OnTimeStampChanged();
		
		private DateTime _TimeStamp;
		public DateTime TimeStamp { 
		    get{
		        return _TimeStamp;
		    } 
		    set{
		        this.OnTimeStampChanging(value);
                this.SendPropertyChanging();
                this._TimeStamp = value;
                this.SendPropertyChanged("TimeStamp");
                this.OnTimeStampChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<PurchasedDeal> PurchasedDeals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.PurchasedDeals
                       where items.OrderHistoryID == _OrderHistoryID
                       select items;
            }
        }

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
    /// A class which represents the Cart table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Cart 
    /// </summary>

	public partial class Cart: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Cart(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCartIDChanging(int value);
        partial void OnCartIDChanged();
		
		private int _CartID;
		public int CartID { 
		    get{
		        return _CartID;
		    } 
		    set{
		        this.OnCartIDChanging(value);
                this.SendPropertyChanging();
                this._CartID = value;
                this.SendPropertyChanged("CartID");
                this.OnCartIDChanged();
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
		

        #endregion

        #region Foreign Keys
        public IQueryable<CartItem> CartItems
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.CartItems
                       where items.CartID == _CartID
                       select items;
            }
        }

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
    /// A class which represents the Vendor table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Vendor 
    /// </summary>

	public partial class Vendor: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Vendor(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnParentVendorIDChanging(int? value);
        partial void OnParentVendorIDChanged();
		
		private int? _ParentVendorID;
		public int? ParentVendorID { 
		    get{
		        return _ParentVendorID;
		    } 
		    set{
		        this.OnParentVendorIDChanging(value);
                this.SendPropertyChanging();
                this._ParentVendorID = value;
                this.SendPropertyChanged("ParentVendorID");
                this.OnParentVendorIDChanged();
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
		
        partial void OnBiographyChanging(string value);
        partial void OnBiographyChanged();
		
		private string _Biography;
		public string Biography { 
		    get{
		        return _Biography;
		    } 
		    set{
		        this.OnBiographyChanging(value);
                this.SendPropertyChanging();
                this._Biography = value;
                this.SendPropertyChanged("Biography");
                this.OnBiographyChanged();
		    }
		}
		
        partial void OnAddress1Changing(string value);
        partial void OnAddress1Changed();
		
		private string _Address1;
		public string Address1 { 
		    get{
		        return _Address1;
		    } 
		    set{
		        this.OnAddress1Changing(value);
                this.SendPropertyChanging();
                this._Address1 = value;
                this.SendPropertyChanged("Address1");
                this.OnAddress1Changed();
		    }
		}
		
        partial void OnAddress2Changing(string value);
        partial void OnAddress2Changed();
		
		private string _Address2;
		public string Address2 { 
		    get{
		        return _Address2;
		    } 
		    set{
		        this.OnAddress2Changing(value);
                this.SendPropertyChanging();
                this._Address2 = value;
                this.SendPropertyChanged("Address2");
                this.OnAddress2Changed();
		    }
		}
		
        partial void OnPostalZipChanging(string value);
        partial void OnPostalZipChanged();
		
		private string _PostalZip;
		public string PostalZip { 
		    get{
		        return _PostalZip;
		    } 
		    set{
		        this.OnPostalZipChanging(value);
                this.SendPropertyChanging();
                this._PostalZip = value;
                this.SendPropertyChanged("PostalZip");
                this.OnPostalZipChanged();
		    }
		}
		
        partial void OnCountryChanging(int value);
        partial void OnCountryChanged();
		
		private int _Country;
		public int Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateOrProvinceChanging(int value);
        partial void OnStateOrProvinceChanged();
		
		private int _StateOrProvince;
		public int StateOrProvince { 
		    get{
		        return _StateOrProvince;
		    } 
		    set{
		        this.OnStateOrProvinceChanging(value);
                this.SendPropertyChanging();
                this._StateOrProvince = value;
                this.SendPropertyChanged("StateOrProvince");
                this.OnStateOrProvinceChanged();
		    }
		}
		
        partial void OnCityChanging(int value);
        partial void OnCityChanged();
		
		private int _City;
		public int City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
		
		private string _Phone;
		public string Phone { 
		    get{
		        return _Phone;
		    } 
		    set{
		        this.OnPhoneChanging(value);
                this.SendPropertyChanging();
                this._Phone = value;
                this.SendPropertyChanged("Phone");
                this.OnPhoneChanged();
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
		
        partial void OnWebsiteChanging(string value);
        partial void OnWebsiteChanged();
		
		private string _Website;
		public string Website { 
		    get{
		        return _Website;
		    } 
		    set{
		        this.OnWebsiteChanging(value);
                this.SendPropertyChanging();
                this._Website = value;
                this.SendPropertyChanged("Website");
                this.OnWebsiteChanged();
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
        public IQueryable<City> Cities
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Cities
                       where items.CityId == _City
                       select items;
            }
        }

        public IQueryable<Country> Countries
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Countries
                       where items.CountryId == _Country
                       select items;
            }
        }

        public IQueryable<StateOrRegion> StateOrRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.StateOrRegions
                       where items.StateOrRegionId == _StateOrProvince
                       select items;
            }
        }

        public IQueryable<CartItem> CartItems
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.CartItems
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        public IQueryable<DealVendor> DealVendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DealVendors
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        public IQueryable<PurchasedDeal> PurchasedDeals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.PurchasedDeals
                       where items.VendorID == _VendorID
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
		
        partial void OnSexChanging(string value);
        partial void OnSexChanged();
		
		private string _Sex;
		public string Sex { 
		    get{
		        return _Sex;
		    } 
		    set{
		        this.OnSexChanging(value);
                this.SendPropertyChanging();
                this._Sex = value;
                this.SendPropertyChanged("Sex");
                this.OnSexChanged();
		    }
		}
		
        partial void OnAgeChanging(string value);
        partial void OnAgeChanged();
		
		private string _Age;
		public string Age { 
		    get{
		        return _Age;
		    } 
		    set{
		        this.OnAgeChanging(value);
                this.SendPropertyChanging();
                this._Age = value;
                this.SendPropertyChanged("Age");
                this.OnAgeChanged();
		    }
		}
		
        partial void OnEducationIDChanging(int? value);
        partial void OnEducationIDChanged();
		
		private int? _EducationID;
		public int? EducationID { 
		    get{
		        return _EducationID;
		    } 
		    set{
		        this.OnEducationIDChanging(value);
                this.SendPropertyChanging();
                this._EducationID = value;
                this.SendPropertyChanged("EducationID");
                this.OnEducationIDChanged();
		    }
		}
		
        partial void OnEmploymentStatusIDChanging(int? value);
        partial void OnEmploymentStatusIDChanged();
		
		private int? _EmploymentStatusID;
		public int? EmploymentStatusID { 
		    get{
		        return _EmploymentStatusID;
		    } 
		    set{
		        this.OnEmploymentStatusIDChanging(value);
                this.SendPropertyChanging();
                this._EmploymentStatusID = value;
                this.SendPropertyChanged("EmploymentStatusID");
                this.OnEmploymentStatusIDChanged();
		    }
		}
		
        partial void OnIncomeIDChanging(int? value);
        partial void OnIncomeIDChanged();
		
		private int? _IncomeID;
		public int? IncomeID { 
		    get{
		        return _IncomeID;
		    } 
		    set{
		        this.OnIncomeIDChanging(value);
                this.SendPropertyChanging();
                this._IncomeID = value;
                this.SendPropertyChanged("IncomeID");
                this.OnIncomeIDChanged();
		    }
		}
		
        partial void OnRelationshipStatusIDChanging(int? value);
        partial void OnRelationshipStatusIDChanged();
		
		private int? _RelationshipStatusID;
		public int? RelationshipStatusID { 
		    get{
		        return _RelationshipStatusID;
		    } 
		    set{
		        this.OnRelationshipStatusIDChanging(value);
                this.SendPropertyChanging();
                this._RelationshipStatusID = value;
                this.SendPropertyChanged("RelationshipStatusID");
                this.OnRelationshipStatusIDChanged();
		    }
		}
		
        partial void OnHomeOwnerChanging(bool value);
        partial void OnHomeOwnerChanged();
		
		private bool _HomeOwner;
		public bool HomeOwner { 
		    get{
		        return _HomeOwner;
		    } 
		    set{
		        this.OnHomeOwnerChanging(value);
                this.SendPropertyChanging();
                this._HomeOwner = value;
                this.SendPropertyChanged("HomeOwner");
                this.OnHomeOwnerChanged();
		    }
		}
		
        partial void OnHaveChildrenChanging(bool value);
        partial void OnHaveChildrenChanged();
		
		private bool _HaveChildren;
		public bool HaveChildren { 
		    get{
		        return _HaveChildren;
		    } 
		    set{
		        this.OnHaveChildrenChanging(value);
                this.SendPropertyChanging();
                this._HaveChildren = value;
                this.SendPropertyChanged("HaveChildren");
                this.OnHaveChildrenChanged();
		    }
		}
		
        partial void OnHavePetsChanging(bool value);
        partial void OnHavePetsChanged();
		
		private bool _HavePets;
		public bool HavePets { 
		    get{
		        return _HavePets;
		    } 
		    set{
		        this.OnHavePetsChanging(value);
                this.SendPropertyChanging();
                this._HavePets = value;
                this.SendPropertyChanged("HavePets");
                this.OnHavePetsChanged();
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

        public IQueryable<UserProfileMetaEducation> UserProfileMetaEducations
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileMetaEducations
                       where items.UserProfileMetaEducationID == _UserProfileID
                       select items;
            }
        }

        public IQueryable<UserProfileMetaEmploymentStatus> UserProfileMetaEmploymentStatuses
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileMetaEmploymentStatuses
                       where items.UserProfileMetaEmploymentStatusID == _EmploymentStatusID
                       select items;
            }
        }

        public IQueryable<UserProfileMetaIncome> UserProfileMetaIncomes
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileMetaIncomes
                       where items.UserProfileMetaIncomeID == _IncomeID
                       select items;
            }
        }

        public IQueryable<UserProfileMetaRelationshipStatus> UserProfileMetaRelationshipStatuses
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileMetaRelationshipStatuses
                       where items.UserProfileMetaRelationshipStatusID == _RelationshipStatusID
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
    /// A class which represents the UserDetail table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserDetail 
    /// </summary>

	public partial class UserDetail: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserDetail(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserDetailIDChanging(int value);
        partial void OnUserDetailIDChanged();
		
		private int _UserDetailID;
		public int UserDetailID { 
		    get{
		        return _UserDetailID;
		    } 
		    set{
		        this.OnUserDetailIDChanging(value);
                this.SendPropertyChanging();
                this._UserDetailID = value;
                this.SendPropertyChanged("UserDetailID");
                this.OnUserDetailIDChanged();
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
		
        partial void OnCountryChanging(int? value);
        partial void OnCountryChanged();
		
		private int? _Country;
		public int? Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateOrProvinceChanging(int? value);
        partial void OnStateOrProvinceChanged();
		
		private int? _StateOrProvince;
		public int? StateOrProvince { 
		    get{
		        return _StateOrProvince;
		    } 
		    set{
		        this.OnStateOrProvinceChanging(value);
                this.SendPropertyChanging();
                this._StateOrProvince = value;
                this.SendPropertyChanged("StateOrProvince");
                this.OnStateOrProvinceChanged();
		    }
		}
		
        partial void OnCityChanging(int? value);
        partial void OnCityChanged();
		
		private int? _City;
		public int? City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnRegionChanging(int? value);
        partial void OnRegionChanged();
		
		private int? _Region;
		public int? Region { 
		    get{
		        return _Region;
		    } 
		    set{
		        this.OnRegionChanging(value);
                this.SendPropertyChanging();
                this._Region = value;
                this.SendPropertyChanged("Region");
                this.OnRegionChanged();
		    }
		}
		
        partial void OnBillingAddressChanging(string value);
        partial void OnBillingAddressChanged();
		
		private string _BillingAddress;
		public string BillingAddress { 
		    get{
		        return _BillingAddress;
		    } 
		    set{
		        this.OnBillingAddressChanging(value);
                this.SendPropertyChanging();
                this._BillingAddress = value;
                this.SendPropertyChanged("BillingAddress");
                this.OnBillingAddressChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<City> Cities
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Cities
                       where items.CityId == _City
                       select items;
            }
        }

        public IQueryable<Country> Countries
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Countries
                       where items.CountryId == _Country
                       select items;
            }
        }

        public IQueryable<Region> Regions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Regions
                       where items.RegionID == _Region
                       select items;
            }
        }

        public IQueryable<StateOrRegion> StateOrRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.StateOrRegions
                       where items.StateOrRegionId == _StateOrProvince
                       select items;
            }
        }

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
    /// A class which represents the DealVendor table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.DealVendor 
    /// </summary>

	public partial class DealVendor: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public DealVendor(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDealVendorIDChanging(int value);
        partial void OnDealVendorIDChanged();
		
		private int _DealVendorID;
		public int DealVendorID { 
		    get{
		        return _DealVendorID;
		    } 
		    set{
		        this.OnDealVendorIDChanging(value);
                this.SendPropertyChanging();
                this._DealVendorID = value;
                this.SendPropertyChanged("DealVendorID");
                this.OnDealVendorIDChanged();
		    }
		}
		
        partial void OnDealIDChanging(int value);
        partial void OnDealIDChanged();
		
		private int _DealID;
		public int DealID { 
		    get{
		        return _DealID;
		    } 
		    set{
		        this.OnDealIDChanging(value);
                this.SendPropertyChanging();
                this._DealID = value;
                this.SendPropertyChanged("DealID");
                this.OnDealIDChanged();
		    }
		}
		
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Deal> Deals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Deals
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
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
    /// A class which represents the DealInRegion table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.DealInRegion 
    /// </summary>

	public partial class DealInRegion: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public DealInRegion(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDealInRegionXChanging(int value);
        partial void OnDealInRegionXChanged();
		
		private int _DealInRegionX;
		public int DealInRegionX { 
		    get{
		        return _DealInRegionX;
		    } 
		    set{
		        this.OnDealInRegionXChanging(value);
                this.SendPropertyChanging();
                this._DealInRegionX = value;
                this.SendPropertyChanged("DealInRegionX");
                this.OnDealInRegionXChanged();
		    }
		}
		
        partial void OnDealIDChanging(int value);
        partial void OnDealIDChanged();
		
		private int _DealID;
		public int DealID { 
		    get{
		        return _DealID;
		    } 
		    set{
		        this.OnDealIDChanging(value);
                this.SendPropertyChanging();
                this._DealID = value;
                this.SendPropertyChanged("DealID");
                this.OnDealIDChanged();
		    }
		}
		
        partial void OnRegionIDChanging(int value);
        partial void OnRegionIDChanged();
		
		private int _RegionID;
		public int RegionID { 
		    get{
		        return _RegionID;
		    } 
		    set{
		        this.OnRegionIDChanging(value);
                this.SendPropertyChanging();
                this._RegionID = value;
                this.SendPropertyChanged("RegionID");
                this.OnRegionIDChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Deal> Deals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Deals
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<Region> Regions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Regions
                       where items.RegionID == _RegionID
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
    /// A class which represents the PurchasedDeals table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.PurchasedDeal 
    /// </summary>

	public partial class PurchasedDeal: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public PurchasedDeal(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPurchasedDealIDChanging(int value);
        partial void OnPurchasedDealIDChanged();
		
		private int _PurchasedDealID;
		public int PurchasedDealID { 
		    get{
		        return _PurchasedDealID;
		    } 
		    set{
		        this.OnPurchasedDealIDChanging(value);
                this.SendPropertyChanging();
                this._PurchasedDealID = value;
                this.SendPropertyChanged("PurchasedDealID");
                this.OnPurchasedDealIDChanged();
		    }
		}
		
        partial void OnOrderHistoryIDChanging(int value);
        partial void OnOrderHistoryIDChanged();
		
		private int _OrderHistoryID;
		public int OrderHistoryID { 
		    get{
		        return _OrderHistoryID;
		    } 
		    set{
		        this.OnOrderHistoryIDChanging(value);
                this.SendPropertyChanging();
                this._OrderHistoryID = value;
                this.SendPropertyChanged("OrderHistoryID");
                this.OnOrderHistoryIDChanged();
		    }
		}
		
        partial void OnDealIDChanging(int value);
        partial void OnDealIDChanged();
		
		private int _DealID;
		public int DealID { 
		    get{
		        return _DealID;
		    } 
		    set{
		        this.OnDealIDChanging(value);
                this.SendPropertyChanging();
                this._DealID = value;
                this.SendPropertyChanged("DealID");
                this.OnDealIDChanged();
		    }
		}
		
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
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
		
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
		
		private int _Quantity;
		public int Quantity { 
		    get{
		        return _Quantity;
		    } 
		    set{
		        this.OnQuantityChanging(value);
                this.SendPropertyChanging();
                this._Quantity = value;
                this.SendPropertyChanged("Quantity");
                this.OnQuantityChanged();
		    }
		}
		
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
		
		private decimal _Price;
		public decimal Price { 
		    get{
		        return _Price;
		    } 
		    set{
		        this.OnPriceChanging(value);
                this.SendPropertyChanging();
                this._Price = value;
                this.SendPropertyChanged("Price");
                this.OnPriceChanged();
		    }
		}
		
        partial void OnSerialNumberChanging(string value);
        partial void OnSerialNumberChanged();
		
		private string _SerialNumber;
		public string SerialNumber { 
		    get{
		        return _SerialNumber;
		    } 
		    set{
		        this.OnSerialNumberChanging(value);
                this.SendPropertyChanging();
                this._SerialNumber = value;
                this.SendPropertyChanged("SerialNumber");
                this.OnSerialNumberChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Deal> Deals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Deals
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<OrderHistory> OrderHistories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.OrderHistories
                       where items.OrderHistoryID == _OrderHistoryID
                       select items;
            }
        }

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

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
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
    /// A class which represents the CartItem table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.CartItem 
    /// </summary>

	public partial class CartItem: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public CartItem(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCartItemIDChanging(int value);
        partial void OnCartItemIDChanged();
		
		private int _CartItemID;
		public int CartItemID { 
		    get{
		        return _CartItemID;
		    } 
		    set{
		        this.OnCartItemIDChanging(value);
                this.SendPropertyChanging();
                this._CartItemID = value;
                this.SendPropertyChanged("CartItemID");
                this.OnCartItemIDChanged();
		    }
		}
		
        partial void OnCartIDChanging(int value);
        partial void OnCartIDChanged();
		
		private int _CartID;
		public int CartID { 
		    get{
		        return _CartID;
		    } 
		    set{
		        this.OnCartIDChanging(value);
                this.SendPropertyChanging();
                this._CartID = value;
                this.SendPropertyChanged("CartID");
                this.OnCartIDChanged();
		    }
		}
		
        partial void OnDealIDChanging(int value);
        partial void OnDealIDChanged();
		
		private int _DealID;
		public int DealID { 
		    get{
		        return _DealID;
		    } 
		    set{
		        this.OnDealIDChanging(value);
                this.SendPropertyChanging();
                this._DealID = value;
                this.SendPropertyChanged("DealID");
                this.OnDealIDChanged();
		    }
		}
		
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnQtyChanging(int value);
        partial void OnQtyChanged();
		
		private int _Qty;
		public int Qty { 
		    get{
		        return _Qty;
		    } 
		    set{
		        this.OnQtyChanging(value);
                this.SendPropertyChanging();
                this._Qty = value;
                this.SendPropertyChanged("Qty");
                this.OnQtyChanged();
		    }
		}
		
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
		
		private decimal _Price;
		public decimal Price { 
		    get{
		        return _Price;
		    } 
		    set{
		        this.OnPriceChanging(value);
                this.SendPropertyChanging();
                this._Price = value;
                this.SendPropertyChanged("Price");
                this.OnPriceChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Cart> Carts
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Carts
                       where items.CartID == _CartID
                       select items;
            }
        }

        public IQueryable<Deal> Deals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Deals
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
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
    /// A class which represents the UserProfilePlaces table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfilePlace 
    /// </summary>

	public partial class UserProfilePlace: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfilePlace(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfilePlacesIDChanging(int value);
        partial void OnUserProfilePlacesIDChanged();
		
		private int _UserProfilePlacesID;
		public int UserProfilePlacesID { 
		    get{
		        return _UserProfilePlacesID;
		    } 
		    set{
		        this.OnUserProfilePlacesIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfilePlacesID = value;
                this.SendPropertyChanged("UserProfilePlacesID");
                this.OnUserProfilePlacesIDChanged();
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
		
        partial void OnRegionIDChanging(int value);
        partial void OnRegionIDChanged();
		
		private int _RegionID;
		public int RegionID { 
		    get{
		        return _RegionID;
		    } 
		    set{
		        this.OnRegionIDChanging(value);
                this.SendPropertyChanging();
                this._RegionID = value;
                this.SendPropertyChanged("RegionID");
                this.OnRegionIDChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Region> Regions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Regions
                       where items.RegionID == _RegionID
                       select items;
            }
        }

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
    /// A class which represents the Html table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Html 
    /// </summary>

	public partial class Html: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Html(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnHtmlIDChanging(int value);
        partial void OnHtmlIDChanged();
		
		private int _HtmlID;
		public int HtmlID { 
		    get{
		        return _HtmlID;
		    } 
		    set{
		        this.OnHtmlIDChanging(value);
                this.SendPropertyChanging();
                this._HtmlID = value;
                this.SendPropertyChanged("HtmlID");
                this.OnHtmlIDChanged();
		    }
		}
		
        partial void OnSlugChanging(string value);
        partial void OnSlugChanged();
		
		private string _Slug;
		public string Slug { 
		    get{
		        return _Slug;
		    } 
		    set{
		        this.OnSlugChanging(value);
                this.SendPropertyChanging();
                this._Slug = value;
                this.SendPropertyChanged("Slug");
                this.OnSlugChanged();
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
		
        partial void OnHtmlTextChanging(string value);
        partial void OnHtmlTextChanged();
		
		private string _HtmlText;
		public string HtmlText { 
		    get{
		        return _HtmlText;
		    } 
		    set{
		        this.OnHtmlTextChanging(value);
                this.SendPropertyChanging();
                this._HtmlText = value;
                this.SendPropertyChanged("HtmlText");
                this.OnHtmlTextChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
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
		
        partial void OnCreationDateChanging(DateTime value);
        partial void OnCreationDateChanged();
		
		private DateTime _CreationDate;
		public DateTime CreationDate { 
		    get{
		        return _CreationDate;
		    } 
		    set{
		        this.OnCreationDateChanging(value);
                this.SendPropertyChanging();
                this._CreationDate = value;
                this.SendPropertyChanged("CreationDate");
                this.OnCreationDateChanged();
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
        public IQueryable<Cart> Carts
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.Carts
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<PurchasedDeal> PurchasedDeals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.PurchasedDeals
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<OrderHistory> OrderHistories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.OrderHistories
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

        public IQueryable<UserCredit> UserCredits
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserCredits
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<UserDetail> UserDetails
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserDetails
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

        public IQueryable<UserProfileCategory> UserProfileCategories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfileCategories
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<UserProfilePlace> UserProfilePlaces
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfilePlaces
                       where items.UserID == _UserID
                       select items;
            }
        }

        public IQueryable<UserRole> UserRoles
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserRoles
                       where items.UserRoleID == _UserRoleID
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
    /// A class which represents the Deal table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.Deal 
    /// </summary>

	public partial class Deal: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Deal(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDealIDChanging(int value);
        partial void OnDealIDChanged();
		
		private int _DealID;
		public int DealID { 
		    get{
		        return _DealID;
		    } 
		    set{
		        this.OnDealIDChanging(value);
                this.SendPropertyChanging();
                this._DealID = value;
                this.SendPropertyChanged("DealID");
                this.OnDealIDChanged();
		    }
		}
		
        partial void OnCategoryIDChanging(int value);
        partial void OnCategoryIDChanged();
		
		private int _CategoryID;
		public int CategoryID { 
		    get{
		        return _CategoryID;
		    } 
		    set{
		        this.OnCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._CategoryID = value;
                this.SendPropertyChanged("CategoryID");
                this.OnCategoryIDChanged();
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
		
        partial void OnStreetTigerThinksChanging(string value);
        partial void OnStreetTigerThinksChanged();
		
		private string _StreetTigerThinks;
		public string StreetTigerThinks { 
		    get{
		        return _StreetTigerThinks;
		    } 
		    set{
		        this.OnStreetTigerThinksChanging(value);
                this.SendPropertyChanging();
                this._StreetTigerThinks = value;
                this.SendPropertyChanged("StreetTigerThinks");
                this.OnStreetTigerThinksChanged();
		    }
		}
		
        partial void OnPictureChanging(string value);
        partial void OnPictureChanged();
		
		private string _Picture;
		public string Picture { 
		    get{
		        return _Picture;
		    } 
		    set{
		        this.OnPictureChanging(value);
                this.SendPropertyChanging();
                this._Picture = value;
                this.SendPropertyChanged("Picture");
                this.OnPictureChanged();
		    }
		}
		
        partial void OnOriginalPriceChanging(decimal value);
        partial void OnOriginalPriceChanged();
		
		private decimal _OriginalPrice;
		public decimal OriginalPrice { 
		    get{
		        return _OriginalPrice;
		    } 
		    set{
		        this.OnOriginalPriceChanging(value);
                this.SendPropertyChanging();
                this._OriginalPrice = value;
                this.SendPropertyChanged("OriginalPrice");
                this.OnOriginalPriceChanged();
		    }
		}
		
        partial void OnDealPriceChanging(decimal value);
        partial void OnDealPriceChanged();
		
		private decimal _DealPrice;
		public decimal DealPrice { 
		    get{
		        return _DealPrice;
		    } 
		    set{
		        this.OnDealPriceChanging(value);
                this.SendPropertyChanging();
                this._DealPrice = value;
                this.SendPropertyChanged("DealPrice");
                this.OnDealPriceChanged();
		    }
		}
		
        partial void OnVendorCutChanging(decimal value);
        partial void OnVendorCutChanged();
		
		private decimal _VendorCut;
		public decimal VendorCut { 
		    get{
		        return _VendorCut;
		    } 
		    set{
		        this.OnVendorCutChanging(value);
                this.SendPropertyChanging();
                this._VendorCut = value;
                this.SendPropertyChanged("VendorCut");
                this.OnVendorCutChanged();
		    }
		}
		
        partial void OnQtyChanging(int value);
        partial void OnQtyChanged();
		
		private int _Qty;
		public int Qty { 
		    get{
		        return _Qty;
		    } 
		    set{
		        this.OnQtyChanging(value);
                this.SendPropertyChanging();
                this._Qty = value;
                this.SendPropertyChanged("Qty");
                this.OnQtyChanged();
		    }
		}
		
        partial void OnLimitPerCustomerChanging(int value);
        partial void OnLimitPerCustomerChanged();
		
		private int _LimitPerCustomer;
		public int LimitPerCustomer { 
		    get{
		        return _LimitPerCustomer;
		    } 
		    set{
		        this.OnLimitPerCustomerChanging(value);
                this.SendPropertyChanging();
                this._LimitPerCustomer = value;
                this.SendPropertyChanged("LimitPerCustomer");
                this.OnLimitPerCustomerChanged();
		    }
		}
		
        partial void OnActiveAfterQtySoldChanging(int value);
        partial void OnActiveAfterQtySoldChanged();
		
		private int _ActiveAfterQtySold;
		public int ActiveAfterQtySold { 
		    get{
		        return _ActiveAfterQtySold;
		    } 
		    set{
		        this.OnActiveAfterQtySoldChanging(value);
                this.SendPropertyChanging();
                this._ActiveAfterQtySold = value;
                this.SendPropertyChanged("ActiveAfterQtySold");
                this.OnActiveAfterQtySoldChanged();
		    }
		}
		
        partial void OnPublishDateChanging(DateTime value);
        partial void OnPublishDateChanged();
		
		private DateTime _PublishDate;
		public DateTime PublishDate { 
		    get{
		        return _PublishDate;
		    } 
		    set{
		        this.OnPublishDateChanging(value);
                this.SendPropertyChanging();
                this._PublishDate = value;
                this.SendPropertyChanged("PublishDate");
                this.OnPublishDateChanged();
		    }
		}
		
        partial void OnCloseDateChanging(DateTime value);
        partial void OnCloseDateChanged();
		
		private DateTime _CloseDate;
		public DateTime CloseDate { 
		    get{
		        return _CloseDate;
		    } 
		    set{
		        this.OnCloseDateChanging(value);
                this.SendPropertyChanging();
                this._CloseDate = value;
                this.SendPropertyChanged("CloseDate");
                this.OnCloseDateChanged();
		    }
		}
		
        partial void OnServiceFeeChanging(decimal value);
        partial void OnServiceFeeChanged();
		
		private decimal _ServiceFee;
		public decimal ServiceFee { 
		    get{
		        return _ServiceFee;
		    } 
		    set{
		        this.OnServiceFeeChanging(value);
                this.SendPropertyChanging();
                this._ServiceFee = value;
                this.SendPropertyChanged("ServiceFee");
                this.OnServiceFeeChanged();
		    }
		}
		
        partial void OnCharityServiceFeeChanging(decimal value);
        partial void OnCharityServiceFeeChanged();
		
		private decimal _CharityServiceFee;
		public decimal CharityServiceFee { 
		    get{
		        return _CharityServiceFee;
		    } 
		    set{
		        this.OnCharityServiceFeeChanging(value);
                this.SendPropertyChanging();
                this._CharityServiceFee = value;
                this.SendPropertyChanged("CharityServiceFee");
                this.OnCharityServiceFeeChanged();
		    }
		}
		
        partial void OnTaxesChanging(int value);
        partial void OnTaxesChanged();
		
		private int _Taxes;
		public int Taxes { 
		    get{
		        return _Taxes;
		    } 
		    set{
		        this.OnTaxesChanging(value);
                this.SendPropertyChanging();
                this._Taxes = value;
                this.SendPropertyChanged("Taxes");
                this.OnTaxesChanged();
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
		
        partial void OnIsStickyChanging(bool value);
        partial void OnIsStickyChanged();
		
		private bool _IsSticky;
		public bool IsSticky { 
		    get{
		        return _IsSticky;
		    } 
		    set{
		        this.OnIsStickyChanging(value);
                this.SendPropertyChanging();
                this._IsSticky = value;
                this.SendPropertyChanged("IsSticky");
                this.OnIsStickyChanged();
		    }
		}
		
        partial void OnIsSoldOutChanging(bool value);
        partial void OnIsSoldOutChanged();
		
		private bool _IsSoldOut;
		public bool IsSoldOut { 
		    get{
		        return _IsSoldOut;
		    } 
		    set{
		        this.OnIsSoldOutChanging(value);
                this.SendPropertyChanging();
                this._IsSoldOut = value;
                this.SendPropertyChanged("IsSoldOut");
                this.OnIsSoldOutChanged();
		    }
		}
		
        partial void OnIsActivatedChanging(bool value);
        partial void OnIsActivatedChanged();
		
		private bool _IsActivated;
		public bool IsActivated { 
		    get{
		        return _IsActivated;
		    } 
		    set{
		        this.OnIsActivatedChanging(value);
                this.SendPropertyChanging();
                this._IsActivated = value;
                this.SendPropertyChanged("IsActivated");
                this.OnIsActivatedChanged();
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
        public IQueryable<CartItem> CartItems
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.CartItems
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<DealInRegion> DealInRegions
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DealInRegions
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<PurchasedDeal> PurchasedDeals
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.PurchasedDeals
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<DealVendor> DealVendors
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DealVendors
                       where items.DealID == _DealID
                       select items;
            }
        }

        public IQueryable<DealCategory> DealCategories
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.DealCategories
                       where items.DealCategoryID == _CategoryID
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
    /// A class which represents the TigerFact table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.TigerFact 
    /// </summary>

	public partial class TigerFact: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TigerFact(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnTigerFactIDChanging(int value);
        partial void OnTigerFactIDChanged();
		
		private int _TigerFactID;
		public int TigerFactID { 
		    get{
		        return _TigerFactID;
		    } 
		    set{
		        this.OnTigerFactIDChanging(value);
                this.SendPropertyChanging();
                this._TigerFactID = value;
                this.SendPropertyChanged("TigerFactID");
                this.OnTigerFactIDChanged();
		    }
		}
		
        partial void OnFactTitleChanging(string value);
        partial void OnFactTitleChanged();
		
		private string _FactTitle;
		public string FactTitle { 
		    get{
		        return _FactTitle;
		    } 
		    set{
		        this.OnFactTitleChanging(value);
                this.SendPropertyChanging();
                this._FactTitle = value;
                this.SendPropertyChanged("FactTitle");
                this.OnFactTitleChanged();
		    }
		}
		
        partial void OnFactChanging(string value);
        partial void OnFactChanged();
		
		private string _Fact;
		public string Fact { 
		    get{
		        return _Fact;
		    } 
		    set{
		        this.OnFactChanging(value);
                this.SendPropertyChanging();
                this._Fact = value;
                this.SendPropertyChanged("Fact");
                this.OnFactChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
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
    /// A class which represents the UserProfileMetaRelationshipStatus table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserProfileMetaRelationshipStatus 
    /// </summary>

	public partial class UserProfileMetaRelationshipStatus: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserProfileMetaRelationshipStatus(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUserProfileMetaRelationshipStatusIDChanging(int value);
        partial void OnUserProfileMetaRelationshipStatusIDChanged();
		
		private int _UserProfileMetaRelationshipStatusID;
		public int UserProfileMetaRelationshipStatusID { 
		    get{
		        return _UserProfileMetaRelationshipStatusID;
		    } 
		    set{
		        this.OnUserProfileMetaRelationshipStatusIDChanging(value);
                this.SendPropertyChanging();
                this._UserProfileMetaRelationshipStatusID = value;
                this.SendPropertyChanged("UserProfileMetaRelationshipStatusID");
                this.OnUserProfileMetaRelationshipStatusIDChanged();
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
		

        #endregion

        #region Foreign Keys
        public IQueryable<UserProfile> UserProfiles
        {
            get
            {
                  var db=new ExampleSite.Data.ExampleSiteDB();
                  return from items in db.UserProfiles
                       where items.RelationshipStatusID == _UserProfileMetaRelationshipStatusID
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
    /// A class which represents the UserRole table in the ExampleSite Database.
    /// This class is queryable through ExampleSiteDB.UserRole 
    /// </summary>

	public partial class UserRole: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UserRole(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
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
		
        partial void OnRoleNameChanging(string value);
        partial void OnRoleNameChanged();
		
		private string _RoleName;
		public string RoleName { 
		    get{
		        return _RoleName;
		    } 
		    set{
		        this.OnRoleNameChanging(value);
                this.SendPropertyChanging();
                this._RoleName = value;
                this.SendPropertyChanged("RoleName");
                this.OnRoleNameChanged();
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
                       where items.UserRoleID == _UserRoleID
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