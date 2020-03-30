namespace RolePlayV23
{
    public class Defender : Character
    {
        #region Instance Fields
        #endregion

        #region Constructor
        public Defender(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
        {
            Reset();
        }
        #endregion

        #region Methods & Properties
        protected override int ReceiveDamageModifyChance
        {
            get { return 45;}
        }
        protected override int CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage / 2;
        }
        #endregion
        
    }
}