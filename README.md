# Proyecto de Refactorización: Patrones de Diseño

Este repositorio es una demostración práctica de cómo aplicar patrones de diseño de software para rescatar una aplicación con problemas arquitectónicos, transformándola en un sistema robusto, mantenible y escalable.

---

## El Desafío: 

La aplicación original de gestión de vehículos se encontraba en un estado crítico y difícil de mantener debido a varios problemas fundamentales:

* **Parálisis por Dependencias**: El sistema dependía de una base de datos que no existía, bloqueando por completo cualquier funcionalidad.
* **Datos Volátiles**: Al ser una aplicación web sin estado, cualquier información agregada desaparecía al actualizar la página.
* **Código "Spaghetti"**: Las responsabilidades estaban mezcladas, y el código era tan rígido que agregar un nuevo modelo de auto requería modificar múltiples archivos, arriesgando la estabilidad general.

## La Estrategia Arquitectónica

Para resolver estos desafíos, se implementó una solución integral basada en tres patrones de diseño que trabajan en conjunto:

1.  **Una Base de Datos Temporal con `Singleton`**: Para solucionar el bloqueo inmediato, el patrón **Singleton** crea un repositorio en memoria. Esta única instancia persiste a través de toda la aplicación, actuando como una base de datos temporal que permite que la aplicación funcione y sea probada sin la dependencia externa.

2.  **Construcción Limpia de Objetos con `Builder`**: Para organizar la creación de vehículos, el patrón **Builder** separa el proceso de construcción del objeto final. Esto nos permite manejar configuraciones complejas (como asignar el año actual por defecto) de una manera limpia, fluida y centralizada.

3.  **Crecimiento sin Dolor con `Factory Method`**: Para preparar el sistema para el futuro, el patrón **Factory Method** nos permite definir una interfaz para crear vehículos, pero deja que las subclases decidan qué modelo específico instanciar. ¿Necesitamos agregar un "Ford Bronco"? Simplemente creamos una nueva fábrica para él, sin tocar el código existente.


## Guía de Inicio Rápido

### Requisitos
* .NET SDK (v6.0 o superior)

### Ejecución
1.  **Clona el repositorio:**
    ```sh
    git clone https://github.com/DiegoCorrea07/DesignPatterns.git
    ```
2.  **Accede al directorio:**
    ```sh
    cd DesignPatterns
    ```
3.  **Inicia la aplicación:**
    ```sh
    dotnet run
    ```

## Beneficios Clave de la Solución

* ✅ **Funcionalidad Inmediata**: La aplicación ahora funciona y se puede probar gracias a la persistencia en memoria.
* ✅ **Código Mantenible**: Las responsabilidades están claramente definidas, haciendo el código más fácil de leer y depurar.
* ✅ **Alta Extensibilidad**: El sistema está listo para crecer, permitiendo añadir nuevos modelos de vehículos sin riesgo.
* ✅ **Preparado para el Futuro**: La transición a una base de datos real es ahora una tarea sencilla que no afectará la lógica de negocio.

## Autor

- **Diego Correa**
- GitHub: [@DiegoCorrea07](https://github.com/DiegoCorrea07)

---

## Licencia

Este proyecto está bajo licencia **MIT**.

