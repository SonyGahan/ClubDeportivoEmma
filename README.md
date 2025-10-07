# 🏅 Club Deportivo Emma

Sistema de gestión para un club deportivo desarrollado en **C# (.NET 9)** con interfaz de **Windows Forms** y base de datos **MySQL**.  
Permite gestionar inscripciones de socios y no socios, pagos de cuotas, actividades y listado de morosos.

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

## 🛠️ Tecnologías utilizadas

- **Lenguaje**: C# 12
- **Framework**: .NET 9 (Windows Forms)
- **Base de datos**: MySQL 8+
- **Gestor de paquetes**: NuGet
- **Librerías**:
  - `MySql.Data` → Conexión a MySQL
  - `Microsoft.Extensions.Configuration.Json` → Carga de configuración

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

### 2. Configuración

1. **Crear la base de datos** `baseclubdeportivo` ejecutando el script SQL proporcionado.
2. En la raíz del proyecto, crea un archivo `appsettings.json` con tu conexión:

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
Usuario: admin
Contraseña: admin123
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

🚀 Gracias por visitar nuestro repositorio y por tu interés en este proyecto. ¡Espero que te sea útil! 😄

### ⌨️ Construido con ❤️ por Grupo 4 de DISEÑO DE SISTEMAS ORIENTADO A OBJETOS - COMISION A 😊

Grupo 4 - El consejo de la Secta somos: Lorenzo Mariela - Juan Mendoza - Johana Navarro - Sonia Pereira - Sol Prinzen - Ariel Quiroga 