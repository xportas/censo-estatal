# Project for Managing Provinces and Localities in Spain

This project is a C# application that utilizes Entity Framework to interact with a database storing information about provinces and localities in Spain. The application provides functionalities to retrieve, add, edit, and delete information in the database through Windows Forms. Additionally, it leverages the .NET platform for an efficient and robust implementation.

## System Requirements

Ensure you have the following components installed before running the application:

- [Microsoft Visual Studio](https://visualstudio.microsoft.com/) with support for C# development.
- [Entity Framework](https://docs.microsoft.com/en-us/ef/) for database manipulation.

## Database Configuration

The application uses Entity Framework Code First for database management. Make sure to configure the connection string in the `app.config` or `web.config` file as needed.

```xml
<connectionStrings>
    <add name="ProvinciasLocalidadesDbContext" connectionString="YourConnectionString" providerName="System.Data.SqlClient" />
</connectionStrings>
```

Replace `"YourConnectionString"` with the appropriate connection string for your database environment.

## Project Structure

The project is divided into three layers:

### Entity Layer

- **ProvinciasLocalidadesData.Entities**: Contains entities representing the database structure.
  - `Provincia.cs`: Class representing a province in the database.
  - `Localidad.cs`: Class representing a locality in the database.
  - `LocalidadDTO.cs`: Data transfer class for the Localidad entity.

### Data Layer

- **GestorDatos**: Contains data access logic and defines the database model.
  - `bdEstado.cs`: Entity Framework database context.

### Presentation Layer

- **ProvinciasLocalidadesApp**:

  - `FrmMenu.cs`: Main menu showing main options and managing navigation between forms.
  
  - `FrmAbandonadas.cs`: Form to interact with abandoned localities and provinces.
  
  - `FrmAltaLocalidad.cs`: Form to add a new locality to the database.
  
  - `FrmBorrarLocalidad.cs`: Form to delete localities based on user-specified criteria.
  
  - `FrmConsulta.cs`: Form to query different data about provinces or localities.

## Technologies Used

- **C#**: Main programming language.
- **Entity Framework**: ORM used for database manipulation.
- **Windows Forms**: Platform for creating user interfaces.
- **SQL Server**: Database engine used to store information.

## License

This project is under the [GNU Affero General Public License v3.0](LICENSE). Refer to the [LICENSE](LICENSE) file for more details.

Thank you for contributing to the project!
