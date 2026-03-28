# TechGear17

A Windows Forms desktop application built with **.NET 8** for managing a tech repair shop. It covers item inventory, customer service orders, and transaction history — all backed by a SQL Server database.

---

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Database Schema](#database-schema)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [Usage Guide](#usage-guide)
- [Known Issues & Notes](#known-issues--notes)

---

## Features

### Items Management
- View all items with category filtering and live search
- Add, update, and delete items (name, category, stock, price)
- Color-coded stock indicators: **red** for out-of-stock, **yellow** for low stock (≤ 10)

### Service Management
- Register new customer service requests with damage description and optional phone number
- Update service status: `Waiting` → `In Process` → `Done`
- Open a detail dialog (only for **In Process** services) to add/remove items used in the repair
- Automatically creates a transaction record when a service is marked as `Done`

### Transaction History
- View all completed transactions, filterable by date and customer name
- Double-click a row to see the service detail (parts used, damage type, entry date, status)

### General
- Live clock displayed in the top bar
- Navigation sidebar with active button highlight

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET 8) |
| UI Framework | Windows Forms |
| Database | SQL Server (Express) |
| ORM / Data Access | ADO.NET (`Microsoft.Data.SqlClient`) |
| IDE | Visual Studio 2022+ |

---

## Project Structure

```
TechGear17/
├── Helper/
│   ├── DBHelper.cs           # Static DB access (ExecuteQuery / ExecuteNonQuery)
│   ├── UIHelper.cs           # Control clearing utility
│   └── ValidationHelper.cs   # Input validation (empty check, numeric-only)
│
├── Form1.cs / .Designer.cs   # Main shell with sidebar navigation
├── ItemManagement.cs         # Items CRUD user control
├── ServiceUC.cs              # Service order user control
├── ServiceDetailDialog.cs    # Item-to-service assignment dialog
├── UpdateStatusDialog.cs     # Status change dialog
├── HistoryUC.cs              # Transaction history user control
│
├── Program.cs                # Application entry point
└── TechGear17.csproj         # Project file
```

---

## Database Schema

```
Categories
├── CategoryId   INT (PK, Identity)
└── CategoryName NVARCHAR

Items
├── ItemId       INT (PK, Identity)
├── CategoryId   INT (FK → Categories)
├── ItemName     NVARCHAR
├── Stock        INT
└── Price        DECIMAL(18,2)

Service
├── ServiceId     INT (PK, Identity)
├── CustomerName  NVARCHAR
├── DamageType    NVARCHAR
├── EntryDate     DATETIME
├── ServiceStatus NVARCHAR  ('Waiting' | 'In Process' | 'Done')
└── Phone         NVARCHAR (nullable)

ServiceDetail
├── DetailId   INT (PK, Identity)
├── ServiceId  INT (FK → Service)
├── ItemId     INT (FK → Items)
├── Qty        INT
├── Price      DECIMAL(18,2)
└── Subtotal   DECIMAL(18,2)

TransactionService
├── TransactionId   INT (PK, Identity)
├── ServiceId       INT (FK → Service)
├── SubTotal        DECIMAL(18,2)
└── TransactionDate DATETIME
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any SQL Server edition)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) with the **Desktop development with .NET** workload

### Setup Steps

1. **Clone or download** this repository.

2. **Create the database** by running the provided `database.sql` script against your SQL Server instance:
   ```
   sqlcmd -S YOUR_SERVER\SQLEXPRESS -i database.sql
   ```
   Or open it in SQL Server Management Studio (SSMS) and execute it.

3. **Update the connection string** in `TechGear17/Helper/DBHelper.cs` to match your SQL Server instance name:
   ```csharp
   public static readonly string connectionString =
       "Server=YOUR_SERVER\\SQLEXPRESS;Database=TechGearDatabase;Integrated Security=true;TrustServerCertificate=true";
   ```

4. **Open** `TechGear17.sln` in Visual Studio.

5. **Restore NuGet packages** (Visual Studio does this automatically, or run `dotnet restore`).

6. **Run** the project (`F5` or `Ctrl+F5`).

---

## Configuration

The only configuration needed is the **connection string** in `Helper/DBHelper.cs`.

| Parameter | Description |
|---|---|
| `Server` | Your SQL Server instance name (e.g. `DESKTOP-ABC\SQLEXPRESS`) |
| `Database` | Must be `TechGearDatabase` (or match your script) |
| `Integrated Security` | Uses Windows Authentication — no username/password needed |
| `TrustServerCertificate` | Set to `true` for local development with self-signed certs |

---

## Usage Guide

### Adding a Service Order
1. Click **Service** in the sidebar.
2. Fill in the customer name and describe the damage.
3. Optionally add a phone number.
4. Click **Add**.

### Processing a Service
1. Select the service row and click **Update**, then change the status to **In Process**.
2. Click the **Detail** button on the row (only available for *In Process* services).
3. In the dialog, click **Add** on any item to add it to the service cart.
4. Click **Throw** to reduce item quantity or remove it.

### Completing a Service
1. Select the service and click **Update**.
2. Change the status to **Done** — a transaction record is automatically created with the total cost.

### Managing Items
1. Click **Items Management** in the sidebar.
2. Use the category dropdown and search bar to filter.
3. Double-click a row to load it into the form, then edit and click **Update**.

---

## Known Issues & Notes

- The **Detail** button in the Service screen only works when the service status is `In Process`. Clicking it for `Waiting` services silently does nothing by design.
- The history date filter is always active (defaults to today). If no results appear, check the date picker.
- `Phone` is optional in service registration; validation skips it via the `optional` tag convention.
- Stock levels are decremented when items are added to a service detail and are **not** automatically restored if a service is deleted.
