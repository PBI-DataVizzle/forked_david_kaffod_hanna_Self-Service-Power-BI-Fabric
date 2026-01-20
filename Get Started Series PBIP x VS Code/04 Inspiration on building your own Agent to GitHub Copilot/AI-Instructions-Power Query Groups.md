#Instructions-Power Query Groups.md

In each TMDL I have a partition in M for example
partition Calendar = m
				mode: import
				source =
						let
						    Source = PowerBI.Dataflows(null),
						    #"e9e0a2fb-511a-4b96-a51e-947db2d08967" = Source{[workspaceId="e9e0a2fb-511a-4b96-a51e-947db2d08967"]}[Data],
						    #"c2f4a3a1-354a-4ae4-a25a-6f3b1e3ff93f" = #"e9e0a2fb-511a-4b96-a51e-947db2d08967"{[dataflowId="c2f4a3a1-354a-4ae4-a25a-6f3b1e3ff93f"]}[Data],
						    Calendar1 = #"c2f4a3a1-354a-4ae4-a25a-6f3b1e3ff93f"{[entity="Calendar"]}[Data]
						in
						    Calendar1
							
After mode: Add a queryGroup: for each TMDL files to group my tables in to table groups as
Dimension: One-side tables relationships
Fact: Many-side relationship
Staging: Table not loaded into Power BI desktop but used for merge/append to another table
Meta Data & Organize: for measure group global/local, last refresh or table.profile
Functions & Parameters: for any M functions or M parameters

Don't use any Powershell or Tabular Editor to perform this

	## Query groups — exact placement and examples

	Add a `queryGroup` property immediately after the `mode:` line in the partition (or query) block inside each `.tmdl`/`.tmdx` file. This is a simple text edit — open the file in your editor, insert the line, save, and reload the model in Power BI Desktop.

	Placement (copy-paste safe example)

	```text
	partition Calendar = m
		mode: import
		queryGroup: Dimension
		source =
			let
				Source = PowerBI.Dataflows(null),
				...
			in
				Calendar1
	```

	Notes:
	- Place `queryGroup:` directly after `mode:` and before `source =` (or the M expression). Keep the indentation consistent with the surrounding file.
	- `queryGroup` is simply a text label used by Power BI/Project tooling to group queries in the UI; the exact behavior depends on the consumer tool, but adding this property is safe for the project files.

	Recommended groups and when to use them
	- Dimension — one-side tables (lookup/dimension tables used to filter facts). Example: `Calendar`, `Product`, `Region Country`, `Retailer`.
	- Fact — many-side tables (transaction/fact tables). Example: `Sales`, `Sales Budget`.
	- Staging — queries not loaded to the model but used inside M to prepare data (e.g., raw extracts, intermediate merges). Add `queryGroup: Staging` for those queries.

	### QueryGroup declarations to add into `definition/model.tmdl`

	If your partitions reference query groups by name (for example `queryGroup: Facts`), the model must declare those QueryGroup objects so the references resolve during project deserialization. Add the following minimal declarations to `definition/model.tmdl` (copy-paste safe):

	```text
	queryGroup Dimensions

	queryGroup Facts

	queryGroup 'Measure Groups'

	queryGroup 'Parameter Tables'
	```

	- Meta Data & Organize — utility or documentation tables: measure groups, `Last Refresh`, `table.profile` outputs, model documentation. Use `queryGroup: Meta Data & Organize`.
	- Functions & Parameters — any M functions or parameter queries. Use `queryGroup: Functions & Parameters`.

	Examples for each group

	Dimension example (Calendar):
	```text
	partition Calendar = m
		mode: import
		queryGroup: Dimension
		source =
			let
				...
			in
				Calendar1
	```

	Fact example (Sales):
	```text
	partition Sales = m
		mode: import
		queryGroup: Fact
		source =
			let
				...
			in
				Sales1
	```

	Staging example (not loaded):
	```text
	partition Staging_RawCustomers = m
		mode: import
		queryGroup: Staging
		source =
			let
				...
			in
				RawCustomers
	```

	Meta Data & Organize example:
	```text
	partition Model_Documentation = m
		mode: import
		queryGroup: Meta Data & Organize
		source =
			let
				...
			in
				ModelDoc
	```

	Functions & Parameters example:
	```text
	partition fn_GetCalendar = m
		mode: import
		queryGroup: Functions & Parameters
		source =
			let
				...
			in
				fn_GetCalendar
	```

	Manual workflow (safe and recommended)
	1. Back up the `.tmdl` file you will edit.
	2. Open the `.tmdl` file in your editor (VS Code is recommended).
	3. Find the partition or query block (search for `partition <TableName> = m` or `mode: import`).
	4. Insert `queryGroup: <GroupName>` immediately after the `mode:` line.
	5. Save the file and reload Power BI Desktop or the Power BI project tooling so the UI picks up the new grouping.

	Tips
	- Use consistent group labels across your models (exact spelling) so tooling groups them predictably.
	- If you bulk-edit many files, consider using your editor's multi-file find-and-replace or a safe extension (no scripts required).
	- Always keep a backup before running large multi-file edits.

	If you want, I can add a small checklist snippet to your README with an example VS Code find/replace pattern (no scripts) to speed bulk edits.