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


namespace AjunaExample.NetApiExt.Generated.Types.Base
{
    
    
    /// <summary>
    /// >> 429 - Array
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Array)]
    public sealed class Arr2Arr32U8 : BaseType
    {
        
        private AjunaExample.NetApiExt.Generated.Types.Base.Arr32U8[] _value;
        
        public override int TypeSize
        {
            get
            {
                return 2;
            }
        }
        
        public AjunaExample.NetApiExt.Generated.Types.Base.Arr32U8[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return string.Format("[{0}; {1}]", new AjunaExample.NetApiExt.Generated.Types.Base.Arr32U8().TypeName(), this.TypeSize);
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new AjunaExample.NetApiExt.Generated.Types.Base.Arr32U8[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new AjunaExample.NetApiExt.Generated.Types.Base.Arr32U8();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        public void Create(AjunaExample.NetApiExt.Generated.Types.Base.Arr32U8[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}
