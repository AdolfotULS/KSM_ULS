# Krakenware Management System (KSM_ULS)

Sistema de Gestión para Krakenware SPA  
**Centraliza y optimiza la gestión de tickets, inventario, clientes, garantías y reportes.**

---

## Resumen

Este proyecto implementa un sistema digital para Krakenware SPA, reemplazando planillas y mensajería informal por una plataforma moderna y eficiente. Permite administrar tickets de atención, inventario, clientes, garantías y reportes, facilitando la toma de decisiones y el seguimiento de procesos.

---

## Arquitectura

- **Patrón:** MVC (Modelo, Vista, Controlador).
- **Presentación:** Interfaces para autenticación, tickets, clientes, inventario y reportes.
- **Lógica:** Servicios dedicados para cada módulo principal.
- **Persistencia:** SQLite local, preparado para Entity Framework Core en el futuro.

---

## Roles y Permisos

- **Administrador:** Control total sobre usuarios, inventario y reportes.
- **Trabajador:** Gestión de tickets, inventario y clientes.
- **Cliente:** Consulta de estado y gestión de tickets propios.

---

## Funcionalidades Principales

- **Tickets:** Crear, editar, finalizar, eliminar y consultar estado.
- **Clientes:** Crear, editar y consultar datos.
- **Inventario:** Gestionar ítems (crear, editar, eliminar).
- **Reportes:** Descargar y comparar información relevante.
- **Garantías:** Solicitud, verificación y gestión.

---

## Usabilidad y UI

- Prototipos en Figma validados con los dueños de Krakenware.
- Navegación intuitiva y accesible en dispositivos móviles.
- Ajustes realizados tras pruebas con stakeholders.

---

## Tecnologías y Librerías

- **Lenguaje:** C# y .NET MAUI.
- **UI:** XAML, CommunityToolkit.Maui, Material Design.
- **Base de Datos:** SQLite local, preparado para Entity Framework Core.
- **Seguridad:** Cifrado de contraseñas con hashing.
- **Multiplataforma:** Compatible con Windows, Android, iOS y Mac Catalyst (ver `run.sh`).

---

## Ejecución

Utiliza el script `run.sh` para seleccionar plataforma y ejecutar el sistema:
```bash
./run.sh
```
> Verifica que el archivo `KSM_ULS.csproj` esté en el directorio raíz.

---

## Organización de Carpetas y Ejemplos
  ```text
  Model/
  └── INFO.cs         # Objetos que interactúan con la BD
  
  Pages/
  └── DashboardPage.xaml.cs    # Página principal con sub-vistas: resumen, clientes
  
  Views/
  ├── DashClientsView.xaml.cs  # Vista de clientes
  └── DashOverviewView.xaml.cs # Vista resumen del dashboard
  
  Platforms/
  ├── Windows/App.xaml.cs      # Inicialización en Windows
  ├── Android/MainApplication.cs   # Inicialización en Android
  ├── iOS/Info.plist           # Configuración iOS
  └── Tizen/tizen-manifest.xml # Manifesto para Tizen
  
  Resources/
  ├── Raw/AboutAssets.txt      # Explicación manejo de assets
  └── Splash/splash.svg        # Pantalla de inicio/logo
  ```

- **Model/**: Objetos que interactúan con la base de datos.  
  Ejemplo: `INFO.cs` describe el propósito de la carpeta y los modelos.

- **Pages/**: Páginas principales de la aplicación.  
  Ejemplo: `DashboardPage.xaml.cs` controla la navegación entre las vistas de resumen, clientes, reportes, etc.

- **Views/**: Vistas visuales del dashboard y módulos.  
  Ejemplo:  
    - `DashClientsView.xaml.cs`: Vista de clientes.
    - `DashOverviewView.xaml.cs`: Vista resumen del dashboard.

- **Platforms/**: Código específico para cada plataforma.  
  Ejemplo:  
    - `Windows/App.xaml.cs`: Inicialización para Windows.
    - `Android/MainApplication.cs`: Inicialización para Android.
    - `iOS/Info.plist`: Configuración de permisos y orientaciones en iOS.
    - `Tizen/tizen-manifest.xml`: Manifesto de aplicación para Tizen.

- **Resources/**: Assets gráficos, documentación y otros recursos.  
  Ejemplo:  
    - `Raw/AboutAssets.txt`: Explicación sobre el manejo de assets en MAUI.
    - `Splash/splash.svg`: Imagen de inicio/logo.

---

## Referencias y Enlaces

- [Galería de controles MAUI](https://github.com/dotnet/maui-samples/tree/main/10.0/UserInterface/ControlGallery/ControlGallery/Views/XAML)
- [Prototipo Figma](https://lilac-laptop-76385830.figma.site/)
- [Repositorio de entrega final](https://github.com/IC-ULS/proyecto-bd1-2025-krakenwaredevs.git)

---

## Estado Actual

El sistema cuenta con una base técnica sólida, validada por los stakeholders, lista para nuevas fases y escalabilidad.

