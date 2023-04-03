namespace Backend.API
{
    public static class Extension
    {
        public static IServiceCollection AddRedisCache(this IServiceCollection service, IConfiguration configuration)
        {
            return service.AddStackExchangeRedisCache(redisOptions =>
            {
                string connection = configuration.GetConnectionString("Redis");
                redisOptions.Configuration = connection;
            });
        }
    }
}
