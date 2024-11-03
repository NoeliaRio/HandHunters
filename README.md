# HandHunters

## Descripción General del Proyecto:
El proyecto es una página web de ventas de cartas de TCG (Trading Card Game), enfocada en tres franquicias principales: Pokémon, Magic: The Gathering y Yu-Gi-Oh. La funcionalidad principal del sitio es permitir a los usuarios registrados subir cartas que desean vender, con la posibilidad de gestionar las publicaciones (editar o eliminar solo sus propias cartas) y permitir a cualquier visitante navegar, filtrar y ver detalles de las cartas disponibles.

## Entidades y Funcionalidades:
### Carta: La entidad principal del sistema. Cada carta tiene las siguientes propiedades:
 Id
 nombreCarta
 descripción
 costo
 IdCalidad 
 IdEstado
 IdIdioma
 Foto
 IdFranquicia
 IdUsuario (Usuario que la publicó)
### Franquicia: Contiene las tres franquicias mencionadas (no modificables desde la interfaz).
Id
nombreFranquicia
### Estado: Define los posibles estados de las cartas Disponible, No Disponible).
Id
nombreEstado
### Calidad: Define el nivel de calidad de las cartas (aceptable, muy bueno, excelente).
id
nombreCalidad
### Idioma: Lista de idiomas disponibles para las cartas. (ej. inglés, español, etc.)
Id
nombreIdioma
### Usuario: Gestiona la autenticación y autorización en la aplicación
#### Cada usuario tiene las siguientes propiedades:
Id
nombreUsuario
contraseña
email.
#### Cada usuario puede:
Registrarse, iniciar sesión y gestionar su cuenta.
Subir cartas para la venta.
Editar o eliminar solo sus cartas.
Editar el estado de tus cartas por csv

## Funcionalidades Principales:
### Login y Registro de Usuarios:
Los usuarios deben poder registrarse y autenticar su sesión.
Solo los usuarios autenticados pueden subir, editar y eliminar sus propias cartas.
### Gestión de Cartas:
Los usuarios autenticados pueden publicar cartas, cada una con un nombre, descripción, costo, estado, calidad, idioma, franquicia y foto.
Las cartas solo pueden ser editadas o eliminadas por el usuario que las publicó.
### Exploración de Cartas:
Cualquier visitante, registrado o no, puede visualizar todas las cartas disponibles.
Se pueden aplicar filtros por franquicia, calidad, estado e idioma para facilitar la búsqueda.
Al hacer clic en una carta, se muestra un detalle con toda la información de la misma.
### Mis Cartas:
Los usuarios autenticados tienen una sección personalizada donde pueden ver sólo las cartas que han subido, con la opción de editar o eliminarlas.

## Esquema de la Aplicación (MVC):
### Modelos:
Carta: Atributos de la carta, relacionando con las entidades de franquicia, calidad, estado, idioma y usuario.
Franquicia: Contiene las franquicias Pokémon, Magic y Yu-Gi-Oh.
Calidad:Contiene los valores: Aceptable, Muy bueno, Excelente.
Estado: solo tiene dos valores Disponible y No disponible
Idioma: Almacena los idiomas en que están las cartas.
Usuario: Gestiona la información de los usuarios registrados, Atributos: Nombre de usuario, contraseña, email.
### Controladores:
CartasController: Maneja la lógica para mostrar, filtrar, crear, editar y eliminar cartas.
UsuarioController: Controla el registro, inicio de sesión y perfil del usuario.
### Vistas:
Índice de Cartas: Muestra una lista de todas las cartas disponibles, con filtros aplicables por franquicia, estado e idioma.
Detalle de Carta: Muestra la información detallada de una carta cuando se selecciona en el índice.
Mis Cartas: Vista personalizada para que los usuarios autenticados gestionen sus propias cartas.
Formulario de Registro/Iniciar Sesión: Formulario para gestionar el acceso de usuarios.
Formulario para Agregar/Editar Carta: Formulario para que los usuarios suban o editen cartas.
Vista de Error:  Vista para manejar los errores
