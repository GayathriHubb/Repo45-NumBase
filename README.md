# 🔢 Number Base Converter

A Windows desktop application built with C# and WinForms that converts numbers between different number bases (Binary, Octal, Decimal, and Hexadecimal).

## 📋 Overview

**Number Base Converter** is a user-friendly GUI application that allows you to convert numeric values between four different number bases:
- **Binary (Base 2)** : 0, 1
- **Octal (Base 8)** : 0-7
- **Decimal (Base 10)** : 0-9
- **Hexadecimal (Base 16)** : 0-9, A-F

## ✨ Features

- 🎨 **Modern UI Theme** - Sleek, dark-themed interface with an accent color scheme
- ⚡ **Real-time Conversion** - Live conversion as you type
- 🔄 **Swap Functionality** - Quickly reverse the source and destination bases
- ✅ **Input Validation** - Automatic validation of input values for the selected base
- 🧹 **Clear Function** - One-click button to clear all fields
- 📊 **Status Feedback** - Real-time status messages indicating conversion results or errors
- 🛡️ **Error Handling** - Comprehensive exception handling with logging

## 🛠️ Technical Details

### Technology Stack
- **Language**: C# (.NET)
- **Framework**: Windows Forms (WinForms)
- **License**: MIT

### Project Structure
```
Repo45-NumBase/
├── MainForm.cs              # Main form logic and conversion UI
├── MainForm.Designer.cs     # Auto-generated form design
├── MainForm.resx            # Form resources
├── Program.cs               # Application entry point
├── NumberBaseConverter.csproj # Project configuration
└── LICENSE                  # MIT License
```

### Key Components

**MainForm.cs** - Contains:
- GUI initialization and theming
- Event handlers for base selection buttons
- Conversion logic orchestration
- Input validation
- Swap and clear operations
- Real-time conversion updates

**Program.cs** - Entry point features:
- Unhandled exception management
- Exception logging to file (`nbc_exceptions.log`)
- WinForms application initialization

## 🚀 How to Use

1. **Select Source Base**: Click one of the "FROM" buttons to choose the input number base (Binary, Octal, Decimal, or Hexadecimal)
2. **Select Target Base**: Click one of the "TO" buttons to choose the output number base
3. **Enter Value**: Type the number in the input field (valid for the selected source base)
4. **View Result**: The converted value appears automatically in the output field
5. **Swap Bases**: Click the "Swap" button to quickly reverse the conversion direction
6. **Clear**: Click "Clear" to reset all fields and start a new conversion

## 🎯 Example Conversions

| Input | From Base | To Base | Output |
|-------|-----------|---------|--------|
| 1010 | Binary (2) | Decimal (10) | 10 |
| 10 | Decimal (10) | Binary (2) | 1010 |
| FF | Hexadecimal (16) | Decimal (10) | 255 |
| 77 | Octal (8) | Hexadecimal (16) | 3F |

## 🎨 Theme Colors

The application uses a consistent color scheme:
- **Background**: Dark surface color
- **Accent**: Primary highlight color
- **Text Primary**: Main text color
- **Text Secondary**: Secondary/label text
- **Surface**: Card and button background
- **Border**: Subtle border lines
- **Success**: Green for valid conversions
- **Error**: Red for validation failures

## ⚠️ Error Handling

The application includes:
- Input validation for each base's valid digit range
- Exception logging to `nbc_exceptions.log` in the application directory
- User-friendly error messages in the status bar
- Graceful handling of runtime exceptions

## 📥 Installation & Running

1. Clone the repository
2. Open `NumberBaseConverter.csproj` in Visual Studio
3. Build the solution
4. Run the application

## 📄 License

This project is licensed under the **MIT License** - see the LICENSE file for details.

---

**Created by**: GayathriHubb  
**Repository**: [Repo45-NumBase](https://github.com/GayathriHubb/Repo45-NumBase)
