﻿using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TweetWeb.Data;

namespace TweetWeb.Pages.Features.Tweets
{
	public class Post
	{
		public class Command : IRequest
		{
			public string? Contents { get; set; }
		}

		public class CommandHandler : AsyncRequestHandler<Command>
		{
			private readonly Store store;

			public CommandHandler(Store store)
			{
				this.store = store;
			}

			protected override async Task Handle(Command request, CancellationToken cancellationToken)
			{
				store.Add(new Tweet { Contents = request.Contents });
			}
		}
	}
}