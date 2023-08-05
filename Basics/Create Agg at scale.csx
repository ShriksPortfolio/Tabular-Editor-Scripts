-----------------------------------------------------------------------------------------
**Creates all the SUM**
Paste only the below
-----------------------------------------------------------------------------------------


foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "Sum of " + c.Name,                    // Name
    "SUM(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "0.00";
// Provide some documentation:
    newMeasure.Description = "This measure is the sum of column " + c.DaxObjectFullName;
// Hide the base column:
    c.IsHidden = false;
}


-----------------------------------------------------------------------------------------
**Creates all the Averages**
Paste only the below
-----------------------------------------------------------------------------------------

foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "Average of " + c.Name,                    // Name
    "AVERAGE(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "0.00";
// Provide some documentation:
    newMeasure.Description = "This measure is the sum of column " + c.DaxObjectFullName;
// Hide the base column:
    c.IsHidden = true;
}
-----------------------------------------------------------------------------------------





-----------------------------------------------------------------------------------------
**Creates all the Max**
Paste only the below
-----------------------------------------------------------------------------------------

foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "Max of " + c.Name,                    // Name
    "Max(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "0.00";
// Provide some documentation:
    newMeasure.Description = "This measure is the sum of column " + c.DaxObjectFullName;
// Hide the base column:
    c.IsHidden = true;
}







-----------------------------------------------------------------------------------------
**Creates all the Min**
Paste only the below
-----------------------------------------------------------------------------------------
**Creates all the Min**

foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "Min of " + c.Name,                    // Name
    "Min(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "0.00";
// Provide some documentation:
    newMeasure.Description = "This measure is the sum of column " + c.DaxObjectFullName;
// Hide the base column:
    c.IsHidden = true;
}





-----------------------------------------------------------------------------------------
**Creates all the Countrows**
Paste only the below
-----------------------------------------------------------------------------------------
 //Loop through all currently selected tables:
foreach(vartableinSelected.Tables) {
    
    varnewMeasure=table.AddMeasure(
    "# Rows in "+table.Name,                         //Name
    "COUNTROWS("+table.DaxObjectFullName+")"//DAX expression
    );
    
    //Set the format string on the new measure:
    newMeasure.FormatString="0";

    //Provide some documentation:
    newMeasure.Description="This measure is the number of rows in table "+table.DaxObjectFullName;
    
}