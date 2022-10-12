using System;
namespace CoreWeb.Models
{
    public class OperationServices : ISingletonService, ITransientService, IScopedService
    {
        Guid id;

        int no,Prodid;

        public int GetProdid()
        {
            return Prodid;
        }
        public OperationServices()
        {

            id = Guid.NewGuid();
            Random r = new Random();
            no = r.Next(100);
        }

        public int GenerateRandomNumber()
        {
            return no;
        }

        public Guid GetOperationID()
        {
            return id;
        }
    }
}
