# WingtipToys
This project is based on Microsoft's "Wingtip Toys Store" demo web portal written as a 3-Tier application leveraging .NET 4.5 with Webforms and SQL Server database for both data and user management. 

## Overview
This application has been slightly modified to allow for optionally using a user provided service for connection string information. Additional changes were made to enable troubleshooting deployments into Cloud Foundry. The base functionality of this app remains unchanged.

### Setup
A SQL Server connection string is required for the application to run. The application will initialize the database on first run so it is highly recommended that only one instance is used when running the application for the first time using a new uninitialized database.
