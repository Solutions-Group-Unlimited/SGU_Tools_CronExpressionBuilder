using System;
using System.Windows.Forms;

namespace SGU.Tools.CronExpressionBuilder.Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeControlStates();
        }

        private void InitializeEventHandlers()
        {
            btnCopy.Click += BtnCopy_Click;
            btnClear.Click += BtnClear_Click;
            btnTest.Click += BtnTest_Click;
            cronControl.ExpressionChanged += CronControl_ExpressionChanged;
            cronControl.FormatChanged += CronControl_FormatChanged;
            chkShowFormatSelector.CheckedChanged += ChkShowFormatSelector_CheckedChanged;
            chkShowDescription.CheckedChanged += ChkShowDescription_CheckedChanged;

            rbQuartz7.CheckedChanged += RbFormat_CheckedChanged;
            rbQuartz6.CheckedChanged += RbFormat_CheckedChanged;
            rbHangfire6.CheckedChanged += RbFormat_CheckedChanged;

            btnEverySecond.Click += BtnEverySecond_Click;
            btnEveryMinute.Click += BtnEveryMinute_Click;
            btnEveryHour.Click += BtnEveryHour_Click;
            btnDailyAt9AM.Click += BtnDailyAt9AM_Click;
            btnWeekdaysAt9AM.Click += BtnWeekdaysAt9AM_Click;
            btnEvery15MinBusinessHours.Click += BtnEvery15MinBusinessHours_Click;
            btnFirstMondayNoon.Click += BtnFirstMondayNoon_Click;
            btnLastDayQuarter.Click += BtnLastDayQuarter_Click;
            btnParseTest.Click += BtnParseTest_Click;
            UpdateStatusBar();
        }

        private void InitializeControlStates()
        {
            chkShowFormatSelector.Checked = cronControl.ShowFormatSelector;
            chkShowDescription.Checked = cronControl.ShowDescription;

            rbQuartz7.Checked = true;

        }

        private void ChkShowFormatSelector_CheckedChanged(object sender, EventArgs e)
        {
            cronControl.ShowFormatSelector = chkShowFormatSelector.Checked;
        }

        private void ChkShowDescription_CheckedChanged(object sender, EventArgs e)
        {
            cronControl.ShowDescription = chkShowDescription.Checked;
        }



        private void RbFormat_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton?.Checked == true)
            {
                if (radioButton == rbQuartz7)
                    cronControl.Format = CronExpressionFormat.Quartz7;
                else if (radioButton == rbQuartz6)
                    cronControl.Format = CronExpressionFormat.Quartz6;
                else if (radioButton == rbHangfire6)
                    cronControl.Format = CronExpressionFormat.Hangfire5;
            }
        }


        private void BtnEverySecond_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "* * * * * ? *";
        }

        private void BtnEveryMinute_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 * * * * ? *";
        }

        private void BtnEveryHour_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 0 * * * ? *";
        }

        private void BtnDailyAt9AM_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 0 9 * * ? *";
        }

        private void BtnWeekdaysAt9AM_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 0 9 ? * MON-FRI *";
        }

        private void BtnEvery15MinBusinessHours_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 */15 9-17 ? * * *";
        }

        private void BtnFirstMondayNoon_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 0 12 ? * MON#1 *";
        }

        private void BtnLastDayQuarter_Click(object sender, EventArgs e)
        {
            cronControl.ExpressionString = "0 0 0 L MAR,JUN,SEP,DEC ? *";
        }

        private void BtnParseTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParseExpression.Text))
            {
                MessageBox.Show("Please enter a cron expression to parse.", "Parse Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                cronControl.ExpressionString = txtParseExpression.Text;
                MessageBox.Show($"Expression parsed successfully!\n\nExpression: {cronControl.ExpressionString}\n\nDescription: {cronControl.Description}", "Parse Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to parse expression:\n\n{ex.Message}", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CronControl_ExpressionChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void CronControl_FormatChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
            switch (cronControl.Format)
            {
                case CronExpressionFormat.Quartz7: rbQuartz7.Checked = true; break;
                case CronExpressionFormat.Quartz6: rbQuartz6.Checked = true; break;
                case CronExpressionFormat.Hangfire5: rbHangfire6.Checked = true; break;
            }
        }

        private void UpdateStatusBar()
        {
            var formatName = cronControl.Format switch
            {
                CronExpressionFormat.Quartz7 => "Quartz 7",
                CronExpressionFormat.Quartz6 => "Quartz 6",
                CronExpressionFormat.Hangfire5 => "Hangfire 6",
                _ => "Unknown"
            };
            this.Text = $"Cron Expression Builder Demo [{formatName}] - {cronControl.ExpressionString}";
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var textToCopy = $"{cronControl.ExpressionString}\n\n{cronControl.Description}";
                Clipboard.SetText(textToCopy);
                MessageBox.Show($"Cron expression and description copied to clipboard:\n\n{cronControl.ExpressionString}\n\n{cronControl.Description}", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to copy to clipboard:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the cron expression to default values?", "Clear Expression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cronControl.Expression = new CronExpression(cronControl.Format);
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var expression = cronControl.Expression;
                var message = $"Cron Expression:\n{cronControl.ExpressionString}\n\nField Breakdown:\n";
                if (expression.Format != CronExpressionFormat.Hangfire5)
                    message += $"  Seconds:      {expression.Second ?? "N/A"}\n";
                message += $"  Minutes:      {expression.Minute}\n  Hours:        {expression.Hour}\n  Day of Month: {expression.DayOfMonth}\n  Month:        {expression.Month}\n  Day of Week:  {expression.DayOfWeek}\n";
                if (expression.Format == CronExpressionFormat.Quartz7)
                    message += $"  Year:         {expression.Year ?? "N/A"}\n";
                message += $"\nFormat: {expression.Format}\nValid:  {expression.IsValid()}\n\nCurrent Translator: ";
                message += cronControl.Translator is CronTranslator ? "Built-in Translator\n" : "Custom Translator\n";
                message += $"\nUI Configuration:\n  Format Selector Visible:  {cronControl.ShowFormatSelector}\n  Description Visible:      {cronControl.ShowDescription}\n\nDescription:\n{cronControl.Description}";
                MessageBox.Show(message, "Expression Test Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error testing expression:\n{ex.Message}\n\n{ex.StackTrace}", "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

