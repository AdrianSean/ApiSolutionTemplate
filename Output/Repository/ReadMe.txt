﻿Contains data-access implementation, as well as your Entity Framework mappings (if using this framework).  
This project is what makes the Data project SQL Server-specific at runtime.
As you build up your services applications, you should note that no code references any types contained in this project;instead, 
the code references only the Domain project.