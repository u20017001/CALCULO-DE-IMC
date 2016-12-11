# CALCULO-DE-IMC
SISTEMA DE CALCULO DE INDICE DE MASA CORPORAL ASOCIADO AL TIPO DE RIESGO.
El código de cálculo de IMC se basa en la fórmula IMC = PESO / ALTURA * ALTURA.

El resultado es sólo numérico por eso se hizo la modificación del código para asociar el valor numérico con el "Tipo de Riesgo" que este valor es equivalente:
  De 18.5 - 24.9 --> Riesgo Promedio,
  De 25.0 - 29.9 --> Riesgo Aumentado,
  De 30.0 - 34.9 --> Riesgo Moderado,
  De 35.0 - 39.9 --> Riesgo Severo y
  = > 40.0 --------> Riesgo Muy Severo.

La mejora del código ese hace en base al comando "Select Case" para cada uno de los casos, para este programa son 5 casos.
Esta mejora se implementó en el código del botón CALCULAR y además se agregó un LABEL de nombre “triesgo” que es donde se mostrará el Tipo de Riesgo basado en el resultado obtenido del calculo del IMC.
