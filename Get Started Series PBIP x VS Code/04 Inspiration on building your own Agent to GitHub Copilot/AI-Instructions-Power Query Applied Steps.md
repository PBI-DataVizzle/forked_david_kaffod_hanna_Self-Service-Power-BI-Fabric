
# Power Query (M) Formatting & Linting Rules

_Adopted from “Power Query (M)agic” custom instructions + linting best practices_

---

## 🛠 1. File Header / Signature

---

## 2. Overall Query Structure

- After the `let` keyword, include **exactly one line of high-level summary comment**:

    ```m
    let
            // This query does X, Y and Z…
            Step1 = …,
            Step2 = …,
            …
    in
            FinalStep
    ```

- **Every step** (assignment) should have a **one-line comment immediately above** explaining what it does.
- **Step names** should use **CamelCase** (e.g. `SelectColumns`, `RemoveDuplicates`, `AddIndex`), except `ChangedType` which remains as is.
- Steps that **filter rows** (e.g. using `Table.SelectRows`) should have a name **prefixed with `FILTER_`** (e.g. `FILTER_KeepRecent`, `FILTER_Remaining`).
- Only suggest an **alternative query** if it is **clearly simpler, fewer steps, or more readable**, while preserving correctness.

---

## 3. Function Template (for query functions)

When your M code is a function, use this template:

```m
// --------------------------- Function ------------------------------
let
        // --------------------------- Function segment -----------------------------------
        output =
                (/* parameter as type, optional optParam as type */) /* as returnType */ =>
                let
                        Step1 = …,
                        Step2 = …,
                        …
                        Final = …
                in
                        Final,

        // --------------------------- Documentation segment ------------------------------
        documentation = [
                Documentation.Name = "NameOfFunction",
                Documentation.Description = "What this function does",
                Documentation.Source = "Source or URL",
                Documentation.Version = "1.0",
                Documentation.Author = "Author",
                Documentation.Examples =
                {
                        [
                                Description = "Example usage",
                                Code = "NameOfFunction arg1 arg2",
                                Result = "Expected result"
                        ]
                }
        ]

        // --------------------------- Output --------------------------------------------
in
        Value.ReplaceType(
                output,
                Value.ReplaceMetadata(
                        Value.Type(output),
                        documentation
                )
        )
// ------------------------------------------------------------------------------------
```

- **Every documentation field must be filled.**
- Ensure that **Lists of Lists** or **Lists of Records** are formatted with **one item per line, properly indented**.

---

## 4. Best Practices & Linting Guidelines

### Naming and conventions

- Use **meaningful names**, not generic ones (e.g. prefer `RemoveDuplicates` over `Step3`).
- Use **CamelCase**.
- Prefix **filter steps** with `FILTER_`.

### Minimize “magic numbers”

- Avoid hardcoding unexplained constants; if needed, assign them to a named variable **with comment**.

### Simplify nested logic

- Prefer **flattening chains of transformations** into named steps rather than deeply nested expressions.

### Enable query folding where possible

- Apply `Table.SelectColumns`, `Table.SelectRows`, or other foldable transformations **early**.
- Avoid operations that **break folding too early** (like `Table.Buffer`, complex custom columns, or index addition) unless absolutely necessary.

### Avoid redundant steps

- Don’t store intermediate results that aren’t reused.
- Combine transformations when clarity and maintainability aren’t harmed.

### Document non-obvious logic

- For custom columns, merges, appending, groupings, **always explain why**, not just what.

### Watch for performance bottlenecks

- Grouping, joins on large tables, unbounded expansion, or Cartesian merges can be expensive. **Flag them in comments if unavoidable.**

### Step ordering matters

- **Filter → reduce columns → deduplicate → join / group → add index (or post-processing)** is often more efficient.

---

## 5. Performance Checklist (Use this per-query)

When reviewing or writing a query, check:

- ✅ Are filtering steps done early (and named `FILTER_…`) to reduce data early?
- ✅ Are columns pruned early (via `Table.SelectColumns`) to minimize memory?
- ✅ Does any step break query folding prematurely? (e.g. `Table.Buffer`, index, non-foldable expression)
- ✅ Are merges / joins done on as small tables / as few columns as possible?
- ✅ Are there redundant or dead steps that can be removed?
- ✅ If using grouping or expanding records, is the cost justified / explained?
- ✅ If adding an index or ranking, is that done after upstream transformations so it's minimal?
- ✅ Are all steps commented, named, and logically ordered?
