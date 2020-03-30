namespace RolePlayV23
{
    public class Damager : Character
    {
        #region Constructor
        public Damager(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
        {
            Reset();
        }
        #endregion

        #region Methods & Properties
        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        protected override int CalculateModifiedDealDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }

        #endregion
    }
}