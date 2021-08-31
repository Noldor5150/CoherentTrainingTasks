using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    class TrainingMaterial
    {
        private Guid _unicId;
        public Guid UnicId
        {
            get { return _unicId; }
            set { if (value.ToByteArray().Length <= 256) _unicId = value; }
        }
        public TrainingMaterial (Guid umicId)
        {
            UnicId = umicId;
        }
    }
}
