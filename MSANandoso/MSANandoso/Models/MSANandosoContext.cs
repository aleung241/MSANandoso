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
							Title = "Title01",
							Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor.",
							Price = 17.99M
						},
						new Special
						{
							Image = "image02.jpg",
							Title = "Title02",
							Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor.",
							Price = 16.99M
						},
						new Special
						{
							Image = "image03.jpg",
							Title = "Title03",
							Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor.",
							Price = 15.99M
						},
						new Special
						{
							Image = "image04.jpg",
							Title = "Title04",
							Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor.",
							Price = 14.99M
						},
						new Special
						{
							Image = "image05.jpg",
							Title = "Title05",
							Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor.",
							Price = 13.99M
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