using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Models.Responses
{
    public class CreateOrderResponse
    {
        public string orderId { get; set; }
        public string formUrl { get; set; }
    }
}