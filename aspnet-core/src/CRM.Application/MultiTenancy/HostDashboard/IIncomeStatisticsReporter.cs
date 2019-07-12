using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.MultiTenancy.HostDashboard.Dto;

namespace CRM.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}