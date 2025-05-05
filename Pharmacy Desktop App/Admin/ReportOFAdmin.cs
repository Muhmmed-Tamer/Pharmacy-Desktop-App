using Business_Layer.Services;
using Business_Layer.UnitOFWork;
using Business_Logic.DTO;

namespace Pharmacy_Desktop_App.Admin
{
    public partial class ReportOFAdmin : Form
    {
        private readonly IUnitOFWork UnitOFWork;
        private GenerateReport ReportThatSelected;
        Login login;
        public ReportOFAdmin(IUnitOFWork UnitOFWork, Login login)
        {
            this.UnitOFWork = UnitOFWork;
            ReportThatSelected = new GenerateReport();
            InitializeComponent();
            this.login = login;
        }

        private void ReportOFAdmin_Load(object sender, EventArgs e)
        {
            this.DropDownListOfGenerateReportBy.SelectedIndex = -1;
            //Append Data To The  ComboBox
            this.DropDownListOfGenerateReportBy.Items.Add(GenerateReport.GenerateReportByYear);
            this.DropDownListOfGenerateReportBy.Items.Add(GenerateReport.GenerateReportByMonth);
            this.DropDownListOfGenerateReportBy.Items.Add(GenerateReport.GenerateReportByDay);

            for (int Day = 1; Day <= 31; Day++)
            {
                this.DayDropDownList.Items.Add(Day);
            }

            MonthDropDownList.DataSource = UnitOFWork.DateManager.GenerateMonthInformation();
            MonthDropDownList.DisplayMember = "MonthName";
            MonthDropDownList.ValueMember = "MonthNumber";

            for (int Year = 1990; Year <= DateTime.Now.Year + 50; Year++)
            {
                this.YearDropDownList.Items.Add(Year);
            }
            this.YearDropDownList.Enabled = false;
            this.MonthDropDownList.Enabled = false;
            this.DayDropDownList.Enabled = false;
            this.GenerateReportButton.Enabled = false;
        }

        private void ReportOFAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            var SelectedItem = (GenerateReport)DropDownListOfGenerateReportBy.SelectedItem!;
            if (SelectedItem != null)
            {
                ReportThatSelected = SelectedItem;
                if (SelectedItem == GenerateReport.GenerateReportByYear)
                {
                    YearDropDownList.Enabled = true;
                    MonthDropDownList.Enabled = false;
                    DayDropDownList.Enabled = false;
                }
                else if (SelectedItem == GenerateReport.GenerateReportByMonth)
                {
                    YearDropDownList.Enabled = true;
                    MonthDropDownList.Enabled = true;
                    DayDropDownList.Enabled = false;
                }
                else if (SelectedItem == GenerateReport.GenerateReportByDay)
                {
                    YearDropDownList.Enabled = true;
                    MonthDropDownList.Enabled = true;
                    DayDropDownList.Enabled = true;
                }
            }
            this.GenerateReportButton.Enabled = true;
        }

        private async void GenerateReportButton_Click(object sender, EventArgs e)
        {
            var SelectedItemInReport = ReportThatSelected;
            if (SelectedItemInReport != null)
            {
                if (SelectedItemInReport == GenerateReport.GenerateReportByYear)
                {
                    if (this.YearDropDownList != null)
                    {
                        List<ReportDTO> Items = await UnitOFWork.ReportManager.ReportByYearAsync((int)YearDropDownList.SelectedItem);
                        if (Items != null)
                        {
                            DateText.Text = "Report By Year : " + YearDropDownList.SelectedItem.ToString();
                            this.TotalPriceOfReport.Value = await UnitOFWork.ReportManager.CalculatePriceOFAllReportMedicinesAsync(Items);
                            this.GenerateReportDataGridView.DataSource = Items;
                        }
                        else
                        {
                            MessageBox.Show("No data found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please write year number");
                    }
                }
                else if (SelectedItemInReport == GenerateReport.GenerateReportByMonth)
                {
                    if (this.YearDropDownList.SelectedItem != null && this.MonthDropDownList.SelectedItem != null)
                    {
                        List<ReportDTO> Items = await UnitOFWork.ReportManager.ReportByMonthAsync((int)YearDropDownList.SelectedItem, (int)MonthDropDownList.SelectedValue);
                        if (Items != null)
                        {
                            DateText.Text = "Report By Month : " + YearDropDownList.SelectedItem.ToString() + " - " + MonthDropDownList.SelectedValue.ToString();
                            this.TotalPriceOfReport.Value = await UnitOFWork.ReportManager.CalculatePriceOFAllReportMedicinesAsync(Items);
                            this.GenerateReportDataGridView.DataSource = Items;
                        }
                        else
                        {
                            MessageBox.Show("No data found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please write year and month number");
                    }
                }
                else if (SelectedItemInReport == GenerateReport.GenerateReportByDay)
                {
                    if (this.YearDropDownList.SelectedItem != null && this.MonthDropDownList.SelectedItem != null && this.DayDropDownList.SelectedItem != null)
                    {
                        List<ReportDTO> Items = await UnitOFWork.ReportManager.ReportByDayAsync((int)YearDropDownList.SelectedItem, (int)MonthDropDownList?.SelectedValue, (int)DayDropDownList.SelectedItem);
                        if (Items != null)
                        {
                            DateText.Text = "Report By Day : " + YearDropDownList.SelectedItem.ToString() + " - " + MonthDropDownList.SelectedValue.ToString() + " - " + DayDropDownList.SelectedItem.ToString();
                            this.TotalPriceOfReport.Value = await UnitOFWork.ReportManager.CalculatePriceOFAllReportMedicinesAsync(Items);
                            this.GenerateReportDataGridView.DataSource = Items;
                        }
                        else
                        {
                            MessageBox.Show("No data found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please write year , month, day number");
                    }
                }
            }
        }

    }
}
