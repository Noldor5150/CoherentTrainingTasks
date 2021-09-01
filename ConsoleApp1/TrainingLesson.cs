using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
     class TrainingLesson
    {
        private TrainingMaterial[] _arrayOfTrainingMaterials;

        private Guid _unicId;

        public enum Type { VideoLesson,TextLesson };
        public Guid UnicId
        {
            get { return _unicId; }
            set { if (value.ToByteArray().Length <= 256) _unicId = value; }
        }

        public Type GetLessonType(  )
        {
            
            foreach( var material in _arrayOfTrainingMaterials )
            {
                if (material is VideoMaterial)
                {
                    return Type.VideoLesson;
                }
               
            }
            return Type.TextLesson;
        }
    }
}
