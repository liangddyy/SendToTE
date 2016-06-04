using System;

namespace SendToTE.Model
{
    public class ImgFileMsg
    {
        public String name;

        public String path;
        public String url;
        public ImgFileMsg(String name, String path)
        {
            this.name = name;
            this.path = path;
            this.url = null;
        }
        public ImgFileMsg()
        {
            this.name = null;
            this.path = null;
            this.url = null;
        }
    }
}