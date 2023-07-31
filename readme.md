﻿# Sqlite and WiseJ

 Dev stopped in in .net framework, features added to .net core.
 
 Frustrating it seems that .net sqlite dev stopped and basic CreateDatabase etc isnt implemented..

    System.Data.SQLite.EF6 System.Data.Entity.Core.ProviderIncompatibleException: 'CreateDatabase is not supported by the provider.'

Discovered that .net Sqlite EF6 Features implmeneted via https://github.com/msallin/SQLiteCodeFirst

Otherwise you have to create a SQLite database using DB Browser [http://sqlitebrowser.org/] and create the tables manually..Argh :(


## Work in progress

## Step 1: Add provider and factory to app.config

```

  <configSections>
    <!-- For more information on Entity Framework configuration, visit ... -->
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false"/>
  </configSections>
  
  <entityFramework>
    <providers>
      <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
      <provider invariantName="System.Data.SQLite.EF6" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
      <provider invariantName="System.Data.SQLite" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
    </providers>
  </entityFramework>
  
  <system.data>
    <DbProviderFactories>
      <remove invariant="System.Data.SQLite.EF6" />
      <add name="SQLite Data Provider" invariant="System.Data.SQLite.EF6" description=".NET Framework Data Provider for SQLite" type="System.Data.SQLite.SQLiteFactory, System.Data.SQLite" />
      <add name="SQLite Data Provider" invariant="System.Data.SQLite" description=".NET Framework Data Provider for SQLite" type="System.Data.SQLite.SQLiteFactory, System.Data.SQLite" />
    </DbProviderFactories>
  </system.data>

  <connectionStrings>
    <add name="sqliteCon" connectionString="Data Source=|DataDirectory|db.sqlite;" providerName="System.Data.SQLite.EF6" />
  </connectionStrings>

```


https://stackoverflow.com/questions/58767771/cant-get-sqlite-to-work-in-vs2019-with-ef6


https://devtut.github.io/entityframework/entity-framework-with-sqlite.html#setting-up-a-project-to-use-entity-framework-with-an-sqlite-provider

https://stackoverflow.com/questions/63494481/entity-framework-and-sqlite-the-ultimate-how-to

## Step 2:
Install SQLite in GAC
Once per machine. Download the latest sqlite-netFx46-setup-bundle-x86-2015-1.0.xxx.0.exe (from https://system.data.sqlite.org/index.html/doc/trunk/www/downloads-unsup.wiki)

VS 2022 File name is: sqlite-netFx46-setup-bundle-x64-2015-1.0.xxx.0.exe
Select "Full Installation"

Select: Install the assemblies into the global assembly cache - Install VS designer components
https://system.data.sqlite.org/downloads/1.0.118.0/sqlite-netFx46-setup-bundle-x64-2015-1.0.118.0.exe

```
Tools> NuGet Package Manager> Package Manager Console
```

## Step 3: Entityframework ORM - EF 6.4.4
```
Install-Package EntityFramework -Version 6.4.4
```

### Step 4: Sqlite provider and engine
```
Install-Package System.Data.SQLite 
```

## Step 5: Add missing ORM features via nuget - SQLITECODE FIRST

Nuget add  https://github.com/msallin/SQLiteCodeFirst

### Step 6 :Download and install Entity Framework Visual Editor
https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner2022
