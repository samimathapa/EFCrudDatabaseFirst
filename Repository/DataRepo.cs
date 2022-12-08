using EntityDatabase.Models;
using EntityDatabase.Repository;
namespace EntityDatabase.Repository
{
    public class DataRepo : InterfaceDataRepo
    {
        private DataContext _context;
        public DataRepo(DataContext context)
        {
            _context = context;
        }
        public void AddData(Data data)
        {
            _context.Datas.Add(data);
            _context.SaveChanges();
        }
        public IEnumerable<Data> GetAllDatas()
        {
            var DataList = _context.Datas.ToList();
            return DataList;
        }
        public Data GetDataDetail(int id)
        {
            Data data = _context.Datas.Find(id);
            return data;
        }
        public Data EditData(Data p)
        {
            _context.Datas.Update(p);  
            _context.SaveChanges();
            return p;
        }
        public Data DeleteData(int id)
        {
            Data data = _context.Datas.Find(id);
            _context.Datas.Remove(data);
            _context.SaveChanges();
            return data;
        }
    }
}
