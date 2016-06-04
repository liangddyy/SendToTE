namespace SendToTE.test
{
    public class JsonTest
    {
        public class Person
        {
            public string name; //姓名
            public int age; //年龄
            public bool sex_is_male; //性别

            public struct Partner //伙伴
            {
                public string partner_name; //伙伴姓名
                public int partner_age; //伙伴年龄
                public bool partner_sex_is_male; //伙伴性别
            }
            public Partner partner;

            public string[] achievement; //成就

            //构造函数
            public Person()
            {
                name = "";
                age = 0;
                sex_is_male = true;
                partner.partner_name = "";
                partner.partner_age = 0;
                partner.partner_sex_is_male = true;
                achievement = null;
            }
        }
    }
}