using Business_Layer.Repositories;
using Business_Logic.Data;
using Business_Logic.DTO;
using Microsoft.EntityFrameworkCore;

namespace Business_Layer.Services
{
    public class ReportRepository : IReportRepository
    {
        ContextData Data;
        public ReportRepository(ContextData Data)
        {
            this.Data = Data;
        }

        public Task<decimal> CalculatePriceOFAllReportMedicinesAsync(List<ReportDTO> Medicines)
        {
            decimal TotalPrice = 0M;
            foreach (var Item in Medicines)
            {
                TotalPrice += Item.TotalPrice;
            }
            return Task.FromResult(TotalPrice);
        }

        public async Task<List<ReportDTO>> ReportByDayAsync(int year, int month, int day)
        {
            try
            {
                var TargetDate = new DateTime(year, month, day);
                return await Data.Medicines.Include(M => M.Carts
            ).Select(M => new ReportDTO
            {
                MedicineName = M.Name,
                AvailableQuantity = M.Quantity,
                SoldQuantity = M.Carts.Where(M => M.DateAdded.Date == TargetDate).Select(C => C.Quantity).Sum(),
                TotalPrice = M.Carts.Where(M => M.DateAdded.Date == TargetDate).Select(C => C.TotalPrice).Sum()
            }).Where(M => M.SoldQuantity > 0)
            .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }
        public async Task<List<ReportDTO>> ReportByMonthAsync(int year, int month)
        {
            try
            {
                return await Data.Medicines.Include(M => M.Carts
            ).Select(M => new ReportDTO
            {
                MedicineName = M.Name,
                AvailableQuantity = M.Quantity,
                SoldQuantity = M.Carts.Where(M => M.DateAdded.Year == year && M.DateAdded.Month == month).Select(C => C.Quantity).Sum(),
                TotalPrice = M.Carts.Where(M => M.DateAdded.Year == year && M.DateAdded.Month == month).Select(C => C.TotalPrice).Sum()
            }).Where(M => M.SoldQuantity > 0)
            .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        public async Task<List<ReportDTO>> ReportByYearAsync(int year)
        {
            try
            {
                return await Data.Medicines.Include(M => M.Carts
            ).Select(M => new ReportDTO
            {
                MedicineName = M.Name,
                AvailableQuantity = M.Quantity,
                SoldQuantity = M.Carts.Where(M => M.DateAdded.Year == year).Select(C => C.Quantity).Sum(),
                TotalPrice = M.Carts.Where(M => M.DateAdded.Year == year).Select(C => C.TotalPrice).Sum()
            }).Where(M => M.SoldQuantity > 0)
            .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        public Task<List<ReportDTO>> RepostByWeekAsync(int year, int month, int week)
        {
            throw new NotImplementedException();
        }
    }
}
