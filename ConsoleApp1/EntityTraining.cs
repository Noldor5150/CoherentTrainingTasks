using System;

/// <summary>
/// App's base class
/// </summary>

namespace Task001
{
    class EntityTraining
    {

        private string _description;

        private const int DESCRIPTION_MAX_LENGTH = 256;
        public string Description
        {
            get

            {
                return _description;
            }
            set
            {
                if ( String.IsNullOrEmpty( value ) || value.Length <= DESCRIPTION_MAX_LENGTH )
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
        /// <summary>
        /// Class parametrized constructor also works as base constructor for "children" classes;
        /// </summary>
        /// <param name="description"> simple description limited by const int DESCRIPTION_MAX_LENGTH </param>
        /// <param name="uniqueId"> Guid type ID </param>
        public EntityTraining ( string description, Guid uniqueId )
        {

            Description = description;
            UniqueId = uniqueId;
        }
        /// <summary>
        /// Overriding for simplicity;
        /// </summary>
        /// <returns> _description </returns>
        public override string ToString()
        {
            return _description;
        }
        /// <summary>
        /// overriding for simplicity and checking only Guid Id equality;
        /// </summary>
        /// <param name="other"> it is object we com[ering to</param>
        /// <returns> true orfalse</returns>
        public override bool Equals ( object other )
        {
            if ( other == null || !( other is EntityTraining ))
            {
                return false;
            }
            return ( other as EntityTraining ).UniqueId == UniqueId;
        }
    }
}
