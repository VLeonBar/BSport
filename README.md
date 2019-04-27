# BSport
Proyecto final DAM

Semana 1 y 2: 25 de Marzo a 7 de Abril.
  Aprendo cómo funciona la interfaz de Xamarin mediante XAML y Xamarin en general, creo diversos proyectos de prueba, leo documentación, veo tutoriales y empiezo a crear la interfaz de la aplicación. Surgen varios problemas sobre todo a la hora de entender cómo manejar los tamaños de pantalla diferentes(de diferentes móviles), cosa que no consigo controlar del todo, por lo cual la apariencia de la aplicación no es agradable.
  A finales de la semana 2 empiezo a pelearme y pensar la manera de trabajar con los datos.
  
Semana 3: 8 a 14 de Abril.
  Encuentro un problema al utilizar el paquete de MySQL.Data de Visual Studio instalado con NuGet. Busco información sobre el problema, ya que me lanza una excepción de tipo MySql.Data.MySqlClient.Replication.ReplicationManager. Al parecer es una Excepción debido a algún tipo de bug o de conflicto, hago pruebas desde otro ordenador y con proyectos limpios y nuevos y me sigue dando el mismo error, pruebo también las maneras que encuentro en páginas como stackoverflow de gente que ya había solventado el problema, como borrar el contenido de las carpetas /bin y /obj pero sin dar resultado. Intento pensar en alguna otra manera de trabajar con los datos y decido ponerme a crear un WebService con una API en PHP. Dejo creada la base de datos y la tabla usuarios.

Semana 4 y 5: 15 a 28 de Abril.
	Tengo diversos problemas a lo largo de la creación del Web Service, a medida que voy aprendiendo a crear la API en PHP, aprendo también a utilizar los parsers de C#, en este caso utilizo el paquete NewtonSoft.Json para parsear los Json que obtengo de la API. 
	
	En la API: Creo la conexión y los archivos de registro y login del usuario en la aplicación, que mediante el método POST inserta y obtiene datos de la tabla usuarios de la base de datos. Los datos se devuelven como objetos JSON.
	En la APP: Creo las clases y la conexión a la API y trabajo enviando datos mediante POST y recibiendo los datos en JSON.
	
	A finales de la segunda semana, el funcionamiento del login y el registro en la APP funciona correctamente y creo las tablas de partidos y la tabla relacional entre partidos y usuarios(jugadores). Me dispongo a terminar la API para crear y ver los partidos por cada usuario. 
	
Semana 6: 29 de Abril a 5 de Mayo.
	
