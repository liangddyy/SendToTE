using System;
using SendToTE.Model;

namespace SendToTE.Ado
{
    public interface ITypechoDA
    {
        int sendWrittings(Content content,String contentTableName);
        void updateSlug(int cid, String contentTableName);
    }
}