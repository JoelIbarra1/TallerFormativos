
# Best Practices: Taller de Patrones de Diseño - Aplicativo de Automóviles

Este proyecto corresponde al desarrollo del taller propuesto por la empresa ficticia **Codificando Con Patrones Cía. Ltda.**, donde se aplican principios SOLID y patrones de diseño para mejorar la arquitectura de un sistema de gestión de vehículos.

## Requisitos del Proyecto

- Implementar métodos para agregar vehículos Mustang y Explorer desde la Home Page.
- Resolver errores del repositorio actual reportados por QA.
- Simular almacenamiento sin base de datos (ya que aún no está disponible).
- Preparar el sistema para agregar más propiedades por defecto al objeto `Vehicle`.
- Incorporar nuevos modelos de forma escalable (como "Escape").

---

## Problemas Identificados

- El repositorio implementado previamente no funciona correctamente.
- No existe una base de datos lista para pruebas.
- El sistema está rígido ante nuevos modelos.
- El objeto `Vehicle` requiere múltiples propiedades (año actual y 20 más en un futuro).

---

##  Solución Técnica

Se aplicaron tres patrones de diseño clave:

### 1. Singleton
Permite almacenar los vehículos en memoria, simulando la funcionalidad del repositorio mientras se desarrolla la base de datos real.

>  Clase: `VehicleRepository`  
>  Instancia única compartida en todo el sistema.

---

### 2. Factory Method
Se crean fábricas específicas para cada modelo (`MustangFactory`, `ExplorerFactory`, `EscapeFactory`), permitiendo extender sin modificar código existente.

>  Interfaz: `VehicleFactory`  
>  Implementaciones: `MustangFactory`, `ExplorerFactory`, `EscapeFactory`  
>  Extensible y modular

---

### 3. Builder
Facilita la construcción del objeto `Car` con múltiples propiedades por defecto (como el año actual). Aísla la lógica de inicialización compleja.

>  Clase: `CarBuilder`  
>  Método: `AddDefaultProperties()` para facilitar futuras expansiones.

---

##  Principios SOLID Aplicados

| Principio | Aplicación |
|----------|------------|
| SRP (Responsabilidad Única) | Cada clase tiene un propósito específico (builder, repositorio, fábrica). |
| OCP (Abierto/Cerrado) | Nuevos modelos o propiedades pueden añadirse sin modificar código existente. |

---

##  Estructura del Proyecto

```
 src/
├── Builders/
│   └── CarBuilder.cs
├── Factories/
│   ├── VehicleFactory.cs
│   ├── MustangFactory.cs
│   ├── ExplorerFactory.cs
│   └── EscapeFactory.cs
├── Interfaces/
│   ├── IVehicle.cs
│   └── IVehicleBuilder.cs
├── Models/
│   └── Car.cs
├── Repository/
│   └── VehicleRepository.cs
└── Program.cs / HomePage.cs
```

---

##  Estado Actual

-  Repositorio funcional en memoria
-  Métodos para agregar Mustang y Explorer
-  Preparado para más modelos (Factory)
-  Listo para nuevas propiedades por defecto (Builder)



