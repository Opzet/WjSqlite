https://www.codeproject.com/Articles/1158937/SQLite-with-Csharp-Net-and-Entity-Framework



Before using Entity Framework to interact with the database, you should create the SQLite database file first. 
You can use tools like "DB Browser for SQLite" or "SQLite CLI" to create an empty SQLite database file (with the .sqlite or .db extension).


 SQLite, it does not have built-in support for automatic database creation through Entity Framework's CreateDatabase method. Instead, you need to create the database file externally (e.g., using SQLite tools or code) 
 and then let Entity Framework connect to the existing database.
