using FlutterWave.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlutterWave.Logic
{
    public class FlutterCLient
    {
        private readonly ApiCLient _apiCLient;
        private readonly FlutterOptions _options;

        public FlutterCLient(ApiCLient client, FlutterOptions options)
        {
            _apiCLient = client;
            _options = options;
        }

        public async Task<string> InitiatePaymentAsync(FlutterRequest request)
        {
            var response = await _apiCLient.PostAsync(_options.BaseUrl, _options.PaymentLink, request, token: _options.Token);

            response.EnsureSuccessStatusCode();

            var flutterResJson = await response.Content.ReadAsStringAsync();
            var flutterRes = JsonConvert.DeserializeObject<FlutterResponse>(flutterResJson);

            return flutterRes.Data.Link;
        }
    }
}
