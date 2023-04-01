using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Models.Requests
{
    public class CreateOrderRequest
    {
        /// <summary>
        /// Номер заказа в нашей системе (уникальный)
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        /// <example>
        /// Сумма умножается на 100
        /// Например, amount = 1000 = 10 рублей
        /// </example>
        public long Amount { get; set; }
    }
}
