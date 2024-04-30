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
    /// RandomnessController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class RandomnessController : ControllerBase
    {
        
        private IRandomnessStorage _randomnessStorage;
        
        /// <summary>
        /// RandomnessController constructor.
        /// </summary>
        public RandomnessController(IRandomnessStorage randomnessStorage)
        {
            _randomnessStorage = randomnessStorage;
        }
        
        /// <summary>
        /// >> RandomMaterial
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        [HttpGet("RandomMaterial")]
        [ProducesResponseType(typeof(AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT37), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.NetApiExt.Generated.Storage.RandomnessStorage), "RandomMaterialParams")]
        public IActionResult GetRandomMaterial()
        {
            return this.Ok(_randomnessStorage.GetRandomMaterial());
        }
    }
}
