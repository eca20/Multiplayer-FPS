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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_identity.pallet
{
    
    
    public enum Event
    {
        
        IdentitySet = 0,
        
        IdentityCleared = 1,
        
        IdentityKilled = 2,
        
        JudgementRequested = 3,
        
        JudgementUnrequested = 4,
        
        JudgementGiven = 5,
        
        RegistrarAdded = 6,
        
        SubIdentityAdded = 7,
        
        SubIdentityRemoved = 8,
        
        SubIdentityRevoked = 9,
    }
    
    /// <summary>
    /// >> 60 - Variant[pallet_identity.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
