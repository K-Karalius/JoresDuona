# JoresDuona

## Building and Running the application

### 1. Clone the repository
First, clone the repository to your local machine:

```bash
git clone https://github.com/K-Karalius/JoresDuona.git
```
### 2. Install .NET SDK

Ensure you have the .NET 8 or higher SDK version installed on your system. You can download it from [here](https://dotnet.microsoft.com/download).

### 3. Navigate to the main project folder (JoresDuona)

```
cd JoresDuona
```

### 4. Restore dependencies

```bash
dotnet restore
```
### 5. Build the application

```bash
dotnet build
```

### 6. To run the application locally:

```bash
dotnet run
```

## Database setup

### Setup docker container

#### 1. Start the Docker container

```bash
docker-compose up -d
```

#### 2. Stop and remove Docker container

```bash
docker-compose down -v
```

### Migrations

#### 1. Update the database with migrations

To apply migrations to the database, run the following command:

```bash
dotnet ef database update
```

#### 2. Adding a New Migration

To add a new migration, run the following command:

```bash
dotnet ef migrations add <MigrationName>
```

#### 3. If you need to remove the last migration, you can use:

```bash
dotnet ef migrations remove
```

### Database Connection information for Local Development

The database connection information  is stored in the appsettings.Development.json file.

Example:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;example;Username=example;Password=example;Database=example;Pooling=true;"
  }
}
```