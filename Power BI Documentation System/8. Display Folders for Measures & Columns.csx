//Go through each table in the model
foreach(var table in Model.Tables) 
{
   if(table.Name != "Date"){
    //First look at columns
     foreach( var column in table.Columns)
        {
        var keySuffix = "Key";
        var columnDateType = column.DataType.ToString();
            //DWCreatedDate column should be hidden in a sepearte folder
            if( column.Name == "DWCreatedDate")
            {
                column.DisplayFolder = "Attributes\\Metadata";   
                column.IsHidden = true;   
            }
            //Numeric columns should not be aggregated and float (double) data type should not be used
            if(column.DataType == DataType.Double || column.DataType == DataType.Decimal ||  column.DataType == DataType.Int64)
            {
                column.DisplayFolder = "Numeric";  
                column.SummarizeBy = AggregateFunction.None;
                if(column.DataType == DataType.Double)
                {
                    column.DataType = DataType.Decimal;
                }
            }
            //Boolean data types into their own folder
            if(column.DataType == DataType.Boolean)
            {
                column.DisplayFolder = "Flags";  
            }
            if(column.DataType == DataType.String)
            {
                column.DisplayFolder = "Attributes";  
            }
            //Keys go into their own display folder, should not be aggregrated and hidden. 
            if(column.UsedInRelationships.Any()) 
            {
                column.DisplayFolder = "Key";
                column.SummarizeBy = AggregateFunction.None;
                column.IsHidden = true;
            }
            //Date keys get their own folder and other dates go in attributes
           if( columnDateType == "DateTime" && column.Name != "DWCreatedDate")
            {
                if(column.UsedInRelationships.Any()) 
                {
                    column.DisplayFolder = "Key";
                    column.IsHidden = true;
                }
                else{
                    column.DisplayFolder = "Dates";
                    
                }
            }}}}