using System;

namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name {get; set; }
        int Health {get; private set; }

        void ReciveAttack(int a);
        void Cure();
    }
}