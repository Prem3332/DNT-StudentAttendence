# 📊 Attendance Management System (C# WinForms)

A desktop-based Attendance Management System built using **C#**, **.NET Framework**, and **Windows Forms**.
This application helps manage student records and track attendance efficiently through a simple and user-friendly interface.

---

## 📌 Table of Contents

* [📖 Overview](#-overview)
* [🚀 Features](#-features)
* [🛠️ Technologies Used](#️-technologies-used)
* [📂 Project Structure](#-project-structure)
* [⚙️ Installation & Setup](#️-installation--setup)
* [▶️ How to Run](#️-how-to-run)
* [🧪 Usage](#-usage)
* [📸 Screenshots](#-screenshots)
* [⚠️ Limitations](#️-limitations)
* [🔮 Future Improvements](#-future-improvements)
* [🤝 Contributing](#-contributing)
* [👨‍💻 Author](#-author)
* [📄 License](#-license)

---

## 📖 Overview

This project is a **desktop application** designed for managing student attendance in schools or colleges.
It provides functionality to:

* Store student information
* Record daily attendance
* Maintain data locally
* Provide a clean and modern UI using MetroFramework

---

## 🚀 Features

* 🔐 **Login System**

  * Secure access to the application

* 🧑‍🎓 **Student Management**

  * Add, update, and delete student records

* 📋 **Attendance Tracking**

  * Mark students as Present/Absent
  * Maintain attendance history

* 🖥️ **User-Friendly Interface**

  * Built with MetroFramework for modern UI design

* 💾 **Local Data Storage**

  * Uses DataSet / local files for storing data

---

## 🛠️ Technologies Used

* **Language:** C#
* **Framework:** .NET Framework 4.7.2
* **UI:** Windows Forms (WinForms)
* **Design Library:** MetroFramework
* **IDE:** Visual Studio

---

## 📂 Project Structure

```
Attendence System/
│
├── Attendence System.sln        # Solution file
│
├── Attendence System/
│   ├── Program.cs              # Entry point
│   ├── LoginForm.cs            # Login screen
│   ├── MainForm.cs             # Main dashboard
│   ├── App.config              # Configuration file
│   ├── DataSet files           # Local data storage
│   ├── packages.config         # NuGet packages
│   └── Properties/             # Project properties
│
├── .gitignore                  # Git ignore file
└── README.md                   # Project documentation
```

---

## ⚙️ Installation & Setup

### 1. Clone the repository

```
git clone https://github.com/Prem3332/DNT-StudentAttendence.git
```

### 2. Open the project

* Open **Visual Studio**
* Click on **Open a Project or Solution**
* Select `Attendence System.sln`

### 3. Restore dependencies

* Go to:

  ```
  Tools → NuGet Package Manager → Restore Packages
  ```

---

## ▶️ How to Run

1. Open the solution file in Visual Studio
2. Build the project:

   ```
   Build → Build Solution
   ```
3. Run the application:

   ```
   Press F5
   ```

---

## 🧪 Usage

1. Launch the application
2. Login using credentials (if configured)
3. Navigate to dashboard
4. Perform actions:

   * Add students
   * Mark attendance
   * View records

---

## 📸 Screenshots

> <img width="683" height="820" alt="image" src="https://github.com/user-attachments/assets/cbf0e4e7-7aad-4e84-8819-476a2b5e919a" />
<img width="627" height="814" alt="image" src="https://github.com/user-attachments/assets/07d2160e-8938-47f4-871b-f8040d331720" />
<img width="625" height="808" alt="image" src="https://github.com/user-attachments/assets/8805ad5e-4936-4f99-8140-de8e94b07633" />
<img width="622" height="810" alt="image" src="https://github.com/user-attachments/assets/5dc8c164-cf17-45d5-900a-089f4d176b71" />
<img width="1298" height="736" alt="image" src="https://github.com/user-attachments/assets/f9301e97-ab08-4210-a01a-a67005844855" />


Example:

* Login Screen
* Dashboard
* Attendance Page

---

## ⚠️ Limitations

* ❌ Uses local data storage (no SQL database)
* ❌ Single-user system
* ❌ No cloud or online access
* ❌ Limited reporting features

---

## 🔮 Future Improvements

* ✅ Integration with SQL Server / MySQL
* ✅ Role-based authentication (Admin/Teacher)
* ✅ Export attendance reports (PDF/Excel)
* ✅ Web-based version (ASP.NET / React)
* ✅ Cloud synchronization

---

## 🤝 Contributing

Contributions are welcome!

Steps:

1. Fork the repository
2. Create a new branch
3. Make your changes
4. Submit a pull request

---

## 👨‍💻 Author

**Your Name**

* GitHub: https://github.com/Prem3332

---

## ⭐ Acknowledgements

* MetroFramework UI library
* Microsoft Visual Studio
* .NET Community

---
