using System;
using System.Collections.Generic;
using SendToTE.Model;

namespace SendToTE.Ado
{
    public interface ITypechoDA
    {
        int sendWrittings(Content content,String contentTableName);
        void updateSlug(int cid, String contentTableName);
        List<Metas> selMetas();
        void insertRelations(int cid,int mid, String contentTableName);

    }
}