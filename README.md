# Task List Application

A C# / .NET Windows Forms app for creating and opening task list files. Each task has a name, a due date and time, a completion status, and a color-coded category. Lists are saved to comma-delimited text files and can be reopened later.

<!-- Add a screenshot of the app here, e.g. ![Task List App](screenshots/main.png) -->

## Features

- **Create File** makes a new task file from the name you type, using `StreamWriter`
- **Open File** lets you pick a file with an `OpenFileDialog` and reads every task back with `StreamReader`
- **Task Files** list shows each file you create or open
- **Add** and **Remove** tasks, each with a name, due date, due time, and a **Complete?** checkbox
- **Color** button opens a `ColorDialog` to set the task's category, shown in that color
- **Select a task** in the list to load its details back into the fields
- **Save** writes every task to the file, and **Cancel** asks Yes/No before discarding changes
- **Error handling** for invalid input and file errors, so the app never crashes

## How Tasks Are Stored

In memory, tasks are kept in a list of tuples:

```csharp
List<(string strName, DateTime dtDueDateTime, bool blnComplete, string strCategory)> taskInfo
```

On disk, each task is one comma-delimited line:

```
Study for exam, 10/15/2026, 14:30, False, Red
Submit lab report, 10/17/2026, 23:59, True, Blue
```

| Field     | Type     | Example        |
|-----------|----------|----------------|
| Task name | string   | Study for exam |
| Due date  | DateTime | 10/15/2026     |
| Due time  | DateTime | 14:30          |
| Complete  | bool     | False          |
| Category  | string (color name) | Red |

## How to Use

1. Type a name in **File Name** and click **Create File**. The file appears in **Task Files**, and the Task Details form opens.
2. Enter the task, date, and time. Check **Complete?** if it's done, and click **Color** to choose a category.
3. Click **Add** to put the task on the list. The fields clear for the next task.
4. Select a task to see its details, or select it and click **Remove** to delete it.
5. Click **Save** to write the tasks to the file. Click **Cancel** to close without saving, after confirming.
6. To reopen a list later, click **Open File** and choose its `.txt` file.
7. Click **Exit** to close the app.

## Project Structure

| Form | Purpose |
|------|---------|
| `taskListForm` (main) | File name, **Create File**, **Open File**, **Exit**, and the Task Files list |
| `taskDetailsForm` | Task fields, **Add**, **Remove**, **Color**, **Save**, **Cancel**, and the Task Details list |

Controls are named by purpose and type, for example `filesListBox`, `taskDetailsListBox`, `completeCheckBox`, and `saveButton`.

## Running the Project

**Requirements:** Windows, Visual Studio with the .NET desktop development workload

1. Clone the repository.
2. Open the solution (`.sln`) file in Visual Studio.
3. Press **F5** to build and run.

New task files are saved as `.txt` files in the app's working folder, usually `bin\Debug`.

## Testing

Tested to confirm that:

- Tasks saved to a file come back unchanged after restarting the app and opening the file
- Files with several tasks load every line, not just the first
- **Remove** with nothing selected doesn't crash
- **Save** and **Cancel** stay disabled until the list has at least one task
- **Cancel → Yes** closes without saving, and **Cancel → No** stays on the form
- Invalid dates or times and file errors show a message instead of crashing
