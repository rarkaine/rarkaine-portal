using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rarkaine.Portal.MultiTenancy.HostDashboard.Dto;

namespace Rarkaine.Portal.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}