
# Web Push Service

## Description
This is a .NET CORE 2.1 Web Application following MVC, using MVC Identity for Authentication with code first approach. This repository is a POC (Proof-of-Concept) for creating a system to enable users for sending push notifications to their multiple web applications.  
The structure of this repository consist of two projects, one being the system containing the dashboard for the user to create projects for which they want to send push notification, the dashboard application also exposes a web API in order for the client to post the device information which is used to send the push notification.  
The other being the sample client application containing a serviceWorker for handling the push notifications and the subscription logic to subscribe a device to the web push system, this client application is also hosted at ( https://nifty-hugle-66efd5.netlify.app/ ).  
The scope of this can be further extended by creating an sdk for the code required on client which the user can embed in their application to extract the subscription information and also for the handler.


## Setup Requirements

- Requires Visual studio.
- .NET Core 2.1 SDK.
- Docker (Optional for SqlServer)

## Setup Instructions

1. Checkout the repository and open the .sln project file with visual studio.
2. Make sure that all the dependencies are installed and start the web application, verify that the application starts and login page is loading.
3. The application has two connection strings in /appsettings.json `DefaultConnection`; this may work if your VS supports local mssql db. `SqlServerConnection`; for this you need to either have mssql server host and credentials or msql server running either standalone or by docker.
4. The connection string can be changed as per need in startup.cs at line no. 40.
5. Once the connection string is decided, move to `Tools > Nuget Package Manager > Package Manager Console` and Run `update database`, this will apply the MVC Identity migrations to create Identity Schema and the other tables required for storing application and subscribed device details.
6. Run the web application and login from the credentials present in appsettings.json > Users.

## Setting up MsSql through Docker

1. Install Docker.
2. Run `docker ps` to verify installation.
3. Run `docker run -d --name sql_server -e ACCEPT_EULA=Y -e SA_PASSWORD=Admin@123 -p 1433:1433 microsoft/mssql-server-linux`
4. Run `docker ps` to verify that sql_server container is running.

## Testing Instructions

1. Run the .net core web-app on your localhost, the webapp should run on http://localhost:44374/ as fixed in program.cs (the endpoint is being fixed in the client application for the rest API call.)
2. Register a new user or login through existing user which can be found in appsettings.json.
3. Create a new project from the dashboard and give it a name.
4. Copy the public key of your project from the dashboard.
5. Open the client application (https://nifty-hugle-66efd5.netlify.app/) and paste the public key and hit subscribe.
6. You can verify the new subscription info in the device table of your database.
7. Now from the dashboard hit send right next to the project item and fill in the title and message for the push and hit send.
8. You should receive the notification on your subscribed device.
