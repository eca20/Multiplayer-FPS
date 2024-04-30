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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_battle_mogs.pallet
{
    
    
    public enum Error
    {
        
        NoOrganizer = 0,
        
        ConfigIndexOutOfRange = 1,
        
        ConfigUpdateInvalid = 2,
        
        PriceInvalid = 3,
        
        FounderAction = 4,
        
        MogwaiNotForSale = 5,
        
        MogwaiDoesntExists = 6,
        
        MaxMogwaisInAccount = 7,
        
        MogwaiAlreadyExists = 8,
        
        MogwaiNotOwned = 9,
        
        MogwaiAlreadyOwned = 10,
        
        MogwaiBadRarity = 11,
        
        MogwaiSame = 12,
        
        MogwaiNoHatch = 13,
        
        MogwaiIsOnSale = 14,
        
        MogwaiNotAffordable = 15,
    }
    
    /// <summary>
    /// >> 432 - Variant[pallet_ajuna_battle_mogs.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
