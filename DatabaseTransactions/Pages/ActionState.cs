using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTransactions.Pages
{
    public enum ActionState
    {
        none,
        Create,
        Update,
        Delete,
        Read
    }
}
