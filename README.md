# Driving and Vehicle License Department (DVLD)

## Overview
This project is a designed for managing driver and vehicle licensing. The business and data access layers can be found in the [backend repository](https://github.com/RayanAlshehri/DVLD_Backend).

### Main Functionalities:
- Managing people  
- Managing users
- Creating applications
- Scheduling tests
- Issuing licenses

### Technologies Used:
- .NET Framework
- C#
- Windows Forms
- ADO.NET
- SQL Server

## Setup Instructions
To download the project with all of its extensions, click [here](https://drive.google.com/drive/folders/1q0XTn3HVTAz0D0yIsY1Lasm0nrvzmRYm?usp=drive_link). Please follow the instructions in the `README.txt` file for correct setup.


## Troubleshooting
If you encounter the error "Couldn't process .resx file due to its being in the Internet or Restricted zone or having the mark of the web on the file" while attempting to run the project, 
run the following command:
```powershell
   Get-ChildItem -Path "Path to the project folder" -Recurse | Unblock-File
```

## Note
Please note that this is a personal, non-real-world project developed for learning purposes.
