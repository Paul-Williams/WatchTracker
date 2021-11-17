About
------
Application for tracking viewing of TV series and movies.

Uses EntityFramework 6 with LocalDb to attach mdf file, without use of SQL Server

Data is loaded in-memory on start-up. It is saved either manually (Ctrl+S) or after prompt on exit.

Controls are all data-bound, using <code>PW.WinForms.Binding</code>


Change Log
---
[23/02/19] Added spell checking component.

See: https://www.codeproject.com/Articles/265823/i-Spell-Check-and-Control-Extensions-No-Third-Pa

---
[14/02/19] Now working with local data, through repository.

---

[17/11/21] Upgraded to .NET 6 - Still using EntityFramework 6.x (rather than EFCore)