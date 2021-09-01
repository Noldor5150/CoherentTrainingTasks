using System;


namespace Task001
{
    class TrainingMaterial
    {
        private Guid _unicId;

        private const int LENGHT_MAX = 256;
        public Guid UnicId
        {
            get
            { 
                return _unicId;
            }
            set 
            { 
                if (value.ToByteArray().Length <= LENGHT_MAX)
                {
                    _unicId = value;
                }
            }
        }
        public TrainingMaterial (Guid umicId)
        {
            UnicId = umicId;
        }
    }
}
