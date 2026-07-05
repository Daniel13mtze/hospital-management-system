# Sistema de Control Hospitalario

Este es un sistema de escritorio desarrollado en **C# (.NET Windows Forms)** y **SQL Server** diseñado para gestionar las operaciones esenciales de una clínica u hospital, optimizando el control de citas médicas, administración de salas de atención, solicitudes de estudios clínicos y el registro de altas médicas.

---

## 🚀 Características Principales

El sistema está estructurado mediante módulos independientes que facilitan la navegación y el flujo de trabajo del personal administrativo y médico:

*   **Módulo de Citas:** Registro, control y seguimiento de las consultas médicas de los pacientes.
*   **Gestión de Salas (GS):** Administración de espacios disponibles (quirófanos, consultorios, salas de espera) y asignación de recursos.
*   **Solicitud de Clínicos (SC):** Control de órdenes y solicitudes de análisis o estudios clínicos para los pacientes.
*   **Registro de Altas (RA):** Gestión de egresos hospitalarios, permitiendo mantener un historial actualizado del estado del paciente.

---

## 🛠️ Tecnologías Utilizadas

*   **Lenguaje:** C# (.NET Framework / .NET Core para Windows Forms)
*   **Base de Datos:** Microsoft SQL Server
*   **Entorno de Desarrollo:** Visual Studio

---

## 🗄️ Estructura de la Base de Datos

El sistema interactúa con una base de datos relacional que maneja la persistencia de los datos. El diseño incluye tablas principales como:

*   `CITAS`: Almacenamiento de información de consultas (Número de paciente, médico, fecha y hora).
*   `GESTIÓN_DE_SALAS`: Control del estado y asignación de las instalaciones.
*   `SOLICITUD_DE_CLÍNICOS`: Registro de estudios médicos requeridos.
*   `REGISTRO_DE_ALTAS`: Historial de pacientes dados de alta.

---

## 📦 Instalación y Configuración

Sigue estos pasos para ejecutar el proyecto de forma local:

### 1. Clonar el repositorio
```bash
git clone [https://github.com/TU_USUARIO/TU_REPOSITORIO.git](https://github.com/TU_USUARIO/TU_REPOSITORIO.git)
