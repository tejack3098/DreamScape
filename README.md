# DreamScape  
**A Scalable and Secure Resort Booking Platform**

DreamScape is a resort booking platform designed with modern web development principles to provide seamless booking management, secure payment processing, and advanced analytics. This enterprise-grade application caters to both users and administrators, offering a dynamic user experience and efficient administrative tools.

---

## Features

### Backend Architecture
- Architected the backend using **.NET Core MVC** with **ASP.NET Core Identity** for secure user authentication and role-based access control.
- Implemented **JWT-based authentication** to secure user login sessions and sensitive data access.
- Leveraged **Unit of Work** and **Repository Pattern** for maintainable and efficient data access layers.

### Frontend Development
- Built a dynamic and responsive user interface with **Bootstrap** and **Razor Views**, delivering a polished and intuitive booking experience.

### Admin Dashboard
- Manage bookings, monitor financial reports, and track revenue trends.
- View real-time user analytics and booking trends to support data-driven decision-making.

### Payment Integration
- Integrated **Stripe Payment Gateway** for secure, seamless payment processing supporting multiple payment methods.

### APIs and Workflows
- Developed and consumed **RESTful APIs** for managing booking workflows, availability checks, user management, and payment transactions.

### Analytics and Insights
- Implemented advanced analytics to track user behavior, booking trends, and revenue generation.
- Delivered actionable insights to support business growth and operational efficiency.

### Scalability and Modularity
- Followed **Clean Architecture principles** to ensure long-term maintainability and scalability.

---

## Technologies

### Backend
- **.NET Core MVC**
- **ASP.NET Core Identity**
- **Entity Framework Core**
- **JWT Authentication**

### Frontend
- **Bootstrap**
- **Razor Views**

### Payment Gateway
- **Stripe API**

### Tools and Methodologies
- **RESTful APIs**
- **Unit of Work** and **Repository Pattern**
- **Swagger (OpenAPI)** for API documentation
- **Agile Development Practices**

---

## Getting Started

### Prerequisites
- Visual Studio 2019 or later
- SQL Server
- .NET Core SDK

### Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/tejack3098/dream-scape.git
   ```
2. Navigate to the project directory:
   ```bash
   cd dreamscape
   ```
3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
## API Documentation

### DreamScape's APIs are documented using Swagger (OpenAPI). To access the API documentation:

    Start the application.
    Navigate to: http://localhost:<port>/swagger.

## Contribution

Feel free to fork this repository and create pull requests for enhancements or bug fixes.
License

This project is licensed under the MIT License.
