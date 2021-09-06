using System;


namespace Task001
{
    /// <summary>
    /// Class for implementing training lesson, inherits from EntityTraining and implements ICloneable and IVersionable interfaces;
    /// </summary>
    class TrainingLesson : EntityTraining, IVersionable, ICloneable
    {
        private const int VERSION_EXACT_LENGTH = 8;

        private byte[] _version;
        public byte[] Version 
        {
            get
            {
                return _version;
            }
            set
            {
                if (value.Length == VERSION_EXACT_LENGTH)
                {
                    _version = value;
                }
                else
                {
                    throw new ArgumentException("Version is not 8bytes!!!");
                }
            }
        }
        public TrainingMaterial[] ArrayOfTrainingMaterials { get; set; }
        public enum Type { VideoLesson, TextLesson };

        /// <summary>
        /// Class parametrized constructor;
        /// </summary>
        /// <param name="arrayOfTrainingMaterials"> array of TrainingMaterial type</param>
        /// <param name="version"> byte array, implemetation of IVersionable interface, limited by const int VERSION_EXACT_LENGTH  </param>
        /// <param name="description"> string for description of training lesson </param>
        /// <param name="uniqueId"> Guid type ID </param>
        public TrainingLesson (TrainingMaterial[] arrayOfTrainingMaterials, byte[] version, string description, Guid uniqueId) : base(description, uniqueId)
        {
            ArrayOfTrainingMaterials = arrayOfTrainingMaterials;
            _version = version;
        }

        /// <summary>
        /// method for getting type of training lesson;
        /// </summary>
        /// <param name="arrayOfTrainingMaterials"> array of TrainingMaterial type </param>
        /// <returns> enumerated Type</returns>
        public Type GetLessonType(TrainingMaterial[] arrayOfTrainingMaterials)
        {
            foreach (var material in arrayOfTrainingMaterials)
            {
                if (material is VideoMaterial)
                {
                    return Type.VideoLesson;
                }
            }
            return Type.TextLesson;
        }

        /// <summary>
        /// implementing ICLoneable;
        /// </summary>
        /// <returns> returns a deep copy of itself </returns>
        public object Clone()
        {
            
            TrainingLesson newLesson = ( TrainingLesson )this.MemberwiseClone();
            var newTrainingMaterialArray = new TrainingMaterial[ArrayOfTrainingMaterials.Length];
            for ( var i = 0; i < ArrayOfTrainingMaterials.Length; i++ )
            {
                newTrainingMaterialArray[i] = ( TrainingMaterial ) ArrayOfTrainingMaterials[i].Clone();
            }
            newLesson.ArrayOfTrainingMaterials = newTrainingMaterialArray;
            return newLesson;

        }
    }
}
