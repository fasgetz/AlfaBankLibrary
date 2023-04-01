using AlfaBankLibrary.Configuration;
using AlfaBankLibrary.Models.Requests;
using AlfaBankLibrary.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Client
{
    public class AlfaBankPaymentClient : IAlfaBankPaymentClient
    {
        private readonly AlfaBankPaymentConfiguration _configuration;

        public AlfaBankPaymentClient(AlfaBankPaymentConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<CreateOrderResponse> CreatePayment(CreateOrderRequest request)
        {
            // Клиент
            HttpClientHandler clientHandler = new HttpClientHandler();

            // Для того, чтобы отправить на апи, у которого не установлен SSL
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpResponseMessage httpResponse = null;

            using (var MyClient = new HttpClient(clientHandler))
            {
                MyClient.BaseAddress = new Uri(_configuration.UrlApi);

                httpResponse = await MyClient
                    .GetAsync($"register.do?userName={_configuration.Login}&" +
                    $"password={_configuration.Password}&" +
                    $"orderNumber={request.OrderNumber}&" +
                    $"amount={request.Amount * 100}&" +
                    $"returnUrl={_configuration.SuccessPaymentUrl}&" +
                    $"failUrl={_configuration.FailPaymentUrl}")
                    .ConfigureAwait(false);
            }

            var bodyContent = await httpResponse.Content.ReadAsStringAsync();

            // Если не найдена страница
            if (httpResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
            {

            }

            // Если запрос неуспешный, то вывести об этом сообщение
            if (httpResponse.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {

            }

            if (httpResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {

            }

            // Если прошли и получили STATUSCODE == 200
            // Возвращаем ответ
            var response = JsonConvert.DeserializeObject<CreateOrderResponse>(bodyContent);

            return response;
        }
    }
}