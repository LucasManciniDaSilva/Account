using System;
namespace Account.Entities.Enum
{
    public enum Operation : int
    {
        Cheking = 0,
        Pending = 1,
        Accepted = 2,
        Canceled = 3,
        Ready = 4
    }
}
