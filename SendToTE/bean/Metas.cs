using System;

namespace SendToTE.Model
{
    public class Metas
    {
        private string mid;
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Mid
        {
            get { return mid; }
            set { mid = value; }
        }
        public string toString()
        {
            return Name + "-" + Mid;
        }
    }
}