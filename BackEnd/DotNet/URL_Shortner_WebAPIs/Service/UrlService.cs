using Admin_Web_APIs.Data;
using MongoDB.Driver;
using URL_Shortner_WebAPIs.Model;

namespace URL_Shortner_WebAPIs.Service
{
    public class UrlService
    {

        private readonly IMongoCollection<ShortUrl> _url;

        public UrlService(MongoDbData url)
        {
            _url=url.GetURLCollection();
        }

        //Create short Url

        public async Task<ShortUrl> CreateShortUrl(string Original_Url)
        {

            //will implement later

        }
    }
}
