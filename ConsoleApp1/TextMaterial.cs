using System;


namespace Task001
{
     class TextMaterial : TrainingMaterial 
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
                if ( String.IsNullOrEmpty(value) || value.Length > TEXT_CONTENT_MAX_LENGTH )
                {
                    throw new ArgumentException( "TextContent is out of range, or empty" );
                }
                else
                {
                    _textContent = value;
                }
            }
        }
        public TextMaterial( string textContent, string description, Guid uniqueId): base(description, uniqueId )
        {
            TextContent = textContent;
        }
    }
}
