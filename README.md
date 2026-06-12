
# Saffrom E-Store

## Enterprise E-Commerce Platform Built with ASP.NET Core MVC

Saffrom E-Store is a full-featured e-commerce platform developed using ASP.NET Core MVC, Entity Framework Core, ASP.NET Identity, SQL Server, and Stripe Payment Integration.

The application provides customers with a secure online shopping experience while offering administrators powerful tools for managing products, orders, users, payments, and business analytics through a centralized dashboard.

The project was designed following enterprise software development principles including layered architecture, dependency injection, separation of concerns, role-based security, and service-oriented design.

---

## Business Objectives

The platform was developed to address common challenges faced by online retailers:

* Centralized product management
* Secure customer authentication
* Streamlined online purchasing
* Integrated payment processing
* Efficient order management
* Administrative reporting and analytics
* Scalable and maintainable architecture

---

## Core Features

### Customer Portal

#### Product Catalog

* Browse products by category
* View detailed product information
* Product image galleries
* Dynamic pricing display
* Responsive user experience

#### Shopping Cart

* Add products to cart
* Update product quantities
* Remove products from cart
* Session-based cart persistence

#### Secure Checkout

* Stripe payment integration
* Secure payment processing
* Order confirmation workflow
* Payment status tracking

#### Account Management

* User registration
* Secure login and logout
* Profile management
* Order history
* Order tracking

---

### Administration Portal

#### Dashboard Analytics

* Revenue monitoring
* Order statistics
* Product metrics
* Customer metrics
* Category performance

#### Product Management

* Create products
* Update products
* Delete products
* Manage pricing
* Manage inventory details
* Upload product images

#### Category Management

* Create categories
* Edit categories
* Delete categories

#### User Management

* View registered users
* Manage user roles
* Lock user accounts
* Unlock user accounts
* Reset passwords


#### Order Management

* View customer orders
* Update order statuses
* Shipping management
* Refund processing
* Payment verification

---

## System Architecture

The application follows a layered architecture designed to promote maintainability, scalability, and testability.

```text
Presentation Layer
│
├── SaffromEstoreWeb
│   ├── Controllers
│   ├── Views
│   ├── Areas
│   └── Middleware
│
Business Layer
│
├── SaffromEstore.Business
│   ├── Services
│   └── Interfaces
│
Data Access Layer
│
├── SaffromEstore.DataAccess
│   ├── DbContext
│   ├── Repositories
│   ├── Migrations
│   └── Seed Data
│
Domain Layer
│
├── SaffromEstore.Models
│   ├── Entities
│   ├── ViewModels
│   └── DTOs
│
Shared Components
│
└── SaffromEstore.Utility
```

---

## Technology Stack

### Backend

* ASP.NET Core MVC (.NET 10)
* C#
* Entity Framework Core
* ASP.NET Identity
* SQL Server

### Frontend

* Razor Views
* Bootstrap 5
* jQuery
* AJAX
* DataTables

### Third-Party Integrations

* Stripe Payment Gateway
* Toastr Notifications
* SweetAlert2
* ApexCharts

### Development Tools

* Visual Studio 2026
* Git
* GitHub
* NuGet Package Manager

---

## Database Design

### Main Entities

| Entity          | Description                          |
| --------------- | ------------------------------------ |
| ApplicationUser | Application users and authentication |
| Category        | Product categories                   |
| Product         | Product catalog                      |
| ShoppingCart    | Customer shopping cart               |
| OrderHeader     | Order information                    |
| OrderDetails    | Individual order items               |

### Identity Tables

* AspNetUsers
* AspNetRoles
* AspNetUserRoles
* AspNetUserClaims
* AspNetRoleClaims
* AspNetUserLogins
* AspNetUserTokens

---

## Security Implementation

### Authentication

* ASP.NET Core Identity
* Cookie Authentication

### Authorization

* Role-Based Access Control (RBAC)

### Roles

| Role     | Access Level                  |
| -------- | ----------------------------- |
| Admin    | Full system access            |
| Employee | Operational management        |
| Customer | Shopping and order management |

### Password Policy

* Minimum length enforcement
* Uppercase requirement
* Lowercase requirement
* Numeric requirement
* Special character requirement

---

## Payment Processing

The platform integrates with Stripe to provide secure payment processing.

### Features

* Secure Checkout
* Payment Verification
* Order Confirmation
* Refund Management
* Payment Status Tracking

---


## Installation

### Clone Repository

```bash
git clone https://github.com/DammySmartSolutions/SaffromE-store.git
```

### Restore Dependencies

```bash
dotnet restore
```

### Apply Database Migrations

```bash
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

---


## Author

**Oluwadamilola Samuel Ademiluyi (Dammy)**

Full Stack Software Engineer |Project Manager | Tech Enthusiast

### Technical Skills

* .Net
* ASP.NET
* C#
* Entity Framework Core
* SQL Server
* MySQL
* ASP.NET Identity
* JavaScript
* jQuery
* Bootstrap
* React
* Node.js
* Python
* Azure Cloud Services

---

## License


This project was developed as an e-commerce application to demonstrate modern ASP.NET Core MVC development, secure online shopping workflows, payment integration, and enterprise software engineering practices.

© 2026 Oluwadamilola Samuel Ademiluyi. All rights reserved.