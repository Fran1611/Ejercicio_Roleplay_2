using System;

namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name {get; set; }
        int Health {get; }
        int AttackValue {get;} 
        int DefenseValue {get;} 
        void ReceiveAttack(int a);
        void Cure();
    }
}
