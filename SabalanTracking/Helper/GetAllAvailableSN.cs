using SabalanTracking.Models;

namespace SabalanTracking.Helper
{
    public class GetAllAvailableSN
    {
        public static List<Proces> GetAllSNs(List<Proces> processes,List<ProcessDetaile> detailes)
        {
            List<Proces> list = new List<Proces>();
            foreach (Proces process in processes)
            {
               double sum= detailes.Where(t => t.Product_SN == process.SN).Sum(t => t.QntyPerPc);
                if (process.Quantity>sum)
                {
                    process.Quantity = process.Quantity - sum;
                    list.Add(process);
                }
            }
            return list;
        }
    }
}
