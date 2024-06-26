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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config
{
    
    
    /// <summary>
    /// >> 255 - Composite[pallet_ajuna_awesome_avatars.types.config.MintOption]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class MintOption : BaseType
    {
        
        /// <summary>
        /// >> payment
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPayment _payment;
        
        /// <summary>
        /// >> pack_type
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumPackType _packType;
        
        /// <summary>
        /// >> pack_size
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize _packSize;
        
        public AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPayment Payment
        {
            get
            {
                return this._payment;
            }
            set
            {
                this._payment = value;
            }
        }
        
        public AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumPackType PackType
        {
            get
            {
                return this._packType;
            }
            set
            {
                this._packType = value;
            }
        }
        
        public AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize PackSize
        {
            get
            {
                return this._packSize;
            }
            set
            {
                this._packSize = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintOption";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Payment.Encode());
            result.AddRange(PackType.Encode());
            result.AddRange(PackSize.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Payment = new AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPayment();
            Payment.Decode(byteArray, ref p);
            PackType = new AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumPackType();
            PackType.Decode(byteArray, ref p);
            PackSize = new AjunaExample.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize();
            PackSize.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
