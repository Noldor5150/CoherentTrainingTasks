using System;


namespace Task001
{
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
        public TrainingLesson (TrainingMaterial[] arrayOfTrainingMaterials, byte[] version, string description, Guid uniqueId) : base(description, uniqueId)
        {
            ArrayOfTrainingMaterials = arrayOfTrainingMaterials;
            _version = version;
        }
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
        public object Clone()
        {
            //return this.MemberwiseClone(); 
            TrainingLesson newLesson = (TrainingLesson)this.MemberwiseClone();
            newLesson.ArrayOfTrainingMaterials = (TrainingMaterial[])this.MemberwiseClone();
            newLesson.Version = (byte[])this.MemberwiseClone();
            newLesson.Description = (string)this.MemberwiseClone();
            newLesson.UniqueId = (Guid)this.MemberwiseClone();
            return newLesson;

        }
    }
}
