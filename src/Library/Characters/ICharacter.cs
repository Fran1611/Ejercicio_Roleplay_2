using System;

namespace RoleplayGame
{
    /*Se crea la interfaz ICharacter con todas las oepraciones que tienen en comun los personajes.
    Los personajes que implementan esta interfaz ahora serán también de tipo ICharacter.
    Las operaciones son polimorifcas porque son implementadas por dos o mas objetos de diferentes tipos.

    Cumple además con LSP ya que el código funciona de igual manera cuando el objeto es subtipo de ICharacter.*/
    public interface ICharacter
    {
        int AttackValue {get; }
        int DefenseValue {get; }
        string Name {get;}
        int Health {get;}
        void ReceiveAttack(int a);
        void Cure();
    }
}
