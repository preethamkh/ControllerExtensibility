using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;


namespace ControllerExtensibility.Models
{
    public class RemoteService
    {
        public string GetRemoteData()
        {
            Thread.Sleep(2000);
            return "Bleh ... remote data coming in";
        }

        public async Task<string> GetRemoteDataAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Hello async remote";
            });
        }
    }
}