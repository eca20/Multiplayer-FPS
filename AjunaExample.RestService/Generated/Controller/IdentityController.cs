//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using AjunaExample.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AjunaExample.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// IdentityController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class IdentityController : ControllerBase
    {
        
        private IIdentityStorage _identityStorage;
        
        /// <summary>
        /// IdentityController constructor.
        /// </summary>
        public IdentityController(IIdentityStorage identityStorage)
        {
            _identityStorage = identityStorage;
        }
        
        /// <summary>
        /// >> IdentityOf
        ///  Information that is pertinent to identify the entity behind an account.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("IdentityOf")]
        [ProducesResponseType(typeof(AjunaExample.NetApiExt.Generated.Model.pallet_identity.types.Registration), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.NetApiExt.Generated.Storage.IdentityStorage), "IdentityOfParams", typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetIdentityOf(string key)
        {
            return this.Ok(_identityStorage.GetIdentityOf(key));
        }
        
        /// <summary>
        /// >> SuperOf
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        [HttpGet("SuperOf")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, AjunaExample.NetApiExt.Generated.Model.pallet_identity.types.EnumData>), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.NetApiExt.Generated.Storage.IdentityStorage), "SuperOfParams", typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetSuperOf(string key)
        {
            return this.Ok(_identityStorage.GetSuperOf(key));
        }
        
        /// <summary>
        /// >> SubsOf
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("SubsOf")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT29>), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.NetApiExt.Generated.Storage.IdentityStorage), "SubsOfParams", typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetSubsOf(string key)
        {
            return this.Ok(_identityStorage.GetSubsOf(key));
        }
        
        /// <summary>
        /// >> Registrars
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        [HttpGet("Registrars")]
        [ProducesResponseType(typeof(AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.NetApiExt.Generated.Storage.IdentityStorage), "RegistrarsParams")]
        public IActionResult GetRegistrars()
        {
            return this.Ok(_identityStorage.GetRegistrars());
        }
    }
}
