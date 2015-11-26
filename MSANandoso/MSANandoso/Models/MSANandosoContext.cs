using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Web;

namespace MSANandoso.Models
{
	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

	public class MSANandosoContext : DbContext
	{

		public class MyConfiguration : DbMigrationsConfiguration<MSANandosoContext>
		{
			public MyConfiguration()
			{
				this.AutomaticMigrationsEnabled = true;
				this.AutomaticMigrationDataLossAllowed = true;
			}

			protected override void Seed(MSANandosoContext context)
			{
				var specials = new List<Special>
					{
						new Special
						{
							Image = "image01.jpg",
							Title = "Shutki",
							Description = "One needs to acquire a taste for this one. Although this is a famous Bong dish, there are a lot of Bongs I know who do not like it because of the strong smell. Shutki or dry fish when uncooked has got a typical characteristic pungent smell, pungent enough to evoke nausea. But if you’re okay with the smell, the taste will get you craving for more.",
							Price = 17.99M
						},
						new Special
						{
							Image = "image02.jpg",
							Title = "Kolahpuri Chicken",
							Description = "Kolhapur is known to be a place that loves its spices. Tikhi Mirchi layi hoon, main Kolhapurse aayi hoon. Ring a bell? Spicy, hot, exotic real Kolahpuri chicken. It goes really well with homemade light, fluffy, crispy jwarichi bhakari or with some naan! Incredibly hot.",
							Price = 18.99M
						},
						new Special
						{
							Image = "image03.jpg",
							Title = "Andhra Dry Mutton",
							Description = "Trust me, guys. Andhra food is just out of this world. It's not only incredibly spicy, but if you end up going to an Andhra restaurant, you'll realise it's also a very well balanced meal. It's generally teamed up with rice and vegetarian dishes to help you out with the fire in the stomach. Must try!",
							Price = 13.99M
						},
						new Special
						{
							Image = "image04.jpg",
							Title = "Piro Aloo",
							Description = "Finally, something for the vegetarians. Although this dish originated from Nepal, it has become quite a popular dish in India as well. To put it simply, it’s a Nepalese take of India’s favourite, Dum Aloo. A little drier than its Indian counterpart, it is also at least 10 times spicier. This is a favourite, even for die-hard meat lovers.",
							Price = 14.99M
						},
						new Special
						{
							Image = "image05.jpg",
							Title = "Laal Maas",
							Description = "The name sounds deadly to begin with, doesn't it? In Rajasthan, a place dominated by vegetarian cuisine, the only non-vegetarian dish to really stand out is laal maas (red meat). If you are a non-vegetarian and wish to test your taste buds, this red hot preparation is a must-try! It is a thick/semi gravy mutton curry prepared in a sauce of curd and hot spices such as red chillies. The deep red colour and the spicy character come from a special chilli called the Mathania red chilli that comes from Mathania in Jodhpur.",
							Price = 16.99M
						}
					};
				specials.ForEach(s => context.Specials.AddOrUpdate(p => p.Title, s));
				context.SaveChanges();

				// Dummy data that was seeded during testing

				//var feedback = new List<Feedback>
				//{
				//	new Feedback
				//	{
				//		Name = "John",
				//		Message = "message 1"
				//	},
				//	new Feedback
				//	{
				//		Name = "Christine",
				//		Message = "message 2"
				//	},
				//	new Feedback
				//	{
				//		Name = "Ryan",
				//		Message = "message 3"
				//	},
				//	new Feedback
				//	{
				//		Name = "James",
				//		Message = "message 4"
				//	},
				//	new Feedback
				//	{
				//		Name = "Mary",
				//		Message = "message 5"
				//	},
				//	new Feedback
				//	{
				//		Name = "Bob",
				//		Message = "message 6"
				//	}
				//};
				//feedback.ForEach(s => context.Feedbacks.AddOrUpdate(p => p.Name, s));
				//context.SaveChanges();
			}
		}

		//You can add custom code to this file.Changes will not be overwritten.

		//  If you want Entity Framework to drop and regenerate your database
		//  automatically whenever you change your model schema, please use data migrations.
		//  For more information refer to the documentation:
		//  http://msdn.microsoft.com/en-us/data/jj591621.aspx

		public MSANandosoContext() : base("name=MSANandosoContext")
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSANandosoContext, MyConfiguration>());
		}

		public System.Data.Entity.DbSet<MSANandoso.Models.Special> Specials { get; set; }

		public System.Data.Entity.DbSet<MSANandoso.Models.Feedback> Feedbacks { get; set; }
	}
}