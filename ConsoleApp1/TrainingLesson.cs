using System;


namespace Task001
{
     class TrainingLesson : EntityTraining, IVersionable
    {
        public TrainingMaterial[] ArrayOfTrainingMaterials { get; set; }
        public byte[] Version { get; set; }
        public enum Type { VideoLesson, TextLesson };
        public TrainingLesson (TrainingMaterial[] arrayOfTrainingMaterials, byte[] version, string description, Guid uniqueId) : base(description, uniqueId)
        {
            ArrayOfTrainingMaterials = arrayOfTrainingMaterials;
            Version = version;
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
        public bool Equals(TrainingMaterial other)
        {
            return other != null && UniqueId == other.UniqueId;
        }
        public void ReadVersion(byte[] array)
        {
            throw new NotImplementedException();
        }
        public void InstallVersion(byte[] array)
        {
            throw new NotImplementedException();
        }
    }
}
