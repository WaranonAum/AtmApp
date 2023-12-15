using AtmDataAccess.Model;

namespace AtmDataAccess.Data
{
    public interface IBalanceData
    {
        Task<List<BalanceModel>> PrepData();
        Task<int> RemainQuantity(List<BalanceModel> data);
    }
}