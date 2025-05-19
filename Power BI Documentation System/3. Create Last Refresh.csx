// ************CREATE A LAST REFRESH COLUMN**************
// 
var lastrefreshtable = Model.AddTable("Last Refresh");
Model.Tables["Last Refresh"].Partitions["Last Refresh"].Expression = "let\n    Source = DateTimeZone.FixedLocalNow()\nin\n    Source";
var dataColumn = lastrefreshtable.AddDataColumn("Last Refresh");
dataColumn.IsHidden = true;
dataColumn.DisplayFolder = "Columns";
dataColumn.DataType = DataType.DateTime;
dataColumn.SourceColumn = "Last Refresh";
var measure = lastrefreshtable.AddMeasure("Last Refreshed");
measure.FormatString = "MMM DD hh:mm";
measure.Expression = "FORMAT ( MAX ( 'Last Refresh'[Last Refresh] ), \"MMM DD, HH:MM\" )";