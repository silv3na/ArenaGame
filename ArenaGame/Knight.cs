namespace ArenaGame
{
    public class Knight : Hero
    {
        const int BlockDamageChance = 10;
        private const int ExtraDamageChance = 5;
        private Staff weapon;

        public Knight(string name) : base (name)
        {
            this.weapon = new Staff(bonusDamage: 30, shield: 100);
        }

        public override void TakeDamage(int incomingDamage)
        {
            //Apply armor
            int damageReduceCoef = Random.Shared.Next(20, 61);
            incomingDamage = 
                incomingDamage - ((incomingDamage * damageReduceCoef * this.weapon.UseShield()) / 100);
            //Apply special skill: block
            if (ThrowDice(BlockDamageChance)) incomingDamage = 0;
            //Default behavior
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            int bonusDamageFromWeapon = this.weapon.UseWeapon();
            if (ThrowDice(ExtraDamageChance)) attack = (attack * 150 * bonusDamageFromWeapon)/ 100;
            return attack;
        }
    }
}
