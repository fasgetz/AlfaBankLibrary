using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Models.Requests
{
    /// <summary>
    /// Запрос на получение заказа
    /// </summary>
    public class GetOrderRequest
    {
        public string OrderId { get; set; }
    }
}