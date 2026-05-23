# Smart QR Generator

Smart QR Generator is a simple ASP.NET Core MVC web application that allows users to generate QR codes from website links. Users can preview the QR code, download it as a PNG image, copy the original link, and share it from the browser.

## Features

- Generate QR code from any valid website URL
- URL validation with `http://` and `https://` support
- QR code preview before download
- Download QR code as PNG
- Copy URL to clipboard
- Share URL using browser share option
- Light/Dark theme support
- Responsive Bootstrap-based UI

## Tech Stack

- ASP.NET Core MVC
- .NET 8
- C#
- Razor Views
- Bootstrap 5
- jQuery
- Font Awesome
- QRCoder NuGet package

## Project Structure

```text
SmartQrGenerator/
│
├── SmartQrGenerator.sln
│
└── SmartQrGenerator.Web/
    ├── Controllers/
    │   └── HomeController.cs
    │
    ├── Models/
    │   └── QrRequest.cs
    │
    ├── Services/
    │   ├── IQrGeneratorService.cs
    │   └── QrGeneratorService.cs
    │
    ├── Views/
    │   ├── Home/
    │   │   └── Index.cshtml
    │   └── Shared/
    │       └── _Layout.cshtml
    │
    ├── wwwroot/
    │   ├── css/site.css
    │   └── js/site.js
    │
    ├── Program.cs
    └── SmartQrGenerator.Web.csproj
```

## Requirements

Before running this project, install:

- Visual Studio 2022 or later
- .NET 8 SDK
- Git

## How to Run Locally

### 1. Clone the repository

```bash
git clone https://github.com/sonaniharshit/SmartQrGenerator.git
```

### 2. Open project folder

```bash
cd SmartQrGenerator
```

### 3. Restore NuGet packages

```bash
dotnet restore
```

### 4. Build the project

```bash
dotnet build
```

### 5. Run the project

```bash
dotnet run --project SmartQrGenerator.Web
```

### 6. Open in browser

```text
https://localhost:5001
```

or use the URL shown in the terminal.

## How to Use

1. Open the Smart QR Generator website.
2. Enter a valid website URL.

Example:

```text
https://example.com
```

3. Click **Preview QR Code**.
4. Scan the generated QR code to test it.
5. Use available actions:
   - **Download**: Save QR code as PNG
   - **Copy Link**: Copy the entered URL
   - **Share**: Share the URL using browser share option

## Validation Rules

The URL must:

- Not be empty
- Start with `http://` or `https://`
- Be a valid website URL

Valid example:

```text
https://google.com
```

Invalid examples:

```text
google.com
www.google.com
hello world
```

## License

This project is open-source and available for learning and personal use.

## Author

Created by **Harshit Sonani**.
