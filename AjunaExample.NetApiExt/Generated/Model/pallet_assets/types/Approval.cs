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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> 182 - Composite[pallet_assets.types.Approval]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Approval : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public override string TypeName()
        {
            return "Approval";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
