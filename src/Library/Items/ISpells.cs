using System;

namespace RoleplayGame
{
    
    /*Se crea la interfaz ISpells para que el libro de hechizos pueda tener varios hechizos.
    Los hechizos deberan implementar la interfaz para ser del tipo ISpells y poder ser agregadas al libro de hechizos
    Cumple con polimorifismo porque las operaciones son implementadas por dos o mas objetos de diferentes tipos.
    Cumple además con LSP ya que el código funciona de igual manera cuando el objeto es subtipo de ISpells*/
    public interface ISpells
    {
        int AttackValue {get;}

        int DefenseValue {get;}
    }
}