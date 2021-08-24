// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcNullStyle", 566)]
	[DefinedType(typeof(IfcNullStyleEnum))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcNullStyle : IfcPresentationStyleSelect, IExpressValueType, System.IEquatable<IfcNullStyleEnum>
	{ 
		private IfcNullStyleEnum _value;
        
		public object Value
        {
            get { return _value; }
        }

		public override string ToString()
        {
			return _value.ToString();
        }
        public IfcNullStyle(IfcNullStyleEnum val)
        {
            _value = val;
        }

		public IfcNullStyle(string val)
        {
			var value = val.Trim('.');
			if (!System.Enum.TryParse(value, true, out _value))
                throw new System.ArgumentException();
        }

        public static implicit operator IfcNullStyle(IfcNullStyleEnum value)
        {
            return new IfcNullStyle(value);
        }

        public static implicit operator IfcNullStyleEnum(IfcNullStyle obj)
        {
            return obj._value;

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcNullStyle) obj)._value == _value;
        }

		public bool Equals(IfcNullStyleEnum other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcNullStyle obj1, IfcNullStyle obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcNullStyle obj1, IfcNullStyle obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            System.Enum.TryParse(value.EnumVal, true, out _value);
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(IfcNullStyleEnum);
			}
		}
		#endregion


	}
}
