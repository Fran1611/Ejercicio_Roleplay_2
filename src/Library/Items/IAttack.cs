namespace RoleplayGame
{
    /*Se crea la interfaz IAttack con la oepración que tienen en comun los Items con valor de ataque.
    Los Items que implementan esta interfaz ahora serán también de tipo IAttack.
    La operación es polimorifica porque es implementada por dos o mas objetos de diferentes tipos.
    Cumple además con LSP ya que el código funciona de igual manera cuando el objeto es subtipo de IAttack.*/
    public interface IAttack
    {
        int AttackValue{get;}
    }
}