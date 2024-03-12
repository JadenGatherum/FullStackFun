using System.Collections.Generic;

namespace APIFun.Data
{
    public interface iFoodRepository
    {
        IEnumerable<MarriottFood> Foods { get; }
    }
}
