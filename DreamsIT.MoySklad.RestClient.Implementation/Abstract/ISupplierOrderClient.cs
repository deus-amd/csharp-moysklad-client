﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface ISupplierOrderClient
    {
        List<> SearchByInternalOrder(List<Guid> internalOrderIds);

        List<> SearchByPlannedDate(List<double> deliveryPlannedDates);

        List<> SearchByParameters(List<Guid> internalOrderIds = null, List<double> deliveryPlannedDates = null,
    List<Guid> ids = null, List<string> updated = null, List<string> names = null, List<Guid> customerOrderIds = null,
    List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null);
    }
}
