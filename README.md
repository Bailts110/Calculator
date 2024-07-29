# Calculator
This is a simple calculator application built using C# and Windows Forms. It supports basic arithmetic operations including addition, subtraction, multiplication, division, and modulus.

## Features

- **Basic Operations**: Supports addition, subtraction, multiplication, division, and modulus operations.
- **User-Friendly Interface**: Easy-to-use interface with a clean design.
- **Keyboard Support**: Allows users to input numbers and operations using the keyboard.
- **Clear Functionality**: Includes a clear (AC) button to reset the calculator.
- **Result Display**: Displays the current operation and result clearly.
  
## Usage

- **Button Input**: Click the buttons on the calculator to input numbers and operations.
- **Keyboard Input**: Use the keyboard to input numbers and operations directly.
  
 ## Code Structure
 
- **Form1.cs**: Contains the main logic for the calculator.
- **Program.cs**: Contains the entry point for the application.
- **Form1.Designer.cs**: Contains the designer-generated code for the UI.

## UI Layout

- **Panels**: The application is divided into three main panels:

- **p1**: Contains the equal (=), clear (AC), and modulus (%) buttons.
- **p2**: Contains the numeric buttons (0-9) and the decimal point (.).
- **p3**: Contains the operation buttons (+, -, *, /).
- **TextBox**: The display (dis) shows the current input and results.

- **Label**: The labelCurrentOperation shows the current operation being performed.

## Event Handling
- **Button Clicks**: Each button click is handled to update the display and perform operations.
- **Keyboard Input**: The KeyPress event is used to handle keyboard input, ensuring it does not duplicate button clicks.
