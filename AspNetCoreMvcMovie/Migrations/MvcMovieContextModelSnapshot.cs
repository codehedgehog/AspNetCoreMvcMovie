﻿using AspNetCoreMvcMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace AspNetCoreMvcMovie.Migrations
{
	[DbContext(typeof(MvcMovieContext))]
	partial class MvcMovieContextModelSnapshot : ModelSnapshot
	{
		protected override void BuildModel(ModelBuilder modelBuilder)
		{
			modelBuilder
					.HasAnnotation("ProductVersion", "1.1.2")
					.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

			modelBuilder.Entity("AspNetCoreMvcMovie.Models.Movie", b =>
					{
						b.Property<int>("ID")
											.ValueGeneratedOnAdd();

						b.Property<string>("Genre");

						b.Property<decimal>("Price");

						b.Property<string>("Rating");

						b.Property<DateTime>("ReleaseDate");

						b.Property<string>("Title");

						b.HasKey("ID");

						b.ToTable("Movie");
					});
		}
	}
}