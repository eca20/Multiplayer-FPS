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


namespace AjunaExample.NetApiExt.Generated.Model.finality_grandpa
{
    
    
    /// <summary>
    /// >> 146 - Composite[finality_grandpa.EquivocationT1]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class EquivocationT1 : BaseType
    {
        
        /// <summary>
        /// >> round_number
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _roundNumber;
        
        /// <summary>
        /// >> identity
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public _identity;
        
        /// <summary>
        /// >> first
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.finality_grandpa.Prevote, AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature> _first;
        
        /// <summary>
        /// >> second
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.finality_grandpa.Prevote, AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature> _second;
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 RoundNumber
        {
            get
            {
                return this._roundNumber;
            }
            set
            {
                this._roundNumber = value;
            }
        }
        
        public AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public Identity
        {
            get
            {
                return this._identity;
            }
            set
            {
                this._identity = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.finality_grandpa.Prevote, AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature> First
        {
            get
            {
                return this._first;
            }
            set
            {
                this._first = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.finality_grandpa.Prevote, AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature> Second
        {
            get
            {
                return this._second;
            }
            set
            {
                this._second = value;
            }
        }
        
        public override string TypeName()
        {
            return "EquivocationT1";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(RoundNumber.Encode());
            result.AddRange(Identity.Encode());
            result.AddRange(First.Encode());
            result.AddRange(Second.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            RoundNumber = new Ajuna.NetApi.Model.Types.Primitive.U64();
            RoundNumber.Decode(byteArray, ref p);
            Identity = new AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public();
            Identity.Decode(byteArray, ref p);
            First = new Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.finality_grandpa.Prevote, AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature>();
            First.Decode(byteArray, ref p);
            Second = new Ajuna.NetApi.Model.Types.Base.BaseTuple<AjunaExample.NetApiExt.Generated.Model.finality_grandpa.Prevote, AjunaExample.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature>();
            Second.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
