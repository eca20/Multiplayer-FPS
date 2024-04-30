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


namespace AjunaExample.NetApiExt.Generated.Model.sp_weights.weight_v2
{
    
    
    /// <summary>
    /// >> 9 - Composite[sp_weights.weight_v2.Weight]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Weight : BaseType
    {
        
        /// <summary>
        /// >> ref_time
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> _refTime;
        
        /// <summary>
        /// >> proof_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> _proofSize;
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> RefTime
        {
            get
            {
                return this._refTime;
            }
            set
            {
                this._refTime = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> ProofSize
        {
            get
            {
                return this._proofSize;
            }
            set
            {
                this._proofSize = value;
            }
        }
        
        public override string TypeName()
        {
            return "Weight";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(RefTime.Encode());
            result.AddRange(ProofSize.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            RefTime = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>();
            RefTime.Decode(byteArray, ref p);
            ProofSize = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>();
            ProofSize.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
