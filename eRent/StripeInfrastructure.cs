﻿using eRent.Services.Payment.Stripe;
using Stripe;

namespace eRent
{
	public static class StripeInfrastructure
	{
		public static IServiceCollection AddStripeInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			StripeConfiguration.ApiKey = configuration.GetValue<string>("StripeSettings:SecretKey");

			return services
				.AddScoped<CustomerService>()
				.AddScoped<ChargeService>()
				.AddScoped<TokenService>()
				.AddScoped<IStripeAppService, StripeAppService>();
		}
	}
}
