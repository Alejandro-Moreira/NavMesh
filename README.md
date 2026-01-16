# Proyecto Unity – Navegación, FX y Configuración de Build

## Descripción del proyecto
Este proyecto fue desarrollado en Unity como parte de una actividad formativa basada en el curso de Udemy **“La guía definitiva del desarrollo de videojuegos con Unity”**.  
El objetivo es demostrar la aplicación práctica de conceptos clave relacionados con efectos visuales, navegación con inteligencia artificial, configuración del proyecto y generación de ejecutables.

La escena consiste en un entorno tipo laberinto donde un jugador puede desplazarse libremente mientras es perseguido por enemigos que utilizan Navigation Mesh. Al colisionar con un enemigo, este se destruye y se genera un efecto visual mediante un sistema de partículas.

## Objetivo académico
Aplicar los conocimientos adquiridos en los capítulos revisados del curso para:
- Incrementar la capacidad de exploración en Unity
- Implementar soluciones prácticas a problemas comunes en el desarrollo de videojuegos
- Integrar múltiples sistemas del motor en una escena funcional

## Capítulos del curso aplicados
- **Capítulo 12 – Effects (FX):**  
  Uso de Particle System para efectos visuales al eliminar enemigos.
- **Capítulo 13 – Crear un ejecutable del juego:**  
  Configuración de Build Settings y generación del ejecutable para PC.
- **Capítulo 16 – Configuración del proyecto:**  
  Organización de carpetas y buenas prácticas de estructura.
- **Capítulo 17 – Configuración del Player:**  
  Ajustes de nombre del producto, resolución y parámetros generales.
- **Capítulo 18 – Navigation Mesh:**  
  Implementación de IA básica usando NavMeshSurface y NavMeshAgent.

## Funcionalidades principales
- Movimiento del jugador con controles **WASD**
- Colisiones físicas correctas usando Rigidbody y Colliders
- Enemigos con IA que navegan el laberinto usando NavMesh
- Paredes que actúan como obstáculos reales
- Efectos visuales mediante Particle System instanciados dinámicamente
- Generación de ejecutable independiente del editor de Unity

## Tecnologías utilizadas
- **Unity** (versión 2022 o superior)
- **C#**
- **AI Navigation Package**
- **Particle System**

## Ejecución del proyecto
1. Abrir el proyecto en Unity Hub
2. Cargar la escena principal desde la carpeta `Scenes`
3. Presionar **Play** para ejecutar en el editor  
   o  
4. Ejecutar el archivo `.exe` generado desde la carpeta de Build

## Contenido del repositorio
- Código fuente completo
- Scripts personalizados
- Prefabs de enemigos y efectos visuales
- Escena principal del proyecto
- Configuración necesaria para compilar el juego
