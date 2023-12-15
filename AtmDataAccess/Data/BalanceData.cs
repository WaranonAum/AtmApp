using AtmDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDataAccess.Data;

public class BalanceData : IBalanceData
{
    public async Task<List<BalanceModel>> PrepData()
    {
        List<BalanceModel> data = new List<BalanceModel>();

        data.Add(new BalanceModel()
        {
            BalanceBoxId = 1,
            BankNoteType = "1000",
            BankNoteValue = 1000,
            Quantity = 200
        });
        data.Add(new BalanceModel()
        {
            BalanceBoxId = 2,
            BankNoteType = "500",
            BankNoteValue = 500,
            Quantity = 200
        });
        data.Add(new BalanceModel()
        {
            BalanceBoxId = 3,
            BankNoteType = "100",
            BankNoteValue = 100,
            Quantity = 200
        });
        data.Add(new BalanceModel()
        {
            BalanceBoxId = 4,
            BankNoteType = "50",
            BankNoteValue = 50,
            Quantity = 200
        });
        data.Add(new BalanceModel()
        {
            BalanceBoxId = 5,
            BankNoteType = "20",
            BankNoteValue = 20,
            Quantity = 200
        });

        return data;
    }

    public async Task<int> RemainQuantity(List<BalanceModel> data)
    {
        int result = 0;

        foreach (var item in data)
        {
            result = result + (item.Quantity * item.BankNoteValue);
        }

        return result;
    }
}
