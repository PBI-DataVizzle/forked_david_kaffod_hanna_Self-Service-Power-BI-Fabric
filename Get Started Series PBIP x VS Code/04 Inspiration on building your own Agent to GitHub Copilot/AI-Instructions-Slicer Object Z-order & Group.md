# Understanding and Renaming GUIDs in Power BI JSON Files

This guide explains how to interpret and rename Page, Visual, and Bookmark GUIDs in Power BI JSON files by mapping them to their corresponding visual objects and names.

## 1. Locate the JSON Files in the PBIP Report Format (PBIR)

For each visualType = Slicer do the following

Go into visual and nativeQueryRef and get value fx Retailer Group
Add or update visualContainerObjects with value Slicer - Retailer Group
So the pattern is VisualType - nativeQueryRef

If there is already a visualContainerObjects then update that, there can't be two inputs on visualContainerObjects.
Utilize info on syncgroup as slicers are connected across pages

Do this for all slicers on all report pages

"visual": {
    "visualType": "slicer",
    "query": {
      "queryState": {
        "Values": {
          "projections": [
            {
              "field": {
                "Column": {
                  "Expression": {
                    "SourceRef": {
                      "Entity": "Dim Retailer"
                    }
                  },
                  "Property": "Retailer Group"
                }
              },
              "queryRef": "Dim Retailer.Retailer Group",
              "nativeQueryRef": "Retailer Group",
              "active": true
            }
          ]
        }
      }
    },

     "visualContainerObjects": {
      "title": [
        {
          "properties": {
            "text": {
              "expr": {
                "Literal": {
                  "Value": "'Slicer - Retailer Group'"
                }
              }
            }
          }
        }
      ]
    },


For the value in the Z-order in the selection pane. Then look at the coordinates of the slicers from top left to top right or from top left to bottom left.

I'm going to reorder z values using on-canvas coordinates (sort by y asc then x asc) and assign descending z starting from the page's current max z; outcome: slicers will match spatial order

"position": {
    "x": 0,
    "y": 215.79877634262408,
    "z": 4250,
    "height": 198.39564921821889,
    "width": 190.56424201223658,
    "tabOrder": 2000

So the Z order will be higher for those slicers that are appearing first
I want to match the report position and order of my slicers to match the Z order in the selection pane
Thus only edit Z, don't change x, Y or height or Witdth

Group elements.
Can you now put the slicers in a group with displayname "Slicers". Remember to add that info for each visual.json with parentGroupName and add a new with visual.json with visualGroup
Make sure all slicers are included in a group

Don't use PowerShell or Tabular Editor