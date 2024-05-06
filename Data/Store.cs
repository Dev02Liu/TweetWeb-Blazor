using System.Collections.Generic;
using System.Linq;

namespace TweetWeb.Data
{
	public class Store
	{
		public IList<Tweet> Tweets { get; set; } = new List<Tweet>
		{
		};

		public void Add(Tweet tweet)
		{
			Tweets.Add(tweet);
		}
	}

	public class Tweet
	{
		public string? Contents { get; set; }
	}
}