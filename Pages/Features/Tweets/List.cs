﻿using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TweetWeb.Data;
using System.Linq;


namespace TweetWeb.Pages.Features.Tweets
{
    public class List
    {
        public class Query : IRequest<Model>
        {
        }

        public class Model
        {
            public List<string?>? Tweets { get; set; }
        }

		public class QueryHandler : IRequestHandler<Query, Model>
		{
			private Store _store;

			public QueryHandler(Store store)
			{
				_store = store;
			}

			public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
			{
				return new Model
				{
					Tweets = _store.Tweets
						.Select(x => x.Contents)
						.ToList()
				};
			}
		}
	}
}