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


namespace AjunaExample.NetApiExt.Generated.Model.sp_weights
{
    
    
    /// <summary>
    /// >> 127 - Composite[sp_weights.RuntimeDbWeight]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class RuntimeDbWeight : BaseType
    {
        
        /// <summary>
        /// >> read
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _read;
        
        /// <summary>
        /// >> write
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _write;
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Read
        {
            get
            {
                return this._read;
            }
            set
            {
                this._read = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Write
        {
            get
            {
                return this._write;
            }
            set
            {
                this._write = value;
            }
        }
        
        public override string TypeName()
        {
            return "RuntimeDbWeight";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Read.Encode());
            result.AddRange(Write.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Read = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Read.Decode(byteArray, ref p);
            Write = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Write.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
