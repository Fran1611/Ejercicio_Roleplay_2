namespace RoleplayGame
{
    //Agrego las otras dos interfaces porque hay metodos que los personajes usan

    //IAttack -----> AttackValue
    //IDefensa ------> DefenceValue
    //ICharacter ------->  ReciveAttack(int a), Cure(), ademas los name y health get y set 
    public class Dwarf : ICharacter, IAttack, IDefensa
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Axe.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
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
