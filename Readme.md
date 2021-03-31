# Op Kanban

## Background
A simple Blazor Server app (with docker support or wrapped in Electron) to build out a Kanban Board. Data and authentication is using MongoDB Atlas and MongoDB Realm Sync.

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
* Have Docker installed and running
* Run [build.sh](OpKanban/build.sh) 
* App will start on port `666`

![](Screenshots/ss01.png)

![](Screenshots/ss02.png)

![](Screenshots/ss03.png)

![](Screenshots/ss04.png)

![](Screenshots/ss05.png)

![](Screenshots/ss06.png)
