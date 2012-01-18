# SubSonic

SubSonic is a data access utility belt written by Rob Conery.  I've been using it since version 2 and i fell in love with it.  This guide is going to cover how I have been using SubSnoic 3 in asp.net mvc web applications that I build.  The usual disclaimer type stuff applies.  This iis a method that I have arrived at, it's not new, nor is it rocket science.  It works for me and I like it.  It may not work for you and you may not like it, that is fine.

# ServiceBase

For most websites I build using SubSonic I use a service pattern.  That is for every domain object (User, Order) there is a corresponding service class.  That service class can interact with many tables that deal with the domain object (User => Login, UserProfile, UserDetails).  

SubSonic is a fantastic utility and I love using it, but the programmer in me can't stand having that stuff in my controllers which is why I typically abstract out to a service pattern (which I find handles web scenarios very well).  ServiceBase makes that service layer incredibly thin and light and let's you just do stuff.  ServiceBase will provide caching, it implements a generic save method that will work for any SubSonic entity.

# Example Site

## Structure

One of the first things you'll notice about the example site is that I don't follow the "out of the box" project layout that is provided in Visual Studio.  I don't because it sucks (that's my opinion) so I decided a long time ago that I would use my own project format (i have a batch file that takes care of most of this).  

### Infrastructure

#### Data

The data folder is where I put all the SubSonic related files, I namespace this as ExampleSite.Infrastructure.Data.

#### Services
