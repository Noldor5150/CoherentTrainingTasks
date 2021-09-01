using System;


namespace Task001
{
     class TrainingLesson : EntityTraining
    {
        private TrainingMaterial[] _arrayOfTrainingMaterials;
        public enum Type { VideoLesson, TextLesson };
        public TrainingLesson (TrainingMaterial[] arrayOfTrainingMaterials, string description, Guid uniqueId) : base(description, uniqueId)
        {
            _arrayOfTrainingMaterials = arrayOfTrainingMaterials;
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
            return other != null &&
                   UniqueId == other.UniqueId;
        }


    }
}
