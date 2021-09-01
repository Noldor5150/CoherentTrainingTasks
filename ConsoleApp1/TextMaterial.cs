using System;


namespace Task001
{
     class TextMaterial : TrainingMaterial 
    {
        private string _textContent;

        private const int MAX_TEXT_CONTENT_LENGTH = 10000;
        public string TextContent
        {
            get
            {
                return _textContent;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < MAX_TEXT_CONTENT_LENGTH)
                {
                    throw new ArgumentException("TextContent is out of range, or emty");
                }
                else
                {
                    _textContent = value;
                }
            }
        }
        public TextMaterial(string textContent, string description, Guid uniqueId): base(description, uniqueId)
        {
            TextContent = textContent;
        }
    }
}
