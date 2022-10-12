using System;

namespace CoreWeb.Models
{
    public interface ITransientService
    {
        Guid GetOperationID();
        int GenerateRandomNumber();
        int GetProdid();
    }

    public interface IScopedService
    {
        Guid GetOperationID();
    }
    public interface ISingletonService
    {
        Guid GetOperationID();
        int GenerateRandomNumber();
    }
}
