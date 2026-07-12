# Supermarket Inventory Management

A desktop app for managing a supermarket's inventory — products, stock levels, price
changes, suppliers, and an employee activity log. Built with VB.NET WinForms on .NET 10,
backed by a local SQLite database.

## Features

- **Employee login / registration** with hashed passwords
- **View inventory** — searchable product grid with supplier, price, and stock details
- **Stock adjustments** with reasons (Sold, Arrived, Damaged, Expired, …), tracked per employee
- **Price changes** and **bulk-buy** pricing with discount calculation
- **Add products** (with category and supplier)
- **Employee activity** — see each employee and the changes they've made
- Every stock/price change is written to an audit log (`product_change`)

## Tech stack

| | |
|---|---|
| Language | VB.NET |
| UI | Windows Forms |
| Framework | .NET 10 (`net10.0-windows`) |
| Database | SQLite (local file, via `System.Data.SQLite`) |

## Prerequisites

- **Windows**
- **Visual Studio 2022 (17.12+) or 2026** with the **.NET desktop development** workload
  (this also installs the .NET 10 SDK), **or** the standalone [.NET 10 SDK](https://dotnet.microsoft.com/download).

## Getting started

Clone the repo, then open the solution in Visual Studio:

```
Supermarket Inventory Management.slnx
```

Press **F5** to build and run.

### From the command line

```sh
dotnet run --project "Supermarket Inventory Management/Supermarket Inventory Management.vbproj"
```

### First run

The app opens a **Login** screen. If you don't have an account yet, click **Register** to
create one, then log in.

## Database

The app uses a single local SQLite file:

```
Supermarket Inventory Management/data/inventory_db.db
```

Main tables: `employee`, `product`, `category`, `supplier`, and `product_change` (the audit
log). All database access lives in `data/controller.vb` and connections come from
`data/dbConn.vb`.

## Project structure

```
Supermarket Inventory Management/
├─ frmMain.vb              Main window (menu + content host)
├─ frmLogin.vb            Login form
├─ frmRegister.vb         Registration form
├─ ucView.vb             View / edit inventory
├─ ucProductForm.vb      Add a product
├─ ucDashboard.vb        Dashboard
├─ ucEmployees.vb        Employees + their activity
├─ SessionManager.vb     Tracks the logged-in employee
└─ data/
   ├─ controller.vb      All SQL / data access
   ├─ dbConn.vb          SQLite connection
   └─ inventory_db.db    The database
```

## Contributing

- `main` is protected — changes go through **feature branches + pull requests**, not direct pushes.
- The **data-access layer** (`data/controller.vb`) is owned by @Baemz14; coordinate before changing it.
- Build must pass (`dotnet build`) before opening a PR.
