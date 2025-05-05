using Business_Layer.Repositories;

namespace Business_Layer.Services
{
    public class DateInformation : IDateInformation
    {
        public List<MonthInfo> GenerateMonthInformation()
        {
            string[] Months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            List<MonthInfo> AllMonths = new();
            for (int Month = 0; Month < Months.Length; Month++)
            {
                if (!string.IsNullOrEmpty(Months[Month]))
                {
                    AllMonths.Add(new MonthInfo()
                    {
                        MonthName = Months[Month],
                        MonthNumber = Month + 1
                    });
                }
            }
            return AllMonths;
        }
    }
}
