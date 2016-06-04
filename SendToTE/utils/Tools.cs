using System;

namespace SendToTE.Manage
{
    class Tools
    {
        /// <summary>
        /// 获取时间戳(现在)
        /// </summary>
        /// <returns></returns>
        static public int getDateStampNow()
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(System.DateTime.Now - startTime).TotalSeconds;
        }

        static public string getDataTimeString()
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            //string strYMD = currentTime.ToString("D");
            //获取年月日格式
            return currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString();
        }
        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        private DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private int DateTimeToStamp(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
    }
}