//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace AjunaExample.NetApiExt.Generated.Model.orml_vesting.module
{
    
    
    public enum Error
    {
        
        ZeroVestingPeriod = 0,
        
        ZeroVestingPeriodCount = 1,
        
        InsufficientBalanceToLock = 2,
        
        TooManyVestingSchedules = 3,
        
        AmountLow = 4,
        
        MaxVestingSchedulesExceeded = 5,
    }
    
    /// <summary>
    /// >> 190 - Variant[orml_vesting.module.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
