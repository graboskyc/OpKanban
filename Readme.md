# Op Kanban

## Background
A simple Blazor Server app (with docker support or wrapped in Electron) to build out some account management tasks for Solutions Architects. Data and authentication is using MongoDB Atlas and MongoDB Realm Sync.

## Features
_Run in Docker or Electron desktop app!_

* Login - backed by MongoDB Realm authentication
* Local cache - once logged in, you can view and edit anything, even without a network connection. It will seamlessly sync to the cloud when network is restored.
* Summary page - show graphs of what stages Ops are in, for what products, your health rating, and status of technical champion building activities
* Product management - track what products Ops can have
* Kanban board- track opportunities and details about them with filtering, color coding, etc
* Contacts - Tack contacts for the purposes of champion building
* Cloud services - track links to a cloud service back end to quickly jump to a closed-customer's tickets or environment

## Running yourself
### DB Prep
* Create an [Atlas](https://cloud.mongodb.com) cluster
* Deploy a Realm app for this cluster
* Turn on Realm Sync for a DB with a partition key `string` on `_pk`
* Create a collection in that DB called `KanbanTask` and set it's schema as that of [RealmSyncSchemaConfig.json](RealmSyncSchema.json)
* Turn on email/password authentication
* Create an account

### App Prep
* Git Clone this archive
* Copy the Realm App ID from Realm and replace the string in [Login.cs](OpKanban/OpKanban/Data/Login.cs)

## Option A - Docker
* You must have Docker installed and running
* Run [build.sh](OpKanban/build.sh) 
* App will start on port `666`

## Option B - Electron
* You must have [ElectronNET.CLI](https://www.nuget.org/packages/ElectronNET.CLI/) installed
* `cd` to the directory you cloned above 
* `cd` to OpKanban
* Run `electronize build /target win` to make a Windows Executable 
* Find the executable in `bin/Desktop` and run it to install


## Screenshots
![](Screenshots/ss01.png)

![](Screenshots/ss02.png)

![](Screenshots/ss03.png)

![](Screenshots/ss09.png)

![](Screenshots/ss04.png)

![](Screenshots/ss05.png)

![](Screenshots/ss06.png)

![](Screenshots/ss07.png)

![](Screenshots/ss08.png)
