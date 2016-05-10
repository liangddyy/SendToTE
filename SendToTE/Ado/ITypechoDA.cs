using SendToTE.Model;

namespace SendToTE.Ado
{
    public interface ITypechoDA
    {
        int sendWrittings(Content content);
        void updateSlug(int cid);

    }
}