using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oftn.Client
{
    public interface ICountRecord
    {
        long CountRecordId { get; set;}
        int CounterId { get; set; }
        DateTime TimeStamp { get; set; }
        int Size {get;}
        
    }
}
