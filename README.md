# 🚗 DVLD - Driving License Management System

This project is a **complete desktop application** developed as part of **Course #19** on [ProgrammingAdvices.com](https://programmingadvices.com).  
The purpose of the project is educational — to practice building full systems using real-world software architecture techniques.

---

## 🎓 Educational Context

- 📚 **Course:** Full System Development – DVLD  
- 🏫 **Platform:** ProgrammingAdvices.com  
- 🎯 **Goal:** Learn how to structure real-world applications using proper layering and data access techniques in C#

---

## 🖥️ What the App Does

DVLD (Driving & Vehicle Licensing Department) is a system designed to simulate a real government desktop app for managing:

- 👤 Citizen records
- 🚘 Vehicle ownership
- 📝 Driving licenses (issue, renew, revoke)
- 💸 Traffic violations and fines
- 👮 License validation and management

The system includes both **functional backend** and a **graphical interface (WinForms)**.

---

## 🔧 Technologies Used

| Component        | Technology          |
|------------------|---------------------|
| Language         | C#                  |
| Framework        | .NET Framework (not .NET Core) |
| GUI              | WinForms            |
| Architecture     | N-Tier (Presentation, BAL, DAL) |
| Data Access      | ADO.NET              |
| Database         | SQL Server          |
| Tools Used       | Visual Studio, SSMS |

---

## 📂 Project Structure

```plaintext
DVLD/
├── DVLD.UI/      # Presentation Layer (WinForms)
├── DVLD.BAL/     # Business Logic Layer
├── DVLD.DAL/     # Data Access Layer (ADO.NET)
├── DVLD.DB/      # SQL Scripts (Tables, Procedures)
└── README.md



🚀 How to Run the App
Open the solution in Visual Studio

Ensure SQL Server is installed and running

Execute SQL scripts from DVLD.DB/ to create the required database or restore the backuped DB

Update the database connection string in the clsDataAccessSettings.cs based on your SQL server settings
Build and run the app via the WinForms project (DVLD.UI)


🎯 Educational Outcomes
Applying N-Tier architecture in a real application

Building database logic using ADO.NET

Designing user-friendly forms with WinForms

Structuring the solution for clarity and maintainability

Understanding real use cases from government systems


📌 Notes
This project was developed strictly for educational purposes

Based on a guided tutorial by ProgrammingAdvices.com (Course #19)



📬 Contact

GitHub: @SaeedJ4ber

LinkedIn: https://www.linkedin.com/in/saeed-jaber-15238b263/
