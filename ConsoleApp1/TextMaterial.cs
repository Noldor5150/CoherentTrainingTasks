using System;


namespace Task001
{
    /// <summary>
    /// Class for implementing text material, inherits from TrainingMaterial and implements ICloneable interface;
    /// </summary>
    class TextMaterial : TrainingMaterial, ICloneable 
    {
        private string _textContent;

        private const int TEXT_CONTENT_MAX_LENGTH = 10000;
        public string TextContent
        {
            get
            {
                return _textContent;
            }
            set
            {
                if ( String.IsNullOrEmpty( value ) || value.Length > TEXT_CONTENT_MAX_LENGTH )
                {
                    throw new ArgumentException( "TextContent is out of range, or empty" );
                }
                else
                {
                    _textContent = value;
                }
            }
        }
        /// <summary>
        /// Class parametrized constructor;
        /// </summary>
        /// <param name="textContent"> string to describe text content limited by const int TEXT_CONTENT_MAX_LENGTH </param>
        /// <param name="description"> string for description of text material </param>
        /// <param name="uniqueId"> Guid type ID </param>
        public TextMaterial ( string textContent, string description, Guid uniqueId ): base ( description, uniqueId )
        {
            TextContent = textContent;
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
