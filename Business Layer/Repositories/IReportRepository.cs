using Business_Logic.DTO;

namespace Business_Layer.Repositories
{
    public interface IReportRepository
    {
        Task<List<ReportDTO>> ReportByYearAsync(int year);
        Task<List<ReportDTO>> ReportByMonthAsync(int year, int month);
        Task<List<ReportDTO>> ReportByDayAsync(int year, int month, int day);
        Task<List<ReportDTO>> RepostByWeekAsync(int year, int month, int week);
        Task<decimal> CalculatePriceOFAllReportMedicinesAsync(List<ReportDTO> Medicines);
    }
}
