namespace RoleplayGame
{
    // Interfaz IAttack implementada por todos los Items que contengan un valor de ataque.
    public interface IAttack
    {
        int AttackValue
        {
            get;
        }
    }
}