﻿using System.ComponentModel.DataAnnotations;

namespace backend.Models.API.Requests
{
	public class AddPostRequest
	{
		[Required]
		public string Title { get; set; } = null!;
		[Required]
		public string Subtitle { get; set; } = null!;
		[Required]
		public string HtmlText { get; set; } = null!;
	}
}
