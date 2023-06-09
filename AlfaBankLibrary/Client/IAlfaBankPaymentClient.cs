﻿using AlfaBankLibrary.Models.Requests;
using AlfaBankLibrary.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Client
{
    public interface IAlfaBankPaymentClient
    {
        /// <summary>
        /// Получение заказа
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetOrderResponse> GetOrder(GetOrderRequest request);

        /// <summary>
        /// Создание платежа
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateOrderResponse> CreatePayment(CreateOrderRequest request);
    }
}
