namespace RoleplayGame
{
    //Agrego las otras dos interfaces porque hay metodos que los personajes usan

    //IAttack -----> AttackValue
    //IDefensa ------> DefenceValue
    //ICharacter ------->  ReciveAttack(int a), Cure(), ademas los name y health get y set 
    public class Wizard : ICharacter, IAttack, IDefensa
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int IAttack.AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public int IDefensa.DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int damage)
        {
            this.Health = this.Health - damage;
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}
