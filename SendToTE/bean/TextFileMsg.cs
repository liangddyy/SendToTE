using System;

namespace SendToTE.Model
{
    public class TextFileMsg
    {
        private string name = null;
        private String path = null;
        private String text = null;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}