#CONTADORES DE NÚMEROS NATURALES, NÚMEROS DE LA SECUENCIA DE FIBONACCI Y NÚMEROS PRIMOS

En este programa se crearon tres funciones, usando la interfaz IEnumerable. Cada interfaz conntiene una serie de números que se produccen con lógica diferentes.

La interfaz de números naturales, produce númerosnaturales de 1 a max, donde max es un parametro de la función.

En la segunda, la lógica usada es para producir números de la secuencia de Fibonacci. Primero se enumeran los dos primers números, y los siguientes se priducen en la suma de esos números en una variable 'third'. La variable thrid es guardada en el segundo número y el valor del segundo se guarda en el primero (esto es necesario para calcular el siguiente third). Estos números se imprimen hasta un valor top que es recibido por el método como parámetro.

En la tercera, se enumeran todos los números primos entre 1 y un valor top. Estos valores primos se calculan usando evaluando el módulo de todos los números entre 1 y top y todos los números entre 2 y la raíz del número a evaluar.

Estas funciones se hicieron en C#.