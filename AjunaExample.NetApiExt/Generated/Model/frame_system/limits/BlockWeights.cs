//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace AjunaExample.NetApiExt.Generated.Model.frame_system.limits
{
    
    
    /// <summary>
    /// >> 121 - Composite[frame_system.limits.BlockWeights]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BlockWeights : BaseType
    {
        
        /// <summary>
        /// >> base_block
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _baseBlock;
        
        /// <summary>
        /// >> max_block
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _maxBlock;
        
        /// <summary>
        /// >> per_class
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT2 _perClass;
        
        public AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight BaseBlock
        {
            get
            {
                return this._baseBlock;
            }
            set
            {
                this._baseBlock = value;
            }
        }
        
        public AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight MaxBlock
        {
            get
            {
                return this._maxBlock;
            }
            set
            {
                this._maxBlock = value;
            }
        }
        
        public AjunaExample.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT2 PerClass
        {
            get
            {
                return this._perClass;
            }
            set
            {
                this._perClass = value;
            }
        }
        
        public override string TypeName()
        {
            return "BlockWeights";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BaseBlock.Encode());
            result.AddRange(MaxBlock.Encode());
            result.AddRange(PerClass.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BaseBlock = new AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            BaseBlock.Decode(byteArray, ref p);
            MaxBlock = new AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            MaxBlock.Decode(byteArray, ref p);
            PerClass = new AjunaExample.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT2();
            PerClass.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
