# Cron Expression Generator - Demo Application

This is a demo WinForms application for the `CronExpressionControl` component.

![Demo Screenshot](docs/demo-screenshot.png)

## Features

- **Interactive UI**: Test all features of the Cron Expression Generator control
- **Real-time Updates**: See the cron expression and description update as you configure settings
- **Copy to Clipboard**: Easily copy the generated expression
- **Expression Testing**: View detailed breakdown of the expression fields
- **Reset**: Clear the expression back to default values

## How to Run

1. Set `SGU_Tools_CronExpressionBuilder.Demo` as the startup project
2. Press F5 or click Run in Visual Studio
3. The demo application window will open

## How to Use

### Tabs
Navigate through the six tabs to configure different parts of the cron expression:

1. **Seconds**: Configure second-level scheduling (0-59)
2. **Minutes**: Configure minute-level scheduling (0-59)
3. **Hours**: Configure hour-level scheduling (0-23)
4. **Day**: Configure day scheduling with advanced options:
   - Day of week or day of month
   - Last day, last weekday, nth occurrence
   - Nearest weekday, days before end of month
5. **Month**: Configure month scheduling (JAN-DEC)
6. **Year**: Configure year scheduling

### Bottom Display
- **Cron Expression**: Shows the generated Quartz 7-field cron expression
- **Description**: Human-readable explanation of when the expression will execute

### Toolbar Buttons

- **Clear**: Resets the expression to default values (0 0 0 ? * * *)
- **Copy Expression**: Copies the cron expression to the clipboard
- **Test Expression**: Shows a detailed breakdown of all fields and validation status

## Example Usage

### Every Day at Midnight
1. Go to **Seconds** tab ? Select "Every second" (default is "0")
2. Go to **Minutes** tab ? Select "Every minute" (default is "0")
3. Go to **Hours** tab ? Select "Every hour" (default is "0")
4. Go to **Day** tab ? Select "Every day"
5. Result: `0 0 0 ? * * *`

### Every Weekday at 9 AM
1. Seconds: `0`
2. Minutes: `0`
3. Hours: Select "Specific hour" ? Check `09`
4. Day: Select "Specific day of the week" ? Check Monday-Friday
5. Result: `0 0 9 ? * 2,3,4,5,6 *`

### First Monday of Every Month at Noon
1. Seconds: `0`
2. Minutes: `0`
3. Hours: Select "Specific hour" ? Check `12`
4. Day: Select "On the" ? Choose "1st" ? "Monday" ? "of the month"
5. Result: `0 0 12 ? * 2#1 *`

## Testing Scenarios

Use this application to test:
- ? All tab configurations
- ? Expression building accuracy
- ? Description generation
- ? UI responsiveness
- ? Edge cases (last day, nth occurrence, etc.)
- ? Copy/paste functionality
- ? Expression validation

## Notes

- The control generates **Quartz 7-field** cron expressions by default
- The format is: `second minute hour dayOfMonth month dayOfWeek year`
- Special characters supported: `* ? - , / L W #`
- Day fields use `?` to indicate "no specific value"
