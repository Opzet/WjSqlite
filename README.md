# Sqlite and WiseJ

## Step 1:
Install SQLite in GAC
Once per machine. Download the latest sqlite-netFx46-setup-bundle-x86-2015-1.0.xxx.0.exe (from https://system.data.sqlite.org/index.html/doc/trunk/www/downloads-unsup.wiki)

VS 2022 File name is: sqlite-netFx46-setup-bundle-x64-2015-1.0.xxx.0.exe
Select "Full Installation"

Select: Install the assemblies into the global assembly cache - Install VS designer components
https://system.data.sqlite.org/downloads/1.0.118.0/sqlite-netFx46-setup-bundle-x64-2015-1.0.118.0.exe

```
Tools> NuGet Package Manager> Package Manager Console
```

## Step 1: Entityframework ORM - EF 6.4.4
```
Install-Package EntityFramework -Version 6.4.4
```

### Step 2: Sqlite provider and engine
```
Install-Package System.Data.SQLite 
```

### Step 4 :Download and install Entity Framework Visual Editor
https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner2022
