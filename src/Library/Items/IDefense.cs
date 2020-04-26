namespace RoleplayGame
{
    /*Se crea la interfaz ICharacter con operacion que tienen en comun todos los Items con valor de defensa.
    Los Items que implementan esta interfaz ahora serán también de tipo IDefense.
    La operación es polimorifca porque es implementada por dos o mas objetos de diferentes tipos.
    Cumple además con LSP ya que el código funciona de igual manera cuando el objeto es subtipo de IDefense.*/
    public interface IDefense
    {
        int DefenseValue{get;}
    }
}