# Vive100Evolution

Sebastian Ayala 000424790

Esteban Gallon 000425705

Juan Sebastian Giraldo 000425629

Alejandro Angarita 000425695

## Cambios en la Implementación

Hemos realizado cambios en la implementación del proyecto. A continuación, se mencionan algunas de las modificaciones clave:

### Clase Bebida

La clase `Bebida` ha sido modificada para incluir nuevas propiedades y métodos que reflejan los cambios en el diseño. Ahora, la clase `Bebida` contiene las siguientes propiedades:

- `Nivel`: Representa el nivel de la bebida.
- `TiempoParaGenerar`: Calcula el tiempo de generación basado en el nivel de la bebida.
- `ValorMoneda`: Calcula el valor de moneda basado en el nivel de la bebida.

Se ha agregado un nuevo método `CombinarCon` que permite combinar dos bebidas del mismo nivel para crear una nueva bebida.

### Clase Jugador

La clase `Jugador` ha sido actualizada para incluir una referencia a la tienda y permitir al jugador comprar mejoras. Se han agregado los siguientes atributos:

- `TiempoAparicionBebida`: Representa el tiempo de aparición de las bebidas.
- `MultiplicadorDinero`: Representa el multiplicador de dinero que afecta las ganancias del jugador.

Se han implementado métodos para comprar mejoras y ganar monedas cuando una bebida alcanza un nivel específico.

### Clase Tienda

La clase `Tienda` ha sido actualizada para permitir la compra de mejoras por parte del jugador. Ahora, la tienda tiene métodos para agregar mejoras, obtener mejoras disponibles y comprar mejoras.

### Clase Mejora

La clase `Mejora` permanece sin cambios y sigue representando mejoras disponibles en la tienda.

Por ahora dejamos de lado las otras clases debido a que tienen mas que ver con el control en unity pero las dejaremos mencionadas, InterfazDeUsuario, Controlador, GestorDeGraficos.
