using EntityDatabase.Models;
namespace EntityDatabase.Repository
{
    public interface InterfaceDataRepo
    {
        void AddData(Data data);
        IEnumerable<Data> GetAllDatas();
        Data GetDataDetail(int id);
        Data EditData(Data p);
        Data DeleteData(int id);    
    }
}