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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 403 - Composite[pallet_nfts.types.ItemMetadata]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ItemMetadata : BaseType
    {
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types.ItemMetadataDeposit _deposit;
        
        /// <summary>
        /// >> data
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 _data;
        
        public AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types.ItemMetadataDeposit Deposit
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
        
        public AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        
        public override string TypeName()
        {
            return "ItemMetadata";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Deposit.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Deposit = new AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types.ItemMetadataDeposit();
            Deposit.Decode(byteArray, ref p);
            Data = new AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7();
            Data.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
