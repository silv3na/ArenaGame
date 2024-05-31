namespace ArenaGame
{
    public class Soldier : Hero
    {
        private const int HealEachNthRound = 2;
        private int attackCount;
        private Bow weapon;
        public Soldier(string name) : base(name)
        {
            attackCount = 0;
            this.weapon = new Bow(bonusDamage: 13, arrows: 10);
        }

        public override int Attack()
        {
            int attack = base.Attack();

            attackCount = attackCount + 1;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }

            attack += this.weapon.UseWeapon();

            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
