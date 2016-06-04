using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SendToTE.Manage
{
    class Upload
    {
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="uri"></param>
        /// <param name="encodingType"></param>
        /// <returns></returns>
        public string SendFile(string fileName, Uri uri, string encodingType = "UTF-8")
        {
            
            WebClient myWebClient = new WebClient();
            byte[] responseArray = myWebClient.UploadFile(uri, "POST", fileName);

            return Encoding.GetEncoding(encodingType).GetString(responseArray);
        }
    }
}
