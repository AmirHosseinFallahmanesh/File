using Demo.Core.Enitites.DTO;

namespace Demo.Core.Contract
{
    public interface IOrderFacade
    {
        NewOrderMasterDTO NewOrderHeader();
        void AddOrder();

    }
}
