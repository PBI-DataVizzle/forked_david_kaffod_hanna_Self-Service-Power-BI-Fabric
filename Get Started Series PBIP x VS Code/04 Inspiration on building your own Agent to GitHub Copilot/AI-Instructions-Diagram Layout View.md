# Diagram Layouts — reuse instructions

## Info
Don't ask to do it with Tabular Editor or Powershell. 
We work in Power BI Projects format, so by adjusting the diagramLayout.json it will work proper in my Power BI Desktop

𝗖𝗿𝗲𝗮𝘁𝗲 𝗼𝗻𝗲 𝗺𝗼𝗱𝗲𝗹 𝘃𝗶𝗲𝘄 𝗹𝗮𝘆𝗼𝘂𝘁 𝗽𝗲𝗿 𝗳𝗮𝗰𝘁 𝘁𝗮𝗯𝗹𝗲. Find the relationships in the relationships.tmdl in the semantic model folder.
𝗔𝗱𝗱 𝗱𝗶𝗺𝗲𝗻𝘀𝗶𝗼𝗻 𝘁𝗮𝗯𝗹𝗲𝘀 𝗮𝘁 𝘁𝗵𝗲 𝘁𝗼𝗽 𝗮𝗻𝗱 𝗳𝗮𝗰𝘁 𝘁𝗮𝗯𝗹𝗲 𝗯𝗲𝗹𝗼𝘄 - to represent the filter propagation. 
Collapse all table

𝗔𝗱𝗱 𝗮 𝗹𝗮𝘆𝗼𝘂𝘁 𝘃𝗶𝗲𝘄 𝗳𝗼𝗿 𝗮𝗹𝗹 𝗱𝗶𝘀𝗰𝗼𝗻𝗻𝗲𝗰𝘁𝗲𝗱 𝘁𝗮𝗯𝗹𝗲𝘀 as below: 
- `Calculation Groups`
- `Field Parameters`
- `RLS`
- `Measure Groups`
- `Model Documentation with INFO.VIEW`
- `Last Refresh`

The default All Tables needs to be selecteddiagram. This have all tables, but order dimensions in the top, facts at the bottom and all disconnected to the right. Again with proper spacing and all tables collapsed to only focus on keys. 

Don't create another "Model Layout" with all tables - we have the default "All tables" for this.


## How diagram layouts work

Power BI Desktop and Tabular Editor store diagram layout information in JSON (or the TMSL/model metadata). The `diagramLayout.json` file in this workspace follows the format used by the SemanticModel folder. Each diagram object contains `nodes` with `location`, `nodeIndex` (table name), and visual properties.

To reuse these layouts in another project you can:

1. Open the target workspace folder containing the semantic model (or a backup copy of your `.pbix`/model files).
2. Locate the file that contains the diagram layout metadata (in this workspace it is `DAX Model & Report.SemanticModel/diagramLayout.json`). If your target model stores layouts differently, export the model or use Tabular Editor to import or paste the JSON.
3. Copy the diagram object(s) you want (the entire JSON object under `diagrams`) and paste them into the target `diagramLayout.json` `diagrams` array. Ensure:
   - `nodeIndex` values match the table names in the target model. If a table name differs, update `nodeIndex` to the target table name.
   - `nodeLineageTag` values are optional for layout purposes; if you have lineage tags in the target model you can set them, but matching names is sufficient for most tools.
   - Update `ordinal` so it doesn't conflict with existing diagrams in the target model.
4. Save the file and reload the model in the tool (Power BI/Tabular Editor). If the tool doesn't pick up changes automatically, re-open the model or use an import function in Tabular Editor.


## Generic spacing command (equalize dimensions above a fact)

Use this short algorithm to compute even horizontal spacing for N dimension tables above a centered fact table.

Pseudocode (logic only):

```
// Parameters
centerX       = desired center X position for the fact (pixels)
dimCount      = number of dimension tables
dimWidth      = width of dimension node (e.g., 234)
gap           = horizontal gap between dimension nodes (e.g., 60)
topY          = Y coordinate for dimension row (e.g., 20)
factWidth     = width of fact node (e.g., 300)
factY         = Y coordinate for fact row (e.g., 260)

totalWidth = dimCount * dimWidth + (dimCount - 1) * gap
startX = centerX - (totalWidth / 2)

for i in 0 .. dimCount-1:
   x = startX + i * (dimWidth + gap)
   place dimension[i] at (x, topY)

factX = centerX - (factWidth / 2)
place fact at (factX, factY)
```

Practical defaults to start with:
- dimWidth = 234
- gap = 60 (increase for long table names, reduce for compact layouts)
- topY = 20
- factY = 260
- factWidth = 300

Quick spreadsheet formulas (Excel / Google Sheets):
- A1 = centerX
- A2 = dimCount
- A3 = dimWidth
- A4 = gap
- totalWidth (A5) = =A2*A3 + (A2-1)*A4
- startX (A6) = =A1 - (A5/2)
- X position for dimension i (B1, i=1..N): = $A$6 + (i-1)*($A$3+$A$4)

Example (Sales Budget with 3 dims, centerX = 550):
- dimCount=3, dimWidth=234, gap=60 -> totalWidth = 3*234 + 2*60 = 882
- startX = 550 - 882/2 = 109
- dims X positions ≈ 109, 403, 697 (Y = topY)
- factX = 550 - 300/2 = 400 (place fact at (400, 260))

Manual application in Power BI model view:
1. Choose centerX visually (where you want the fact centered on the canvas).
2. Use the spreadsheet or pseudocode to compute each dimension X.
3. Drag each dimension to the computed X (use arrow keys for fine nudges to match exact numbers).
4. Place the fact at factX and factY.

This gives consistent, repeatable spacing you can reuse across models.

## Troubleshooting

- If the diagram doesn't appear after copying, check for JSON syntax errors and that table names match.
- If you only want positions, `nodeLineageTag` can be omitted.
- Back up the original `diagramLayout.json` before editing.


