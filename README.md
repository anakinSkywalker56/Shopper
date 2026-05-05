# 🧪 PRACTICAL ACTIVITY: ASP.NET CORE MVC (IDENTITY + DATABASE FIRST)
## 🎯 Objective
Create a simple web application using ASP.NET Core MVC with:

- Login/Register (Identity)
- Database tables from SSMS
- CRUD using Scaffold
- One additional feature

## 📌 REQUIREMENTS
### 1. Create Project
- ASP.NET Core MVC
- Authentication: Individual Accounts

### 2. Setup Database
Run migration:
```bash
Add-Migration InitialCreate
Update-Database
```
3. Test Identity
Register 1 user

Login successfully

4. Create Tables in SSMS
Create at least 2 tables with relationship (FK)

Example:

Categories
- Id
- Name

Products
- Id
- Name
- Price
- CategoryId (FK)
5. Scaffold Database (IMPORTANT)
Run:

Scaffold-DbContext "Server=.\SQLEXPRESS;Database=YourDB;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f
6. Merge DbContext
Copy DbSet from generated context

Paste into ApplicationDbContext

Delete extra DbContext

7. Scaffold CRUD
Generate Controller + Views for:

Product

Category

8. TEST SYSTEM
Add data

Edit data

Delete data

Show FK dropdown working

⭐ ADD ONE FEATURE (REQUIRED)
Choose ONLY ONE (simple):

Auto-assign role on register

Add new field in user (e.g., FullName)

Add search bar in Product list

Restrict Product page to Admin only

Add simple validation (required fields)

🎥 VIDEO REQUIREMENTS (3–5 MINUTES)
Your video must show:

Login/Register working

Database tables (SSMS)

CRUD working (Product or your table)

Foreign key dropdown working

The extra feature you added

🗣️ EXPLAIN IN VIDEO
What tables you created

What relationship (FK) you used

What feature you added

📦 SUBMISSION
Video (3–5 minutes)

⚠️ REMINDERS
Make sure CRUD works before recording

Keep demo simple and clear

🎯 GOAL
“Recreate the demo, then improve it with one feature.”
