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
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor. Mauris tempor lacus lacus, id sagittis ligula sodales non. Quisque ornare facilisis felis, at efficitur massa mollis non. Integer vestibulum elit vitae euismod commodo. Maecenas ac egestas tortor, eu condimentum orci. Aliquam semper convallis vestibulum. Cras non est non est dictum faucibus. Integer pulvinar ipsum in lacus bibendum, non semper justo dignissim. Fusce sapien mauris, iaculis vitae elit vel, pulvinar dignissim metus. Quisque ipsum felis, pharetra eget elit vitae, tempor viverra sem. Vestibulum efficitur nulla viverra augue volutpat, id consectetur lorem ornare. Nulla ultrices finibus tellus, a mattis enim finibus vel. Vivamus sed vestibulum tortor. Vestibulum sodales scelerisque ipsum, vitae pellentesque eros eleifend in. Integer lorem risus, tincidunt et neque ac, mollis sollicitudin enim. Mauris sed vulputate magna, at feugiat justo. Nulla condimentum turpis sed ipsum ultrices venenatis. Integer eu ligula tempor, malesuada ligula eu, varius sem. Vestibulum feugiat malesuada est, faucibus condimentum sem congue sit amet. Suspendisse lacinia faucibus felis, id rhoncus eros tincidunt egestas. Maecenas rutrum suscipit nulla. In hac habitasse platea dictumst. Nulla eu leo ac dolor suscipit tincidunt. Proin eget tellus eget erat tincidunt vestibulum eget id sem. Curabitur id varius neque. Proin ultrices leo elit, sit amet mollis metus elementum fringilla. Praesent erat magna, iaculis sit amet ipsum tempus.",
						Price = 17.99M
					},
					new Special
					{
						Image = "image02.jpg",
						Title = "Title02",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor. Mauris tempor lacus lacus, id sagittis ligula sodales non. Quisque ornare facilisis felis, at efficitur massa mollis non. Integer vestibulum elit vitae euismod commodo. Maecenas ac egestas tortor, eu condimentum orci. Aliquam semper convallis vestibulum. Cras non est non est dictum faucibus. Integer pulvinar ipsum in lacus bibendum, non semper justo dignissim. Fusce sapien mauris, iaculis vitae elit vel, pulvinar dignissim metus. Quisque ipsum felis, pharetra eget elit vitae, tempor viverra sem. Vestibulum efficitur nulla viverra augue volutpat, id consectetur lorem ornare. Nulla ultrices finibus tellus, a mattis enim finibus vel. Vivamus sed vestibulum tortor. Vestibulum sodales scelerisque ipsum, vitae pellentesque eros eleifend in. Integer lorem risus, tincidunt et neque ac, mollis sollicitudin enim. Mauris sed vulputate magna, at feugiat justo. Nulla condimentum turpis sed ipsum ultrices venenatis. Integer eu ligula tempor, malesuada ligula eu, varius sem. Vestibulum feugiat malesuada est, faucibus condimentum sem congue sit amet. Suspendisse lacinia faucibus felis, id rhoncus eros tincidunt egestas. Maecenas rutrum suscipit nulla. In hac habitasse platea dictumst. Nulla eu leo ac dolor suscipit tincidunt. Proin eget tellus eget erat tincidunt vestibulum eget id sem. Curabitur id varius neque. Proin ultrices leo elit, sit amet mollis metus elementum fringilla. Praesent erat magna, iaculis sit amet ipsum tempus.",
						Price = 16.99M
					},
					new Special
					{
						Image = "image03.jpg",
						Title = "Title03",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor. Mauris tempor lacus lacus, id sagittis ligula sodales non. Quisque ornare facilisis felis, at efficitur massa mollis non. Integer vestibulum elit vitae euismod commodo. Maecenas ac egestas tortor, eu condimentum orci. Aliquam semper convallis vestibulum. Cras non est non est dictum faucibus. Integer pulvinar ipsum in lacus bibendum, non semper justo dignissim. Fusce sapien mauris, iaculis vitae elit vel, pulvinar dignissim metus. Quisque ipsum felis, pharetra eget elit vitae, tempor viverra sem. Vestibulum efficitur nulla viverra augue volutpat, id consectetur lorem ornare. Nulla ultrices finibus tellus, a mattis enim finibus vel. Vivamus sed vestibulum tortor. Vestibulum sodales scelerisque ipsum, vitae pellentesque eros eleifend in. Integer lorem risus, tincidunt et neque ac, mollis sollicitudin enim. Mauris sed vulputate magna, at feugiat justo. Nulla condimentum turpis sed ipsum ultrices venenatis. Integer eu ligula tempor, malesuada ligula eu, varius sem. Vestibulum feugiat malesuada est, faucibus condimentum sem congue sit amet. Suspendisse lacinia faucibus felis, id rhoncus eros tincidunt egestas. Maecenas rutrum suscipit nulla. In hac habitasse platea dictumst. Nulla eu leo ac dolor suscipit tincidunt. Proin eget tellus eget erat tincidunt vestibulum eget id sem. Curabitur id varius neque. Proin ultrices leo elit, sit amet mollis metus elementum fringilla. Praesent erat magna, iaculis sit amet ipsum tempus.",
						Price = 15.99M
					},
					new Special
					{
						Image = "image04.jpg",
						Title = "Title04",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor. Mauris tempor lacus lacus, id sagittis ligula sodales non. Quisque ornare facilisis felis, at efficitur massa mollis non. Integer vestibulum elit vitae euismod commodo. Maecenas ac egestas tortor, eu condimentum orci. Aliquam semper convallis vestibulum. Cras non est non est dictum faucibus. Integer pulvinar ipsum in lacus bibendum, non semper justo dignissim. Fusce sapien mauris, iaculis vitae elit vel, pulvinar dignissim metus. Quisque ipsum felis, pharetra eget elit vitae, tempor viverra sem. Vestibulum efficitur nulla viverra augue volutpat, id consectetur lorem ornare. Nulla ultrices finibus tellus, a mattis enim finibus vel. Vivamus sed vestibulum tortor. Vestibulum sodales scelerisque ipsum, vitae pellentesque eros eleifend in. Integer lorem risus, tincidunt et neque ac, mollis sollicitudin enim. Mauris sed vulputate magna, at feugiat justo. Nulla condimentum turpis sed ipsum ultrices venenatis. Integer eu ligula tempor, malesuada ligula eu, varius sem. Vestibulum feugiat malesuada est, faucibus condimentum sem congue sit amet. Suspendisse lacinia faucibus felis, id rhoncus eros tincidunt egestas. Maecenas rutrum suscipit nulla. In hac habitasse platea dictumst. Nulla eu leo ac dolor suscipit tincidunt. Proin eget tellus eget erat tincidunt vestibulum eget id sem. Curabitur id varius neque. Proin ultrices leo elit, sit amet mollis metus elementum fringilla. Praesent erat magna, iaculis sit amet ipsum tempus.",
						Price = 14.99M
					},
					new Special
					{
						Image = "image05.jpg",
						Title = "Title05",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum nulla vitae consequat dictum. Fusce blandit, turpis eu lobortis scelerisque, sem purus rutrum magna, sed dapibus diam diam eget ex. Quisque finibus neque eu suscipit venenatis. Vivamus a justo nulla. Ut gravida nunc ligula, eu ultrices arcu aliquet vel. Integer lobortis placerat metus, eget laoreet libero. Etiam non erat eu ipsum rutrum aliquet. Sed a ante bibendum, feugiat ex in, laoreet orci. Aliquam a felis non orci maximus mollis ut id dui. Cras maximus venenatis justo quis tempor. Aenean eu venenatis lorem. Nulla commodo tempor tempor. Mauris tempor lacus lacus, id sagittis ligula sodales non. Quisque ornare facilisis felis, at efficitur massa mollis non. Integer vestibulum elit vitae euismod commodo. Maecenas ac egestas tortor, eu condimentum orci. Aliquam semper convallis vestibulum. Cras non est non est dictum faucibus. Integer pulvinar ipsum in lacus bibendum, non semper justo dignissim. Fusce sapien mauris, iaculis vitae elit vel, pulvinar dignissim metus. Quisque ipsum felis, pharetra eget elit vitae, tempor viverra sem. Vestibulum efficitur nulla viverra augue volutpat, id consectetur lorem ornare. Nulla ultrices finibus tellus, a mattis enim finibus vel. Vivamus sed vestibulum tortor. Vestibulum sodales scelerisque ipsum, vitae pellentesque eros eleifend in. Integer lorem risus, tincidunt et neque ac, mollis sollicitudin enim. Mauris sed vulputate magna, at feugiat justo. Nulla condimentum turpis sed ipsum ultrices venenatis. Integer eu ligula tempor, malesuada ligula eu, varius sem. Vestibulum feugiat malesuada est, faucibus condimentum sem congue sit amet. Suspendisse lacinia faucibus felis, id rhoncus eros tincidunt egestas. Maecenas rutrum suscipit nulla. In hac habitasse platea dictumst. Nulla eu leo ac dolor suscipit tincidunt. Proin eget tellus eget erat tincidunt vestibulum eget id sem. Curabitur id varius neque. Proin ultrices leo elit, sit amet mollis metus elementum fringilla. Praesent erat magna, iaculis sit amet ipsum tempus.",
						Price = 13.99M
					}
				};
				specials.ForEach(s => context.Specials.AddOrUpdate(p => p.Title, s));
				context.SaveChanges();
			}
		}

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MSANandosoContext() : base("name=MSANandosoContext")
        {
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSANandosoContext, MyConfiguration>());
        }

		public System.Data.Entity.DbSet<MSANandoso.Models.Special> Specials { get; set; }
	}
}
