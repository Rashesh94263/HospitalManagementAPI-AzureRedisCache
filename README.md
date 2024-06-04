# HospitalManagementAPI-AzureRedisCache


The Hospital Management System is a robust, RESTful API-based solution designed to streamline operations within a healthcare organization. Built using C# and ASP.NET Core, this system provides comprehensive functionality for managing clinics, medical staff, patients, and medicines, ensuring data integrity, efficiency, and scalability. The system also integrates Azure Redis Cache for enhanced performance.

## Table of Contents

# Hospital Management API with Azure Redis Cache

The Hospital Management System is a robust, RESTful API-based solution designed to streamline operations within a healthcare organization. Built using C# and ASP.NET Core, this system provides comprehensive functionality for managing clinics, medical staff, patients, and medicines, ensuring data integrity, efficiency, and scalability. The system also integrates Azure Redis Cache for enhanced performance.

## Table of Contents

- [Features](#features)
- [Endpoints](#endpoints)
    - [Clinic Endpoints](#clinic-endpoints)
- [Data Models](#data-models)
    - [ClinicDTO](#clinicdto)
    - [MedicalStaffDTO](#medicalstaffdto)
    - [PatientDTO](#patientdto)
    - [MedicineDTO](#medicinedto)
    - [RegionsDTO](#regionsdto)
- [Error Handling](#error-handling)
- [Authentication and Authorization](#authentication-and-authorization)
- [Getting Started](#getting-started)
- [Contributing](#contributing)

## Features

- **Clinic Management**: Create, retrieve, update, and delete clinic records with details like name, address, and region.
- **Medical Staff Management**: Manage medical staff with CRUD operations, including details like name, specialty, and clinic assignment.
- **Patient Management**: Manage patient records with CRUD operations, including details like name, medical history, and assigned doctor.
- **Medicine Management**: Manage medicines with CRUD operations, including details like name, dosage, and expiration date.
- **Data Validation**: Robust input validation to ensure data integrity and prevent errors.
- **Custom Exceptions**: Clear error handling with specific exceptions for different scenarios.
- **API-Driven Design**: RESTful API promotes seamless integration with other enterprise applications.
- **Performance**: Integration with Azure Redis Cache for enhanced performance and scalability.
- **Security**: (To be implemented) Future enhancements will include authentication and authorization mechanisms to protect sensitive data.

## Endpoints

### Clinic Endpoints

| Method | Endpoint          | Description                    | Request Body  | Response Body |
|--------|-------------------|--------------------------------|---------------|---------------|
| GET    | /api/v2/clinics/{id}   | Get clinic by ID             | None          | `ClinicDTO` |
| GET    | /api/v2/clinics/       | Get all clinics              | None          | List<`ClinicDTO`> |


## Data Models

### ClinicDTO

| Column Name | Column Type | Nullable |
|--------------|-------------|----------|
| ClinicId     | Guid        | No       |
| ClinicName   | string      | No       |
| ClinicAddress | string     | No       |
| ClinicCity   | string      | No       |
| ClinicState  | string      | No       |
| ClinicPostalCode | string  | No       |
| ClinicCountry | string     | No       |
| ClinicPhoneNumber | string | No       |
| ClinicEmail  | string      | No       |
| ClinicWorkingHours | string | No      |
| ClinicFloorNumber | int?   | Yes      |
| RegionId     | Guid        | No       |
| CreatedDate  | DateTime    | No       |
| LastUpdatedDate | DateTime | Yes      |

### MedicalStaffDTO

| Column Name | Column Type | Nullable |
|--------------|-------------|----------|
| MedicalStaffId | Guid      | No       |
| MedicalStaffFirstName | string | No   |
| MedicalStaffLastName | string | No    |
| MedicalStaffDateOfBirth | DateTime | No|
| MedicalStaffGender | string | No      |
| MedicalStaffSpecialization | string | No |
| MedicalStaffShiftingTime | string | No|
| MedicalStaffDateOfEmployment | DateTime | No |
| MedicalStaffContactNumber | string | No |
| MedicalStaffEmail | string | Yes      |
| MedicalStaffAddress | string | No     |
| MedicalStaffRole | string | No        |
| CreatedDate | DateTime | No           |
| UpdatedDate | DateTime | Yes          |

### PatientDTO

| Column Name | Column Type | Nullable |
|-------------|-------------|----------|
| PatientId   | Guid        | No       |
| PatientNationId | string  | No       |
| PatientName | string      | No       |
| PatientDateOfBirth | DateTime | No   |
| PatientGender | string    | No       |
| PatientAddress | string   | No       |
| PatientNumber | string    | No       |
| PatientEmail | string     | No       |
| PatientEmergencyContact | string | No|
| PatientConditionalIllness | string | No |
| PatientResponsibleDoctorId | Guid | No |
| PatientRoom | string      | No       |
| PatientAdmissionDate | DateTime | No |
| PatientDischargeDate | DateTime | Yes|
| CreatedDate | DateTime    | No       |
| UpdatedDate | DateTime    | Yes      |

### MedicineDTO

| Column Name | Column Type | Nullable |
|-------------|-------------|----------|
| MedicineId  | Guid        | No       |
| MedicineCodeNumber | string | No     |
| MedicineName | string     | No       |
| MedicineType | string     | No       |
| MedicineDescription | string | No    |
| MedicineStatus | string   | No       |
| MedicineQuantity | int    | No       |
| MedicineStatusNumber | string | No   |
| MedicinePrice | decimal   | No       |
| MedicineManufacturer | string | No   |
| MedicineExpirationDate | DateTime | No |
| MedicineCreatedDate | DateTime | No  |
| MedicineUpdatedDate | DateTime | Yes |

### RegionsDTO

| Column Name | Column Type | Nullable |
|-------------|-------------|----------|
| RegionId    | Guid        | No       |
| RegionName  | string      | No       |
| RegionDescription | string | No      |
| RegionCreateTime | DateTime | No     |
| RegionUpdateTime | DateTime | Yes    |

## Error Handling

The API returns appropriate HTTP status codes (e.g., 200 OK, 201 CREATED, 404 NOT FOUND) to indicate the outcome of requests. Additionally, it throws custom exceptions like `ClinicNotFoundException` and `MedicalStaffNotFoundException` with descriptive error messages.

## Authentication and Authorization

(To be implemented) This API will be enhanced with authentication (verifying user identity) and authorization (controlling access to resources) mechanisms in future updates.

## Getting Started

### Prerequisites

Ensure you have the following installed:

- .NET SDK 8.0 or higher: [https://dotnet.microsoft.com/download]
- SQL Server:[https://www.microsoft.com/en-us/sql-server/sql-server-downloads]
- Azure Cache Redis: [https://azure.microsoft.com/en-us/products/cache]

### Setup

1. Clone the Repository:

```bash
git clone https://github.com/YOUR_USERNAME/HospitalManagementAPI-AzureRedisCache.git
cd HospitalManagementAPI-AzureRedisCache
```

2. Configure the Database:
Update the connection string in appsettings.json to point to your SQL Server instance.

3. Configure Redis Cache:
Update the Redis connection string in appsettings.json to point to your Redis instance.

4. Build the Project:
```bash
dotnet build
```

5. Run the Application:

```bash
dotnet run
```


6. Access API Endpoints:

Use Postman or any other API client to test the endpoints.

### Contributing

Contributions are welcome! Please follow our contribution guidelines.

1. Fork the Repository:

2. Create a new Branch:

```bash
git checkout -b feature/your-feature
```

3. Make Your Changes and Commit:

```bash
git add .
git commit -m "write a commit message..."
```

4. Push Your Branch:

```bash
git push origin feature/your-feature
```

