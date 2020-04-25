using System;

namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name {get; set; }
        int Health {get; private set; }
        int AttackValue {get;} 
        int DefenseValue {get;} 
        void ReciveAttack(int a);
        void Cure();
    }
}
