using System;
using System.Windows.Forms;
using SGU.Tools;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CronExpressionExamples
#pragma warning restore IDE0130
{
    /// <summary>
    /// Examples demonstrating all ways to get and set cron expressions and descriptions
    /// using the CronExpressionControl.
    /// </summary>
    public class CronExpressionControlExamples
    {
        private readonly CronExpressionControl cronControl;

        public CronExpressionControlExamples()
        {
            cronControl = new CronExpressionControl();
        }

        #region Getting Expression - Multiple Ways

        /// <summary>
        /// Example 1: Get expression using the ExpressionString property (RECOMMENDED)
        /// </summary>
        public string GetExpressionUsingProperty()
        {
            // Simple and clean
            string expression = cronControl.ExpressionString;
            
            Console.WriteLine($"Expression: {expression}");
            // Output example: "0 0 12 ? * * *"
            
            return expression;
        }

        /// <summary>
        /// Example 2: Get expression using the legacy GetExpression() method
        /// </summary>
        public string GetExpressionUsingMethod()
        {
            // Legacy method - still works but property is preferred
            string expression = cronControl.GetExpression();
            
            return expression;
        }

        /// <summary>
        /// Example 3: Get expression object for detailed access
        /// </summary>
        public void GetExpressionObject()
        {
            CronExpression expr = cronControl.Expression;
            
            // Access individual fields
            Console.WriteLine($"Seconds: {expr.Second}");
            Console.WriteLine($"Minutes: {expr.Minute}");
            Console.WriteLine($"Hours: {expr.Hour}");
            Console.WriteLine($"Day of Month: {expr.DayOfMonth}");
            Console.WriteLine($"Month: {expr.Month}");
            Console.WriteLine($"Day of Week: {expr.DayOfWeek}");
            Console.WriteLine($"Year: {expr.Year}");
            Console.WriteLine($"Format: {expr.Format}");
        }

        #endregion

        #region Setting Expression - Multiple Ways

        /// <summary>
        /// Example 4: Set expression using ExpressionString property (RECOMMENDED)
        /// Auto-detects format based on field count
        /// </summary>
        public void SetExpressionUsingProperty()
        {
            try
            {
                // Automatically detects Quartz 7 format (7 fields)
                cronControl.ExpressionString = "0 0 12 ? * * *";
                
                // Automatically detects Quartz 6 format (6 fields)
                cronControl.ExpressionString = "0 0 12 ? * *";
                
                // Automatically detects Hangfire 6 format (5 fields)
                cronControl.ExpressionString = "0 12 ? * *";
                
                Console.WriteLine($"Format detected: {cronControl.Format}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid expression: {ex.Message}");
            }
        }

        /// <summary>
        /// Example 5: Set expression using legacy SetExpression() method
        /// Always assumes Quartz 7 format
        /// </summary>
        public void SetExpressionUsingMethod()
        {
            // Legacy method - shows MessageBox on error
            cronControl.SetExpression("0 0 12 ? * * *");
        }

        /// <summary>
        /// Example 6: Set expression using Expression property with object
        /// </summary>
        public void SetExpressionUsingObject()
        {
            var newExpr = new CronExpression(CronExpressionFormat.Quartz7)
            {
                Second = "0",
                Minute = "30",
                Hour = "9",
                DayOfMonth = "?",
                Month = "*",
                DayOfWeek = "MON-FRI",
                Year = "*"
            };
            
            cronControl.Expression = newExpr;
            
            Console.WriteLine($"Set to: {cronControl.ExpressionString}");
            // Output: "0 30 9 ? * MON-FRI *"
        }

        /// <summary>
        /// Example 7: Set expression using CronExpressionBuilder
        /// </summary>
        public void SetExpressionUsingBuilder()
        {
            var builder = new CronExpressionBuilder(CronExpressionFormat.Quartz7)
                .WithSecond("0")
                .WithMinute("*/15")  // Every 15 minutes
                .WithHour("9-17")    // Between 9 AM and 5 PM
                .WithDayOfMonth("?")
                .WithMonth("*")
                .WithDayOfWeek("MON-FRI")  // Weekdays only
                .WithYear("*");
            
            cronControl.Expression = builder.Build();
            
            Console.WriteLine($"Built expression: {cronControl.ExpressionString}");
            // Output: "0 */15 9-17 ? * MON-FRI *"
        }

        #endregion

        #region Getting Description - Multiple Ways

        /// <summary>
        /// Example 8: Get auto-generated description (RECOMMENDED)
        /// </summary>
        public string GetDescription()
        {
            // Get the human-readable description
            string description = cronControl.Description;
            
            Console.WriteLine(description);
            // Output example: "at second 0, every minute at minute 30, 
            //                  every hour at hour 9, every day between 
            //                  Monday and Friday"
            
            return description;
        }

        /// <summary>
        /// Example 9: Get the displayed description text
        /// </summary>
        public string GetDescriptionText()
        {
            // Get whatever is currently displayed in the control
            string displayedText = cronControl.DescriptionText;
            
            return displayedText;
        }

        /// <summary>
        /// Example 10: Generate description using custom translator
        /// </summary>
        public string GetDescriptionWithCustomTranslator()
        {
            // Use a custom translator
            cronControl.Translator = new CronTranslator();
            
            string description = cronControl.Description;
            
            return description;
        }

        #endregion

        #region Setting Description Display

        /// <summary>
        /// Example 11: Override the description display text
        /// Note: This only changes the display, not the expression
        /// </summary>
        public void SetCustomDescriptionText()
        {
            // Set custom text (will be overwritten when expression changes)
            cronControl.DescriptionText = "Custom schedule: Every weekday at 9:30 AM";
            
            Console.WriteLine($"Display shows: {cronControl.DescriptionText}");
            Console.WriteLine($"Actual expression: {cronControl.ExpressionString}");
        }

        /// <summary>
        /// Example 12: Add metadata to description
        /// </summary>
        public void AddMetadataToDescription()
        {
            string baseDescription = cronControl.Description;
            string enhancedDescription = $"{baseDescription}\n\n" +
                                        $"Created: {DateTime.Now:g}\n" +
                                        $"Format: {cronControl.Format}\n" +
                                        $"Next execution: (calculating...)";
            
            cronControl.DescriptionText = enhancedDescription;
        }

        #endregion

        #region Complete Workflows

        /// <summary>
        /// Example 13: Load expression from database and display
        /// </summary>
        public void LoadFromDatabase(string savedExpression)
        {
            try
            {
                // Set the expression (format auto-detected)
                cronControl.ExpressionString = savedExpression;
                
                // Get and display the description
                string description = cronControl.Description;
                
                Console.WriteLine($"Loaded: {savedExpression}");
                Console.WriteLine($"Means: {description}");
                Console.WriteLine($"Format: {cronControl.Format}");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    $"Failed to load expression from database:\n{ex.Message}",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Example 14: Save expression with description to database
        /// </summary>
        public ScheduleRecord SaveToDatabase()
        {
            var record = new ScheduleRecord
            {
                CronExpression = cronControl.ExpressionString,
                Description = cronControl.Description,
                Format = cronControl.Format.ToString(),
                CreatedDate = DateTime.UtcNow,
                IsActive = true
            };
            
            // Save record to database...
            Console.WriteLine($"Saving: {record.CronExpression}");
            Console.WriteLine($"Description: {record.Description}");
            
            return record;
        }

        /// <summary>
        /// Example 15: Copy expression and description to clipboard
        /// </summary>
        public void CopyToClipboard()
        {
            string expression = cronControl.ExpressionString;
            string description = cronControl.Description;
            
            string clipboardText = $"Cron Expression:\n{expression}\n\n" +
                                  $"Description:\n{description}\n\n" +
                                  $"Format: {cronControl.Format}";
            
            Clipboard.SetText(clipboardText);
            
            MessageBox.Show(
                "Expression and description copied to clipboard!",
                "Copied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Example 16: Validate user input
        /// </summary>
        public bool ValidateUserInput(string userExpression)
        {
            try
            {
                // Try to set the expression
                cronControl.ExpressionString = userExpression;
                
                // If we got here, it's valid
                MessageBox.Show(
                    $"Valid expression!\n\n" +
                    $"Description: {cronControl.Description}\n\n" +
                    $"Format: {cronControl.Format}",
                    "Validation Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                return true;
            }
            catch (ArgumentException ex)
            {
                // Invalid expression
                MessageBox.Show(
                    $"Invalid cron expression:\n\n{ex.Message}",
                    "Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                return false;
            }
        }

        /// <summary>
        /// Example 17: Convert between formats
        /// </summary>
        public void ConvertFormat(CronExpressionFormat targetFormat)
        {
            string originalExpression = cronControl.ExpressionString;
            CronExpressionFormat originalFormat = cronControl.Format;
            
            // Change format
            cronControl.Format = targetFormat;
            
            string convertedExpression = cronControl.ExpressionString;
            
            Console.WriteLine($"Original ({originalFormat}): {originalExpression}");
            Console.WriteLine($"Converted ({targetFormat}): {convertedExpression}");
            Console.WriteLine($"Description: {cronControl.Description}");
        }

        /// <summary>
        /// Example 18: Monitor changes with events
        /// </summary>
        public void SetupEventHandlers()
        {
            // Subscribe to expression changes
            cronControl.ExpressionChanged += (s, e) =>
            {
                Console.WriteLine($"Expression changed to: {cronControl.ExpressionString}");
                Console.WriteLine($"New description: {cronControl.Description}");
            };
            
            // Subscribe to format changes
            cronControl.FormatChanged += (s, e) =>
            {
                Console.WriteLine($"Format changed to: {cronControl.Format}");
            };
        }

        /// <summary>
        /// Example 19: Export for different schedulers
        /// </summary>
        public string ExportForScheduler(SchedulerType schedulerType)
        {
            switch (schedulerType)
            {
                case SchedulerType.Hangfire:
                    cronControl.Format = CronExpressionFormat.Hangfire5;
                    break;
                    
                case SchedulerType.QuartzNet:
                    cronControl.Format = CronExpressionFormat.Quartz6;
                    break;
                    
                case SchedulerType.QuartzWithYear:
                    cronControl.Format = CronExpressionFormat.Quartz7;
                    break;
            }
            
            string expression = cronControl.ExpressionString;
            string description = cronControl.Description;
            
            Console.WriteLine($"Export for {schedulerType}:");
            Console.WriteLine($"  Expression: {expression}");
            Console.WriteLine($"  Description: {description}");
            
            return expression;
        }

        /// <summary>
        /// Example 20: Build and preview complex expression
        /// </summary>
        public void BuildComplexExpression()
        {
            // User configures the control via UI...
            // Then get everything in one go
            
            var result = new
            {
                Expression = cronControl.ExpressionString,
                Description = cronControl.Description,
                Format = cronControl.Format.ToString(),
                
                // Individual fields for detailed storage
                Fields = cronControl.Expression,
                
                // Validation
                IsValid = cronControl.Expression.IsValid(),
                
                // Display text (may include custom metadata)
                DisplayText = cronControl.DescriptionText
            };
            
            Console.WriteLine($"Expression: {result.Expression}");
            Console.WriteLine($"Description: {result.Description}");
            Console.WriteLine($"Format: {result.Format}");
            Console.WriteLine($"Valid: {result.IsValid}");
        }

        #endregion
    }

    #region Helper Classes

    public class ScheduleRecord
    {
        public string CronExpression { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public enum SchedulerType
    {
        Hangfire,
        QuartzNet,
        QuartzWithYear
    }

    #endregion
}
