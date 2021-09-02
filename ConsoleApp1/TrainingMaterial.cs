using System;


namespace Task001
{
    /// <summary>
    /// Empty class just for upcasting types
    /// </summary>
    class TrainingMaterial : EntityTraining
    {

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="description">  </param>
        /// <param name="uniqueId"></param>
        public TrainingMaterial (string description, Guid uniqueId) : base(description, uniqueId)
        {

        }
    }
}
