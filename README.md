FimbulTyr
=========

- Small tasks
- Small requests
- Reminders
- Peer to peer
- Group

Data Layer
- Local SQL populated from server
- Syncs with the server/database at intervals
- Contains tickets?

Data Access Layer
- Allows for access to local SQL database

Business Layer
- Ticket object
- User object

Service Access Layer
- Accesses external server/database


Ticket object:
- Title
- Description
- Label
- Timestamp
- Reporter
- Assignee
- Priority
- Due Date

User object:
- First Name
- Last Name
- UserStatus
- User Id

UserStatus Object:
- State
- Message
- Ticket In Progress


Launch application
Canvas is empty
Create a ticket, assign to self
Store in local database
Local database sync with server


When the app loads, the user should be presented with all high priority inbound and outbound requests. Are these requests stored locally or are they pulled down from a server? How are they retrieved?

One action the user can take is to resolve a request, which should communicate to the assigner the new state of the task. Another action the user can take is to make a new request, which can be assigned to another user, thus "pinging" him or her.

NOTE: this may only be possible with socket communication mediated by an authoritative server.

Possible tech stack:
- Xamarin client application
- node.js server
- Couchbase database



Xamarin Development
===================

Typical Application Layers (core project):
- Data Layer (DL) - Non-volatile data persistence, likely to be a SQLite database but could be implemented with XML files or any other suitable mechanism.
- Data Access Layer (DAL) – Wrapper around the Data Layer that provides Create, Read, Update, Delete (CRUD) access to the data without exposing implementation details to the caller. For example, the DAL may contain SQL statements to query or update the data but the referencing code would not need to know this.
- Business Logic Layer (BLL) – contains business entity definitions (the Model) and business logic. Candidate for Business Façade pattern.
- Service Access Layer (SAL) – Used to access services in the cloud: from complex web services (REST, JSON, WCF) to simple retrieval of data and images from remote servers. Encapsulates the networking behavior and provides a simple API to be consumed by the Application and UI layers.

Typical Application Layers (platform-specific project):
- Application Layer (AL) – Code that’s typically platform specific (not generally shared across platforms) or code that is specific to the application (not generally reusable). A good test of whether to place code in the Application Layer versus the UI Layer is (a) to determine whether the class has any actual display controls or (b) whether it could be shared between multiple screens or devices (eg. iPhone and iPad).
- User Interface Layer (UI) – The user-facing layer, contains screens, widgets and the controllers that manage them.