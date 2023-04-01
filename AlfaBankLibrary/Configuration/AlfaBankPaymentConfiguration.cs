using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Configuration
{
    /// <summary>
    /// Конфигурация API
    /// </summary>
    public class AlfaBankPaymentConfiguration
    {
        public string UrlApi { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string SuccessPaymentUrl { get; set; }
        public string FailPaymentUrl { get; set; }
    }
}