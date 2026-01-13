using System.Windows.Forms;

namespace SGU.Tools.CronExpressionBuilder.Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCopy = new Button();
            btnClear = new Button();
            btnTest = new Button();
            lblTitle = new Label();
            panelTestControls = new Panel();
            grpParseTest = new GroupBox();
            lblParseTest = new Label();
            btnParseTest = new Button();
            txtParseExpression = new TextBox();
            grpTestExpressions = new GroupBox();
            btnLastDayQuarter = new Button();
            btnFirstMondayNoon = new Button();
            btnEvery15MinBusinessHours = new Button();
            btnWeekdaysAt9AM = new Button();
            btnDailyAt9AM = new Button();
            btnEveryHour = new Button();
            btnEveryMinute = new Button();
            btnEverySecond = new Button();
            grpFormat = new GroupBox();
            rbHangfire6 = new RadioButton();
            rbQuartz6 = new RadioButton();
            rbQuartz7 = new RadioButton();
            grpVisibility = new GroupBox();
            chkShowDescription = new CheckBox();
            chkShowFormatSelector = new CheckBox();
            cronControl = new CronExpressionControl();
            panel1.SuspendLayout();
            panelTestControls.SuspendLayout();
            grpParseTest.SuspendLayout();
            grpTestExpressions.SuspendLayout();
            grpFormat.SuspendLayout();
            grpVisibility.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnTest);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1184, 50);
            panel1.TabIndex = 1;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopy.Location = new System.Drawing.Point(944, 12);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(100, 26);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy Expression";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(838, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(100, 26);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTest.Location = new System.Drawing.Point(1050, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(120, 26);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test Expression";
            btnTest.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(297, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cron Expression Builder - Demo";
            // 
            // panelTestControls
            // 
            panelTestControls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTestControls.AutoScroll = true;
            panelTestControls.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            panelTestControls.BorderStyle = BorderStyle.FixedSingle;
            panelTestControls.Controls.Add(grpParseTest);
            panelTestControls.Controls.Add(grpTestExpressions);
            panelTestControls.Controls.Add(grpFormat);
            panelTestControls.Controls.Add(grpVisibility);
            panelTestControls.Location = new System.Drawing.Point(778, 60);
            panelTestControls.Name = "panelTestControls";
            panelTestControls.Size = new System.Drawing.Size(394, 540);
            panelTestControls.TabIndex = 2;
            // 
            // grpParseTest
            // 
            grpParseTest.Controls.Add(lblParseTest);
            grpParseTest.Controls.Add(btnParseTest);
            grpParseTest.Controls.Add(txtParseExpression);
            grpParseTest.Location = new System.Drawing.Point(12, 189);
            grpParseTest.Name = "grpParseTest";
            grpParseTest.Size = new System.Drawing.Size(360, 112);
            grpParseTest.TabIndex = 4;
            grpParseTest.TabStop = false;
            grpParseTest.Text = "Parse Test";
            // 
            // lblParseTest
            // 
            lblParseTest.AutoSize = true;
            lblParseTest.Location = new System.Drawing.Point(15, 25);
            lblParseTest.Name = "lblParseTest";
            lblParseTest.Size = new System.Drawing.Size(249, 15);
            lblParseTest.TabIndex = 2;
            lblParseTest.Text = "Enter a cron expression to parse and populate:";
            // 
            // btnParseTest
            // 
            btnParseTest.Location = new System.Drawing.Point(15, 73);
            btnParseTest.Name = "btnParseTest";
            btnParseTest.Size = new System.Drawing.Size(330, 26);
            btnParseTest.TabIndex = 1;
            btnParseTest.Text = "Parse Expression";
            btnParseTest.UseVisualStyleBackColor = true;
            // 
            // txtParseExpression
            // 
            txtParseExpression.Font = new System.Drawing.Font("Consolas", 9F);
            txtParseExpression.Location = new System.Drawing.Point(15, 45);
            txtParseExpression.Name = "txtParseExpression";
            txtParseExpression.Size = new System.Drawing.Size(330, 22);
            txtParseExpression.TabIndex = 0;
            txtParseExpression.Text = "0 */15 9-17 ? * MON-FRI *";
            // 
            // grpTestExpressions
            // 
            grpTestExpressions.Controls.Add(btnLastDayQuarter);
            grpTestExpressions.Controls.Add(btnFirstMondayNoon);
            grpTestExpressions.Controls.Add(btnEvery15MinBusinessHours);
            grpTestExpressions.Controls.Add(btnWeekdaysAt9AM);
            grpTestExpressions.Controls.Add(btnDailyAt9AM);
            grpTestExpressions.Controls.Add(btnEveryHour);
            grpTestExpressions.Controls.Add(btnEveryMinute);
            grpTestExpressions.Controls.Add(btnEverySecond);
            grpTestExpressions.Location = new System.Drawing.Point(12, 307);
            grpTestExpressions.Name = "grpTestExpressions";
            grpTestExpressions.Size = new System.Drawing.Size(360, 229);
            grpTestExpressions.TabIndex = 3;
            grpTestExpressions.TabStop = false;
            grpTestExpressions.Text = "Quick Test Expressions";
            // 
            // btnLastDayQuarter
            // 
            btnLastDayQuarter.Location = new System.Drawing.Point(15, 185);
            btnLastDayQuarter.Name = "btnLastDayQuarter";
            btnLastDayQuarter.Size = new System.Drawing.Size(330, 26);
            btnLastDayQuarter.TabIndex = 7;
            btnLastDayQuarter.Text = "Last Day of Quarter";
            btnLastDayQuarter.UseVisualStyleBackColor = true;
            // 
            // btnFirstMondayNoon
            // 
            btnFirstMondayNoon.Location = new System.Drawing.Point(15, 153);
            btnFirstMondayNoon.Name = "btnFirstMondayNoon";
            btnFirstMondayNoon.Size = new System.Drawing.Size(330, 26);
            btnFirstMondayNoon.TabIndex = 6;
            btnFirstMondayNoon.Text = "First Monday at Noon";
            btnFirstMondayNoon.UseVisualStyleBackColor = true;
            // 
            // btnEvery15MinBusinessHours
            // 
            btnEvery15MinBusinessHours.Location = new System.Drawing.Point(15, 121);
            btnEvery15MinBusinessHours.Name = "btnEvery15MinBusinessHours";
            btnEvery15MinBusinessHours.Size = new System.Drawing.Size(330, 26);
            btnEvery15MinBusinessHours.TabIndex = 5;
            btnEvery15MinBusinessHours.Text = "Every 15 Min (Business Hours)";
            btnEvery15MinBusinessHours.UseVisualStyleBackColor = true;
            // 
            // btnWeekdaysAt9AM
            // 
            btnWeekdaysAt9AM.Location = new System.Drawing.Point(15, 89);
            btnWeekdaysAt9AM.Name = "btnWeekdaysAt9AM";
            btnWeekdaysAt9AM.Size = new System.Drawing.Size(330, 26);
            btnWeekdaysAt9AM.TabIndex = 4;
            btnWeekdaysAt9AM.Text = "Weekdays at 9 AM";
            btnWeekdaysAt9AM.UseVisualStyleBackColor = true;
            // 
            // btnDailyAt9AM
            // 
            btnDailyAt9AM.Location = new System.Drawing.Point(185, 57);
            btnDailyAt9AM.Name = "btnDailyAt9AM";
            btnDailyAt9AM.Size = new System.Drawing.Size(160, 26);
            btnDailyAt9AM.TabIndex = 3;
            btnDailyAt9AM.Text = "Daily at 9 AM";
            btnDailyAt9AM.UseVisualStyleBackColor = true;
            // 
            // btnEveryHour
            // 
            btnEveryHour.Location = new System.Drawing.Point(15, 57);
            btnEveryHour.Name = "btnEveryHour";
            btnEveryHour.Size = new System.Drawing.Size(160, 26);
            btnEveryHour.TabIndex = 2;
            btnEveryHour.Text = "Every Hour";
            btnEveryHour.UseVisualStyleBackColor = true;
            // 
            // btnEveryMinute
            // 
            btnEveryMinute.Location = new System.Drawing.Point(185, 25);
            btnEveryMinute.Name = "btnEveryMinute";
            btnEveryMinute.Size = new System.Drawing.Size(160, 26);
            btnEveryMinute.TabIndex = 1;
            btnEveryMinute.Text = "Every Minute";
            btnEveryMinute.UseVisualStyleBackColor = true;
            // 
            // btnEverySecond
            // 
            btnEverySecond.Location = new System.Drawing.Point(15, 25);
            btnEverySecond.Name = "btnEverySecond";
            btnEverySecond.Size = new System.Drawing.Size(160, 26);
            btnEverySecond.TabIndex = 0;
            btnEverySecond.Text = "Every Second";
            btnEverySecond.UseVisualStyleBackColor = true;
            // 
            // grpFormat
            // 
            grpFormat.Controls.Add(rbHangfire6);
            grpFormat.Controls.Add(rbQuartz6);
            grpFormat.Controls.Add(rbQuartz7);
            grpFormat.Location = new System.Drawing.Point(10, 85);
            grpFormat.Name = "grpFormat";
            grpFormat.Size = new System.Drawing.Size(360, 98);
            grpFormat.TabIndex = 1;
            grpFormat.TabStop = false;
            grpFormat.Text = "Format (Programmatic)";
            // 
            // rbHangfire6
            // 
            rbHangfire6.AutoSize = true;
            rbHangfire6.Location = new System.Drawing.Point(15, 70);
            rbHangfire6.Name = "rbHangfire6";
            rbHangfire6.Size = new System.Drawing.Size(128, 19);
            rbHangfire6.TabIndex = 2;
            rbHangfire6.Text = "Hangfire 5-position";
            rbHangfire6.UseVisualStyleBackColor = true;
            // 
            // rbQuartz6
            // 
            rbQuartz6.AutoSize = true;
            rbQuartz6.Location = new System.Drawing.Point(15, 45);
            rbQuartz6.Name = "rbQuartz6";
            rbQuartz6.Size = new System.Drawing.Size(117, 19);
            rbQuartz6.TabIndex = 1;
            rbQuartz6.Text = "Quartz 6-position";
            rbQuartz6.UseVisualStyleBackColor = true;
            // 
            // rbQuartz7
            // 
            rbQuartz7.AutoSize = true;
            rbQuartz7.Checked = true;
            rbQuartz7.Location = new System.Drawing.Point(15, 20);
            rbQuartz7.Name = "rbQuartz7";
            rbQuartz7.Size = new System.Drawing.Size(166, 19);
            rbQuartz7.TabIndex = 0;
            rbQuartz7.TabStop = true;
            rbQuartz7.Text = "Quartz 7-position (Default)";
            rbQuartz7.UseVisualStyleBackColor = true;
            // 
            // grpVisibility
            // 
            grpVisibility.Controls.Add(chkShowDescription);
            grpVisibility.Controls.Add(chkShowFormatSelector);
            grpVisibility.Location = new System.Drawing.Point(10, 10);
            grpVisibility.Name = "grpVisibility";
            grpVisibility.Size = new System.Drawing.Size(360, 75);
            grpVisibility.TabIndex = 0;
            grpVisibility.TabStop = false;
            grpVisibility.Text = "Selector Visibility";
            // 
            // chkShowDescription
            // 
            chkShowDescription.AutoSize = true;
            chkShowDescription.Checked = true;
            chkShowDescription.CheckState = CheckState.Checked;
            chkShowDescription.Location = new System.Drawing.Point(15, 48);
            chkShowDescription.Name = "chkShowDescription";
            chkShowDescription.Size = new System.Drawing.Size(118, 19);
            chkShowDescription.TabIndex = 1;
            chkShowDescription.Text = "Show Description";
            chkShowDescription.UseVisualStyleBackColor = true;
            
            // 
            // chkShowFormatSelector
            // 
            chkShowFormatSelector.AutoSize = true;
            chkShowFormatSelector.Location = new System.Drawing.Point(15, 25);
            chkShowFormatSelector.Name = "chkShowFormatSelector";
            chkShowFormatSelector.Size = new System.Drawing.Size(141, 19);
            chkShowFormatSelector.TabIndex = 0;
            chkShowFormatSelector.Text = "Show Format Selector";
            chkShowFormatSelector.UseVisualStyleBackColor = true;
            // 
            // cronControl
            // 
            cronControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cronControl.BorderStyle = BorderStyle.FixedSingle;
            cronControl.ExpressionString = "* * * ? * * *";
            cronControl.Location = new System.Drawing.Point(12, 60);
            cronControl.Margin = new Padding(4, 3, 4, 3);
            cronControl.Name = "cronControl";
            cronControl.Size = new System.Drawing.Size(760, 540);
            cronControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1184, 611);
            Controls.Add(panelTestControls);
            Controls.Add(panel1);
            Controls.Add(cronControl);
            MinimumSize = new System.Drawing.Size(1200, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cron Expression Builder - Demolication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTestControls.ResumeLayout(false);
            grpParseTest.ResumeLayout(false);
            grpParseTest.PerformLayout();
            grpTestExpressions.ResumeLayout(false);
            grpFormat.ResumeLayout(false);
            grpFormat.PerformLayout();
            grpVisibility.ResumeLayout(false);
            grpVisibility.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panelTestControls;
        private System.Windows.Forms.GroupBox grpVisibility;
        private System.Windows.Forms.CheckBox chkShowFormatSelector;
        private System.Windows.Forms.CheckBox chkShowDescription;
        private System.Windows.Forms.GroupBox grpTestExpressions;
        private System.Windows.Forms.Button btnLastDayQuarter;
        private System.Windows.Forms.Button btnFirstMondayNoon;
        private System.Windows.Forms.Button btnEvery15MinBusinessHours;
        private System.Windows.Forms.Button btnWeekdaysAt9AM;
        private System.Windows.Forms.Button btnDailyAt9AM;
        private System.Windows.Forms.Button btnEveryHour;
        private System.Windows.Forms.Button btnEveryMinute;
        private System.Windows.Forms.Button btnEverySecond;
        private CronExpressionControl cronControl;
        private GroupBox grpParseTest;
        private Label lblParseTest;
        private Button btnParseTest;
        private TextBox txtParseExpression;
        private GroupBox grpFormat;
        private RadioButton rbHangfire6;
        private RadioButton rbQuartz6;
        private RadioButton rbQuartz7;
    }
}

