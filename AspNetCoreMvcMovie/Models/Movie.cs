namespace AspNetCoreMvcMovie.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Movie
	{
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public int ID { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		public string Title { get; set; }

		[Range(1, 100)]
		[DataType(DataType.Currency)]
		public decimal Price { get; set; }

		[Display(Name = "Release Date")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
		[Required]
		[StringLength(30)]
		public string Genre { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
		[StringLength(5)]
		[Required]
		public string Rating { get; set; }
	}
}
