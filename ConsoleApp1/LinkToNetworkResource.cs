using System;


namespace Task001
{
    /// <summary>
    /// Class for implementing link to training network, inherits form TrainingMaterial and implements ICloneable interface;
    /// </summary>
    class LinkToNetworkResource : TrainingMaterial, ICloneable
    {
        private string _uri;
        public string Uri
        {
            get 
            { 
                return _uri;
            }
            set 
            {
                if (value.Length > 0)
                {
                    _uri = value;
                }
                else 
                {
                    throw new ArgumentException("URI can vot be emty!!!");
                }
            }
        }
        public enum Type { Unknown, Html, Image, Audio, Video};
        public Type LinkType { get; private set; }

        /// <summary>
        /// Class parametrized constructor;
        /// </summary>
        /// <param name="uri"> string to describe URI </param>
        /// <param name="linkType"> enumerated value to describe type of link </param>
        /// <param name="description"> string for description of link </param>
        /// <param name="uniqueId"> Guid type ID </param>
        public LinkToNetworkResource ( string uri, Type linkType, string description, Guid uniqueId ) : base ( description,uniqueId ) 
        {
            Uri = uri;
            LinkType = linkType;
        }

        /// <summary>
        /// implementing ICLoneable;
        /// </summary>
        /// <returns> returns a deep copy of itself </returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
