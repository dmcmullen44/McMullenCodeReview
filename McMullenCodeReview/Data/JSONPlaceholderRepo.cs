using McMullenCodeReview.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace McMullenCodeReview.Data
{
    public class JSONPlaceholderRepo : IDataRepo
    {
        string Baseurl = "https://jsonplaceholder.typicode.com/";
                
        public IEnumerable<AlbumModel> GetAlbums()
        {
            IEnumerable<AlbumModel> albums;

            //Create Http client to retrive data from REST Endpoint
            using var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var responseTask = client.GetAsync("albums");
            responseTask.Wait();
            HttpResponseMessage Res = responseTask.Result;            
            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                albums = JsonConvert.DeserializeObject<List<AlbumModel>>(EmpResponse);
            }
            else
            {
                albums = Enumerable.Empty<AlbumModel>();
            }
            return albums;
        }


        public IEnumerable<PhotoModel> GetPhotosByAlbumId(int AlbumID)
        {
            IEnumerable<PhotoModel> photos;

            //Create Http client to retrive data from REST Endpoint
            using var client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var responseTask = client.GetAsync("photos?albumId=" + AlbumID);
            responseTask.Wait();
            HttpResponseMessage Res = responseTask.Result;
            
            if (Res.IsSuccessStatusCode)
            {
                var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                photos = JsonConvert.DeserializeObject<List<PhotoModel>>(EmpResponse);
            }
            else
            {
                photos = Enumerable.Empty<PhotoModel>();
            }
            return photos;
        }
    }
}

