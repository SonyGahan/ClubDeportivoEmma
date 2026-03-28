# 🏅 Club Deportivo Emma - Sistema de Gestión Integral

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet)
![MySQL](https://img.shields.io/badge/MySQL-8.0-4479A1?style=for-the-badge&logo=mysql)
![C#](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=csharp)

Sistema profesional desarrollado para la administración de un club deportivo. El proyecto destaca por su robustez en el manejo de reglas de negocio, integridad de datos y una interfaz de usuario intuitiva y estilizada.

---

## 🌟 Características

- ✅ Registro de personas (socios y no socios)
- ✅ Gestión de cuotas mensuales con estado de pago (`Pagada`, `Pendiente`, `Vencida`)
- ✅ Pago diario para no socios
- ✅ Inscripción a actividades deportivas
- ✅ Listado automático de socios morosos
- ✅ Sistema de login básico (usuario administrador pre-cargado)
- ✅ Conexión segura a base de datos con credenciales externas (`appsettings.json`)

---

### ⚙️ Arquitectura de Base de Datos
- **Procedimientos Almacenados (Stored Procedures):** Toda la lógica crítica de escritura se delega al motor MySQL (`sp_AltaNuevoSocio`, `sp_ActualizarMorosos`), garantizando velocidad y seguridad.
- **Transacciones Atómicas:** El proceso de alta asegura que el registro de la persona, su membresía y su primera cuota se generen en un solo bloque indivisible.
- **Normalización:** Estructura de tablas optimizada (Persona -> Socio/No Socio) para evitar redundancia.

### 🛡️ Motor de Validaciones (`ValidadorNegocio.cs`)
Implementación de una capa de servicios para verificar:
- **Estado de Apto Médico:** Bloqueo automático de acceso a actividades y emisión de carnets si el apto está vencido.
- **Control de Morosidad:** Detección de deudas pendientes que impiden la operación del socio en el club.

---

## 🛠️ Tecnologías utilizadas

### Stack Técnico
- **Frontend:** Windows Forms (.NET 9) con diseño explícito en C#.
- **Backend:** C# 12 con Programación Orientada a Objetos (POO).
- **Persistencia:** MySQL Server 8.0+.
- **Configuración:** Inyección de dependencias para la lectura de `appsettings.json`.

### Requisitos Previos
- Visual Studio 2022 (v17.10+).
- MySQL Workbench o similar.
- SDK de .NET 9.0.

---

## 📦 Estructura del proyecto

```
ClubDeportivoEmma/
├── Models/ → Clases de dominio (Persona, Socio, Cuota, etc.)
├── Data/ → Clase DatabaseHelper (conexión y consultas)
├── Forms/ → Formularios (Login, Inscripción, Pagos, Morosos)
├── appsettings.json → Configuración de conexión (NO subido a GitHub)
├── .gitignore → Excluye archivos sensibles y temporales
└── README.md → Este archivo
```

---

## 📷 Capturas de Pantalla

A continuación te mostramos cómo se ve la aplicación:

![Presentación del Sistema](/ClubDeportivoEmma21/img/login.JPG)

---

![Vista Principal](/ClubDeportivoEmma21/img/menuPrincipal.JPG)

---


## 🚀 Cómo ejecutar el proyecto

### 1. Requisitos previos
- [MySQL Server](https://www.mysql.com/downloads/) instalado y en ejecución
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (con soporte para .NET 9)
- Base de datos creada: `baseclubdeportivo`.

---

## 🏗 Instalación y Uso

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tu-usuario/DSOO-clubEmma.git
   cd DSOO-clubEmma
   ```  

2. **Configuración**

A. **Crear la base de datos** `baseclubdeportivo` ejecutando el script SQL proporcionado. Crucial: Ejecutar los scripts de Stored Procedures para habilitar las funcionalidades de alta y morosidad.
B. En la raíz del proyecto, crea un archivo `appsettings.json` con tu conexión:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=baseclubdeportivo;user=root;password=tu_contraseña"
  }
}
```

---

### 3. Ejecutar
Abre la solución en Visual Studio.
Presiona F5 o haz clic en Iniciar.

```
Inicia sesión con:
Usuario: MyUser
Contraseña: MyPassword
```

---

### 4. 🗃️ Script de base de datos

La base de datos contiene las siguientes tablas:

```
PERSONA
SOCIO
NO_SOCIO
ACTIVIDAD
CUOTA
PAGO_DIARIO
INSCRIPCION
USUARIO (para login)
```

✅ El script completo está incluido en los archivos de diseño del proyecto en la carpeta **/script MySQL**. 

---

## 🔒 Seguridad

Las credenciales de la base de datos nunca se suben a GitHub gracias al archivo .gitignore.

---

## 💡 Contribuciones

Las contribuciones son bienvenidas. Si deseas mejorar el proyecto o agregar nuevas funcionalidades, sigue estos pasos:

1. **Haz un Fork** del repositorio.
2. Crea una nueva rama con una descripción clara:
   ```bash
   git checkout -b nueva-funcionalidad
   ```
3. Realiza tus cambios y haz un commit:
   ```bash
   git commit -m "Agrega nueva funcionalidad X"
   ```
4. Sube los cambios a tu repositorio remoto:
   ```bash
   git push origin nueva-funcionalidad
   ```
5. Crea un **Pull Request** en este repositorio.

---

### 📬 Contacto

Si tienes alguna duda o sugerencia, puedes contactarme a través de GitHub:

[GitHub: SonyGahan](https://github.com/SonyGahan)

---

### 📝 Licencia

Este proyecto está bajo la **Licencia MIT**. Consulta el archivo [LICENSE](LICENSE) para más detalles.

---

### 💻 Agradecimientos

🚀 Gracias por visitar el repositorio y por tu interés en este proyecto. ¡Espero que te sea útil! 😄

### ⌨️ Construido con ❤️ por Sony Gahan 