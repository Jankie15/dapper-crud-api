# readme

Para el uso de la API es necesario ejecutar los scripts en la capeta scripts.

Abrir el proyecto y cambiar el string de conección de la base de datos, el mismo se encuentar ubicado en las carpetas del proyecto
DapperCRUDAPI\DapperCRUDAPI\DataAccess\Customer\CustomerDataAccess.cs

Archivo CustomerDataAccess.cs linea 19
Cambiar YOURSERVER, YOURUSER y YOURPASSWORD
connectionString = "Data Source=YOURSERVER;Initial Catalog=DB_PracticaTecnica;User ID=YOURUSER;Password=YOURPASSWORD;";

Ejecute el sistema.

Se abrirá una pestaña en el navegador, donde ser mostrará el Swagger. 

En la URL del navegador cambiar http://localhost:29448/swagger por http://localhost:29448 para visualizar los metodos.

intalar los paquetes dapper,Swashbuckle, SqlClint

Comando Swashbuckle en caso de no contar con este paquete.
Install-Package Swashbuckle.AspNetCore -Version 6.2.3


