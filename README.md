# 🏥 Hospital Management System

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-512BD4?style=for-the-badge&logo=.net&logoColor=white)

Aplicación de escritorio interactiva desarrollada en **C# (.NET)** y gestionada con una base de datos relacional en **SQL Server**. Este sistema automatiza y centraliza los flujos operativos clave de una institución médica, desde el control de agendas hasta la administración contable interna.

---

## 💻 Módulos del Sistema

La interfaz de usuario está construida de manera modular mediante eventos síncronos en Windows Forms, dividiéndose en 5 pilares operativos:

*   📅 **Citas:** Control total para listar, consultar, modificar y borrar la programación de consultas médicas (vínculo directo con médicos, pacientes y consultorios).
*   🏢 **Gestión de Salas:** Monitoreo y asignación de disponibilidad de espacios clínicos e infraestructura del hospital.
*   📊 **Sistema Contable:** Administración financiera de los servicios prestados y flujos transaccionales internos.
*   👥 **Registro de Pacientes:** Base de datos centralizada para el alta y seguimiento único de los pacientes mediante número de registro (NP).
*   📝 **Registro de Actividad:** Historial clínico automatizado para el almacenamiento y consulta de diagnósticos médicos.

---

## 🗄️ Arquitectura de Datos (SQL)

El backend de persistencia se compone de una estructura relacional optimizada mediante el script `Hospital.sql`, el cual inicializa el entorno con las siguientes entidades principales:

```sql
-- Tablas núcleo del sistema
- CITAS                  -- Guarda: Fecha, Paciente, Hora, Médico, Consultorio, Edad y NP.
- GESTIÓN_DE_SALAS       -- Monitoreo de salas clínicas.
- REGISTRO_DE_ACT        -- Historial de diagnósticos asignados.
- REGISTRO_DE_PACIENTES  -- Control de índices de pacientes (NP).
- SISTEMA_CONTABLE       -- Transacciones y registros numéricos financieros.
---

## 🛠️ Clonación e Inicialización Local

Para correr el entorno de desarrollo en tu máquina:

```bash
# 1. Clona este repositorio
git clone [https://github.com/Daniel13mtze/hospital-management-system.git](https://github.com/Daniel13mtze/hospital-management-system.git)

# 2. Configura la Base de Datos
# - Abre SQL Server Management Studio (SSMS)
# - Ejecuta el script 'Hospital.sql' para levantar la estructura

# 3. Compila en Visual Studio
# - Abre la solución (.sln), configura las credenciales de tu servidor local y presiona F5.
---
