using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;


namespace HospitalManagementSystem.API.src.Services

{
    public class RedisCacheServices
    {

        private readonly IDistributedCache distributedCache;
        private readonly ILogger<RedisCacheServices> _logger;


        public RedisCacheServices(IDistributedCache distributedCache, ILogger<RedisCacheServices> logger)
        {

            this.distributedCache = distributedCache;
            //_logger = logger;
        }

        public async Task<T> GetFromCacheAsync<T>(string cacheKey, Func<Task<T>> retrieveData, TimeSpan? expiry = null)
        {
            try
            {
                var cachedData = await distributedCache.GetStringAsync(cacheKey);

                if (!string.IsNullOrEmpty(cachedData))
                {
                    // _logger.LogDebug("Retrieved data from cache for key: {CacheKey}", cacheKey);

                    return JsonConvert.DeserializeObject<T>(cachedData);
                }

                var data = await retrieveData();

                if (data != null)
                {
                    var serializedData = JsonConvert.SerializeObject(data);
                    await distributedCache.SetStringAsync(cacheKey, serializedData, new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = expiry ?? TimeSpan.FromMinutes(30)
                    });

                    //_logger.LogDebug("Cached data for key: {CacheKey}", cacheKey);

                }


                return data;
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex, "Error occurred while retrieving or caching data for key: {CacheKey}", cacheKey);
                throw;
            }

        }


    }
}
