﻿using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods;
using DreamsIT.MoySklad.RestClient.Models;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class StockClient : IStockClient
    {
        public StockClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<StockTO>(login, password, host);
                    }
        private RequestGenerator<StockTO> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/stock/xml";
        public Models.ResultOrError<List<Models.StockTO>> StockBalance(Models.Enums.StockMode stockMode = StockMode.AllStock, string moment = "",
Guid? goodUuid = null, string goodName = "", Guid? storeId = null, bool includeAboardOperations = false, bool showConsignments = false)
        {
            string paramsInString = "";
            if (stockMode != null)
            {
                string goodUuidInString = stockMode.ToString();
                paramsInString = paramsInString + ";" + goodUuidInString;
            }
            if (!string.IsNullOrWhiteSpace(moment))
            {
                paramsInString = paramsInString + ";" + moment;
            }
            if (goodUuid != null)
            {
                string goodUuidInString = goodUuid.ToString();
                paramsInString = paramsInString + ";" + goodUuidInString;
            }
            if (!string.IsNullOrWhiteSpace(goodName))
            {
                paramsInString = paramsInString + ";" + goodName;
            }
            if (storeId != null)
            {
                string storeIdInString = storeId.ToString();
                paramsInString = paramsInString + ";" + storeIdInString;
            }
            if (includeAboardOperations != true)
            {
                paramsInString = paramsInString + ";" + includeAboardOperations;
            }
            if (showConsignments != true)
            {
                paramsInString = paramsInString + ";" + showConsignments;
            }

            return requestGenerator.getItemsFromAPI(paramsInString.Substring(1));
        }
    }
}