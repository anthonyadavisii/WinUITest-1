# WinUITest

Adjusted from the procedures on the following:

https://learn.microsoft.com/en-us/windows/ai/apis/get-started?tabs=winget%2Cwinui%2Cwinui2

# Running Visual Studio Community 2022 Preview                                          17.14.5 Preview 1.0 Microsoft Corporation

- C++/WinRT templates and visualizer for VS2022
- Description: Project and Item templates and the debug visualizer for C++/WinRT in Visual Studio 2022
- Publisher: Microsoft
- Version: 2.0.220531.1
  
- Single-project MSIX Packaging Tools for VS 2022
- Description: Provides Visual Studio 2022 support for working with and debugging Windows apps that use Single-project MSIX Packaging
- Publisher: Microsoft
- Version: 1.4.0.230101
  
- Windows App SDK C# VS2022 Templates
- Description: Adds C# project and item templates to support building Windows apps and components in VS 2022
- Publisher: Microsoft
- Version: 1.7.250317001

- OS: Windows 11 Home 24H2
- Build: 26120

### Prerequisites:
Ensure your Windows version exceeeds 10.0.26119.0 with the following PowerShell command:
[System.Environment]::OSVersion.Version
Run the following command in Windows Terminal if the Microsoft winget command fails. This is likely due to the executable reporting inaccurate build number and can be bypassed using the following:

winget configure https://raw.githubusercontent.com/anthonyadavisii/WinUITest-1/refs/heads/master/learn_wcr_revision_bypass.winget

🧰 1. Launch Visual Studio Preview
- Start Visual Studio 2022 Preview
- Ensure you’re using the “Developer Command Prompt” if you plan to run CLI tools later
  
🧱 2. Create a New Project
- Click Create a new project
- Search for: Blank App, Packaged (WinUI 3 in Desktop)
- Choose either C++/WinRT or C# depending on your testing preference:
- For C++/WinRT: Use the template from the Microsoft.Windows.CppWinRT package
- For C#: Use the Windows App SDK C# template
- Click Next
  
🧾 3. Configure Project
- Name: WinUITest
- Location: Choose a clean dev folder
- Solution: New or existing—it’s up to you
- Framework version: Select Windows App SDK 1.4 or later (you’re on 1.7)
- Target: Windows 11, version 24H2 (Build 26120 is fully compatible)

⚙️ 4. Set Debug Target and Packaging
- Go to Project Properties
- Ensure Target Framework is correct (e.g., net8.0-windows10.0.19041.0 for C#)
- Ensure packaging is Single-project MSIX (already installed)
- Set Package.appxmanifest > Identity > Publisher if not already set
  
▶️ 5. Build and Run
- Build the solution with Ctrl+Shift+B
- Set the startup project and press F5 to launch

** This instructions are in a beta state as the process is replicated. **
