using System;


namespace Task001
{
    /// <summary>
    /// Intermediate class for separation of TrainingLesson;
    /// </summary>
    class TrainingMaterial : EntityTraining, ICloneable

    {
        public TrainingMaterial ( string description, Guid uniqueId ) : base ( description, uniqueId )
        {

        }

        /// <summary>
        /// implementing ICLoneable;
        /// </summary>
        /// <returns> returns a deep copy of itself </returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
       
    }
}
