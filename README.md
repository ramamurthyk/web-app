# Web application

Contains a simple REST API to insert the date time stamp to an Azure Cosmos DB.

## Deploy this application - preferred way
The easiest way to deploy and run this application is via the Deploy To Azure option present in the [app-deploy](https://github.com/ramamurthyk/app-deploy) GitHub repository.
Follow the instructions in the Readme.md file.

For local development/debugging, follow the option mentioned below:

## Running this application locally from the .NET Core command line

1. Before you can run this application, you must have the following prerequisites:
    - [.NET Core SDK 3.1 or higher](https://dotnet.microsoft.com/download)
    - An active Azure Cosmos account - If you don't have an account, refer to the [Create a database account](https://docs.microsoft.com/azure/cosmos-db/create-sql-api-dotnet#create-an-azure-cosmos-db-account) article

2. Clone this repository using your Git command line, or download the zip file.

3. Go to the location of the [app.csproj](./app.csproj) in your command line prompt.

4. Run `dotnet build` to restore packages and build the project.

5. Retrieve the URI and PRIMARY KEY (or SECONDARY KEY) values from the Keys blade of your Azure Cosmos account in the Azure portal. For more information on obtaining endpoint & keys for your Azure Cosmos account refer to [View, copy, and regenerate access keys and passwords](https://docs.microsoft.com/azure/cosmos-db/secure-access-to-data#master-keys) 

6. In the [appsettings.json](./appsettings.json) file, located in the project root, find **Account** and **Key** and replace the placeholder values with the values obtained for your account.

7. You can now run and debug the application locally by running `dotnet run` and browsing the Url provided by the .NET Core command line.
