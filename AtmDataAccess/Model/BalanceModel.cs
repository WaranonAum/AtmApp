using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDataAccess.Model;

public class BalanceModel
{
    public int BalanceBoxId { get; set; }
    public string BankNoteType { get; set; }
    public int BankNoteValue { get; set; }
    public int Quantity { get; set; }
}
