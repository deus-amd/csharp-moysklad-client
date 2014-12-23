﻿using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Юр. лицо
    /// </summary>
    public class MyCompany : Organization, IKeyItem<int>
    {
        public int Id { get; set; }
        public string Director { get; set; }

        /// <summary>
        /// Имя главного бухгалтера
        /// </summary>
        public string ChiefAccountant { get; set; }
    }
}
