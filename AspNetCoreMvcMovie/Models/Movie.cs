namespace AspNetCoreMvcMovie.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Movie
	{
		public int ID { get; set; }
		public string Title { get; set; }

		[Display(Name = "Release Date")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		public string Genre { get; set; }
		public decimal Price { get; set; }
	}
}