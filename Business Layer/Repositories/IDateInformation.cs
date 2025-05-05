using Business_Layer.Services;

namespace Business_Layer.Repositories
{
    public interface IDateInformation
    {
        List<MonthInfo> GenerateMonthInformation();
    }
}
