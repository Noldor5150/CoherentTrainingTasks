using System;


namespace Task001
{
    class LinkToNetworkResource : TrainingMaterial
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
        public LinkToNetworkResource (string uri, Type linkType, string description, Guid uniqueId) : base(description,uniqueId)
        {
            Uri = uri;
            LinkType = linkType;
        }
    }
}
