# Interfaces Inteligentes - Práctica 2 - Scripts
## Fabio Bianchini Cano

### Ejercicio 1. Cubo, esfera y plano con diferentes configuraciones.

  1. Ninguno de los objetos será físico.
    
      <img src="gifs/1_a.png" width=300>
  2. La esfera tiene físicas, el cubo no.

      <img src="gifs/1_b.gif" width=300>
  3. La esfera y el cubo tienen físicas.

      <img src="gifs/1_c.gif" width=300>
  4. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo.

      <img src="gifs/1_d.gif" width=300>
  5. La esfera tiene físicas y el cubo es de tipo IsTrigger.

      <img src="gifs/1_e.gif" width=300>
  6. La esfera tiene físicas y el cubo es de tipo IsTrigger y tiene físicas.

      <img src="gifs/1_f.gif" width=300>
  7. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.

      <img src="gifs/1_g.gif" width=300>



### Ejercicio 2. Character Controller.

  Se ha agregado un script que controla el movimiento del cubo, que representa a nuestro jugador.

  Mediante un barra deslizante en el inspector de objetos modificamos el valor de la velocidad del mismo, en tiempo real.

  <img src="gifs/2.gif" width=600>

  
  También implementado con rotaciones

  <img src="gifs/2_b.gif" width=600>


### Ejercicio 3
Para el ejercicio 3 en la escena se añaden varios tipos de objetos que interaccionan con el jugador de diversas maneras.


- Cilindros que aumentan su tamaño y la puntuación del jugador.

    <img src="gifs/3_a.gif" width=600>
- Cilindros que cuando el jugador pulsa el espacio y está lo suficientemente cerca, se les a la dirección opuesta.

    <img src="gifs/3_b.gif" width=600>
- Cilindros que huyen del jugador.

    <img src="gifs/3_c.gif" width=600>
- Segundo jugador representado por una esfera que se mueva con las teclas *IJKL*.

    <img src="gifs/3_d.gif" width=600>
- Cubos que cuando el jugador principal los toca, disminuyen su tamaño, y si los toca el jugador secundario, aumentan.

    <img src="gifs/3_e.gif" width=600>