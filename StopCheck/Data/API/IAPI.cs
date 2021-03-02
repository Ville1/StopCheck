using System.Collections.Generic;

namespace StopCheck.Data.API
{
    public interface IAPI
    {
        Stop GetStop(string id);
        List<Stop> Search(string search);
    }
}
