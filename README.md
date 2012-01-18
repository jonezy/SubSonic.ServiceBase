# SubSonic

SubSonic is a data access utility belt written by Rob Conery.  I've been using it since version 2 and i fell in love with it.  This guide is going to cover how I have been using SubSnoic 3 in asp.net mvc web applications that I build.  The usual disclaimer type stuff applies.  This iis a method that I have arrived at, it's not new, nor is it rocket science.  It works for me and I like it.  It may not work for you and you may not like it, that is fine.

# ServiceBase

For most websites I build using SubSonic I use a service pattern.  That is for every domain object (User, Order) there is a corresponding service class.  That service class can interact with many tables that deal with the domain object (User => Login, UserProfile, UserDetails) 
