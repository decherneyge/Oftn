using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oftn.Client
{

    public enum CounterType
    {
        Unknown,
        Basic

    }

    public interface ICounter
    {

         CounterType CounterType { get; }
         Guid OwnerId { get; set; }
         int CounterId { get; set; }
         string CounterName { get; set; }
         long Value { get; }
         List<ICountRecord> CountRecords { get; }

    }
}
