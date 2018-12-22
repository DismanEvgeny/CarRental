using System;
using Repositories;
namespace Services
{
    public class CheckConnectionService
    {
        public static bool check()
        {
            return new DataBaseUtils().checkConnection();
        }

    }
}
