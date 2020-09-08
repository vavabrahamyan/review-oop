using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class ClientAccount<T> where T : IAccount, IClient
    {

    }
}
