# Calculator Using Visual Studio

A simple C# Windows Forms calculator application built using Microsoft Visual Studio. The calculator provides a desktop interface for performing basic arithmetic operations with a clean button-based layout and calculation history support.


## Overview

This project is a Windows desktop calculator developed with C# and Windows Forms. It allows users to enter numeric values, choose arithmetic operators, calculate results, clear input, and view previous calculations in a history panel.

The application is suitable for learning Windows Forms development, event-driven programming, UI design, and basic arithmetic logic in C#.

## Features

- Windows Forms desktop interface.
- Number buttons from 0 to 9.
- Decimal point support.
- Addition operation.
- Subtraction operation.
- Multiplication operation.
- Division operation.
- Modulus/percentage operation.
- Positive/negative sign toggle.
- Equal button for result calculation.
- Clear button to reset current input.
- Calculation history panel.
- Clear history option.
- Custom window controls for minimize, maximize, and exit.

## Technology Stack

- **Language:** C#
- **Framework:** .NET Framework 4.8.1
- **UI Framework:** Windows Forms
- **IDE:** Microsoft Visual Studio
- **Project Type:** Desktop application

## Project Structure

```text
Calculator-using-visual-studio/
  Calculator.sln
  Calculator.csproj
  Program.cs
  Form1.cs
  Form1.Designer.cs
  Form1.resx
  App.config
  Resources.resx
  Resources.Designer.cs
  Settings.settings
  Settings.Designer.cs
```

The repository also contains generated build files such as `.exe`, `.pdb`, `.cache`, and compiled resource files. These files are created automatically by Visual Studio during build and are not required when rebuilding the project from source.

## Main Files

### `Program.cs`

Contains the main entry point of the application. It starts the Windows Forms app and opens `Form1`.

### `Form1.cs`

Contains the main calculator logic, including:

- Number button click events.
- Decimal button logic.
- Arithmetic operator selection.
- Equal/result calculation.
- Clear input behavior.
- History panel behavior.
- Minimize, maximize, and exit button actions.

### `Form1.Designer.cs`

Contains the auto-generated Windows Forms UI layout code, including buttons, text boxes, panels, labels, and history display controls.

### `Form1.resx`

Stores form resources used by the Windows Forms designer.

## Application Flow

```text
Start Application
  ↓
Open Calculator Form
  ↓
User enters first number
  ↓
User selects operator
  ↓
User enters second number
  ↓
User clicks equals button
  ↓
Result is displayed
  ↓
Calculation is added to history
```

## Prerequisites

- Windows operating system.
- Microsoft Visual Studio.
- .NET Framework 4.8.1 or compatible version.

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/eesha2111/Calculator-using-visual-studio.git
```

2. Open the project folder.

3. Open the solution file in Visual Studio:

```text
Calculator.sln
```

4. Build the project:

```text
Build > Build Solution
```

5. Run the application:

```text
Press F5
```

## How to Use

1. Launch the calculator.
2. Click number buttons to enter the first value.
3. Select an operator such as `+`, `-`, `*`, `/`, or `%`.
4. Enter the second value.
5. Click `=` to display the result.
6. Use `C` or clear to reset the input.
7. Open the history panel to view previous calculations.
8. Use clear history to remove saved calculation history from the panel.

## Example

```text
Input:  25 + 10
Output: 35
```

```text
Input:  8 * 5
Output: 40
```

## Future Improvements

- Add keyboard input support.
- Add backspace/delete button.
- Improve divide-by-zero handling.
- Format history entries with operators for clearer reading.
- Add scientific calculator functions.
- Add theme support.
- Remove generated build/cache files from the repository.
- Add a `.gitignore` file for Visual Studio build outputs.

## Disclaimer

This project is intended for learning, academic, and demonstration purposes. It is a basic desktop calculator and can be extended with more advanced features.
