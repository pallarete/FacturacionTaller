<!-- Repaso de los comandos para el proyeto -->
Intentare hacer un controlador por tabla!!!!
1. Crear la plantilla MVC: -Abrimos consola y tecleamos:
 "  dotnet new mvc -o TallerAppMVC  ".
2. Despues de crear el proyecto nos moveos a el con el comando : cd .\TallerAppMVC\
3. Lo abrimos en una nueva instancia de VSC con el comando: code .
4. ViewBag.Message =""; nos crea un mensaje por pantalla, Razor trabaja con directivas de programacion que se 
invocan con @ por lo tanto si quisiermos citar a un mensaje dentro de una etiqueta hay que llamarlo asi: 
__@ViewBag.Message__
5. Agrego el modelo producto desde la carpeta producto pero no me deja 
6. se instala el EFC con los siguientes comandos:
A. dotnet add package Microsoft.EntityFrameworkCore
B. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
C. dotnet add package Microsoft.EntityFrameworkCore.Sqlite
E. dotnet add package Microsoft.EntityFrameworkCore.Tools
D. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design.

7.  Ahora habria que ver si instalamos el Entity Framework Core con el comando
" dotnet tool install --global dotnet-ef", Com ya esta instalada se actualiza y punto.

8. Ahora vamos a configurar las cadenas de conexiones. Lo haremos para SQLite ypara SqlServer


  "ConnectionStrings": {
    "DefaultConnectionSqlite":"Data Source = TallerAppMVCDB.db",
    "DefaultConnectionSqlServer":"Server=localhost,1433:database=TallerAppMVCDB;TrustServerCertificate=true"
  },
  9. Vamos a añadir los models que sera nuestra tablase de bases de datos

  10. En el data context le decimos que cree las tablas a partir de los modelos declarados.

  11. Con la aplicacion cerrada vamos a hacer las migraciones  y creaciones de las tablas de las bases de datos:
    A. el primer comando para hacer la primera migracion es : "dotnet ef migrations add InitialCreate" La ultima palabra ha de ser descriptiva.
    Hay que tener claro que hay que estar dentro de la carpeta de la APP y tener bien declarado el archivo Data y la configuracion en el archivo Program.cs.
    para deshacer los cambios de las migraciones hay que escribir "ef migrations remove".
  
  12. Siempre siempre siempre que hagamos una migracion en la base de datos hay que hacer un update de la misma con el comando: "dotnet ef database update"!!!!!! 

12+1. Se habra creado la base de datos y ya la podemos abrir desde el  menu secundario del boton derecho.
14.  Para hacer inserts desde VSC en menu de click derecho hay la opcion una vez escrita la query click derecho y run query y hecho.

15.  Vamos a instalar una herramienta que genera los controladores y las vistas para los crud de cada modelo. 
  Se hara con el comando dotnet tool install -g dotnet-aspnet-codegenerator. Este comando lo instala globalmente en entrono de desarrollo.
  Para desinstalar esta herramienta  es dotnet tool uninstall -g dotnet-aspnet-codegenerator.

16. Vamos a generar controller y vistas para una tabla en concreto que ya esta declarada en DataContext. el comando es el siguiente:
dotnet aspnet-codegenerator controller -name RecambiosController -m Recambio -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries


  dotnet aspnet-codegenerator controller : Llamamos a la funcion o herramienta
  -name RecambiosController : Definimos el nombre del controlador
  -m Recambio: Especificamos que trabajara con el modelo Recambio
  -dc DataContext: Indica el contexto de datos a utilizar . (ojo a la configuracion inicial en Program.cs!!!)
  --relativeFolderPath Controllers : Le decimos la ubicacion donde crear ese controlador
  --useDefaultLayout : le decimos que layouts (Diseños usar)
  --referenceScriptLibraries: Le decimos las scripts que queremos que referencie (validaciones y demas).

  17. Con ViewData[nombre] desde el controlador ! le pasamos datos visibles a la vista que tendra que invocarlos con ViewBag.(el tipo de dato de antesw).
  18. Para borrar una base de datos: rm FacturaTallerMVCDB.db  


 