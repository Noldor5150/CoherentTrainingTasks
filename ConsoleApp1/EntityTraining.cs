using System;


namespace Task001
{
    class EntityTraining
    {
        private string _description;

        private const int DESCRIPTION_LENGHT_MAX = 256;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if ( String.IsNullOrEmpty( value ) || value.Length <= DESCRIPTION_LENGHT_MAX )
                {
                    _description =  value;
                }

                else
                {
                    throw new ArgumentException("Description is out of range", nameof(_description));
                }
            }
        }
        public Guid UniqueId { get; set; }
        public EntityTraining(string description, Guid uniqueId)
        {
            Description = description;
            UniqueId = uniqueId;
        }
        public override string ToString()
        {
            return _description;
        }

        public override bool Equals(object other)
        {
            if(other == null || !(other is EntityTraining))
            {
                return false;
            }
            return (other as EntityTraining).UniqueId == UniqueId;
        }
    }
}
