namespace ArenaGame
{
    public class Sword : Weapon
    {
        public Sword(int bonusDamage) 
            : base(bonusDamage)
        {
        }

        public override int UseWeapon()
        {
            if (this.Durability <= 0)
            {
                return 0;
            }

            this.DecreaseDurability();
            return this.bonusDamage;
        }

        public override void DecreaseDurability()
        {
            this.Durability -= 10;
        }
    }
}
