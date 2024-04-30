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
    /// >> 411 - Composite[pallet_nfts.types.PendingSwap]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PendingSwap : BaseType
    {
        
        /// <summary>
        /// >> desired_collection
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _desiredCollection;
        
        /// <summary>
        /// >> desired_item
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<AjunaExample.NetApiExt.Generated.Model.primitive_types.H256> _desiredItem;
        
        /// <summary>
        /// >> price
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types.PriceWithDirection> _price;
        
        /// <summary>
        /// >> deadline
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _deadline;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 DesiredCollection
        {
            get
            {
                return this._desiredCollection;
            }
            set
            {
                this._desiredCollection = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<AjunaExample.NetApiExt.Generated.Model.primitive_types.H256> DesiredItem
        {
            get
            {
                return this._desiredItem;
            }
            set
            {
                this._desiredItem = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types.PriceWithDirection> Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Deadline
        {
            get
            {
                return this._deadline;
            }
            set
            {
                this._deadline = value;
            }
        }
        
        public override string TypeName()
        {
            return "PendingSwap";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(DesiredCollection.Encode());
            result.AddRange(DesiredItem.Encode());
            result.AddRange(Price.Encode());
            result.AddRange(Deadline.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            DesiredCollection = new Ajuna.NetApi.Model.Types.Primitive.U32();
            DesiredCollection.Decode(byteArray, ref p);
            DesiredItem = new Ajuna.NetApi.Model.Types.Base.BaseOpt<AjunaExample.NetApiExt.Generated.Model.primitive_types.H256>();
            DesiredItem.Decode(byteArray, ref p);
            Price = new Ajuna.NetApi.Model.Types.Base.BaseOpt<AjunaExample.NetApiExt.Generated.Model.pallet_nfts.types.PriceWithDirection>();
            Price.Decode(byteArray, ref p);
            Deadline = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Deadline.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
