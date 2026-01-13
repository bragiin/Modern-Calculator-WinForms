# Modern Calculator

A robust calculator application developed using C# and Windows Forms (WinForms). This project demonstrates a custom implementation of a graphical user interface (GUI) with a focus on user experience, featuring a flat design style, dynamic theme switching, and session history management.

![Dark Mode View](https://github.com/bragiin/Modern-Calculator-WinForms/blob/main/darkmode.png?raw=true)

## Project Overview

The goal of this project was to move beyond standard Windows controls and create a modern, aesthetically pleasing interface. The application handles standard arithmetic operations with precision and includes error handling for edge cases such as division by zero.

## Key Features

* **Custom Flat UI:** The application utilizes a borderless design, replacing standard Windows frames with a custom-built user interface for a cleaner, modern look.
* **Dynamic Theme Switching:** Users can toggle between Dark Mode and Light Mode in real-time. The application programmatically updates the color properties of all controls without requiring a restart.
* **Calculation History:** A side panel logs all performed operations during the session, allowing users to track their calculation steps.
* **Error Handling:** Implemented robust validation to prevent runtime errors, including division by zero and multiple decimal point entries.
* **Responsive Layout:** The interface elements are aligned using precise geometric constraints to ensure a consistent look across different states.

## Technologies Used

* **Language:** C#
* **Framework:** .NET Framework
* **UI Library:** Windows Forms (WinForms)
* **IDE:** Microsoft Visual Studio 2022

## Application Preview

### Light Mode Variant
The application adapts to bright environments with a high-contrast light theme.

![Light Mode View](https://github.com/bragiin/Modern-Calculator-WinForms/blob/main/lightmode.png?raw=true)

### Implementation Details
The following snippet demonstrates the logic behind the dynamic theme application and control iteration.

![Code Snippet](https://github.com/bragiin/Modern-Calculator-WinForms/blob/main/code%20th.png?raw=true)
![Code Screenshot](https://github.com/bragiin/Modern-Calculator-WinForms/blob/main/code%20=.png?raw=true)

## Getting Started

To run this project locally:

1.  Clone this repository to your local machine.
2.  Open the `Calculator.sln` solution file in Visual Studio.
3.  Build the solution (Ctrl + Shift + B).
4.  Run the application (F5).
