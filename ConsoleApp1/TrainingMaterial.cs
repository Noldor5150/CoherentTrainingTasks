using System;


namespace Task001
{
    /// <summary>
    /// Empty class just for upcasting types
    /// </summary>
    class TrainingMaterial : EntityTraining, ICloneable

    {
        public TrainingMaterial ( string description, Guid uniqueId ) : base ( description, uniqueId )
        {

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
       
    }
}
