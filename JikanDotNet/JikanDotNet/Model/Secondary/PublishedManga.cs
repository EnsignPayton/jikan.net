﻿using Newtonsoft.Json;

namespace JikanDotNet
{
	/// <summary>
	/// Published manga  model class for person's class.
	/// </summary>
	public class PublishedManga
	{
		/// <summary>
		/// Published manga.
		/// </summary>
		[JsonProperty(PropertyName = "manga")]
		public MALImageSubItem Manga { get; set; }

		/// <summary>
		/// Position associated with published manga.
		/// </summary>
		[JsonProperty(PropertyName = "position")]
		public string Position { get; set; }
	}
}