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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_sudo.pallet
{
    
    
    public enum Call
    {
        
        sudo = 0,
        
        sudo_unchecked_weight = 1,
        
        set_key = 2,
        
        sudo_as = 3,
    }
    
    /// <summary>
    /// >> 200 - Variant[pallet_sudo.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, AjunaExample.NetApiExt.Generated.Model.ajuna_solo_runtime.EnumRuntimeCall, BaseTuple<AjunaExample.NetApiExt.Generated.Model.ajuna_solo_runtime.EnumRuntimeCall, AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, AjunaExample.NetApiExt.Generated.Model.ajuna_solo_runtime.EnumRuntimeCall>>
    {
    }
}
