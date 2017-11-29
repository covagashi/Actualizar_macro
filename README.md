### Actualizar macro en EPLAN electric P8

Este script es ejecutable, sirve para actualizar macros en EPLAN ELECTRIC P8. 

  Al insertar una macro y cambiar de variable con un objeto contenedor, esta macro no se actualiza automaticamente.
  Este script se puede asignar a un boton en la barra de herramientas con el siguiente codigo.
  ```[C#]

  ExecuteScript /ScriptFile:C:\Users\Public\EPLAN\Data\Scripts\Actualizarmacro.cs
    
```
Si la ruta tiene algún espacio entre medio usar " "
  ```[C#]

  ExecuteScript /ScriptFile:"C:\Users\Public\EPLAN ELECTRIC\Data\Scripts\Actualizarmacro.cs"
    
```
Es un codigo basico y simple que te  ahorra tiempo.

