// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOrientationExpression
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOrientationExpression : IIfcGeometricRepresentationItem
	{
		IIfcDirection @LateralAxisDirection { get;  set; }
		IIfcDirection @VerticalAxisDirection { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcOrientationExpression", 1352)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrientationExpression : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcOrientationExpression, IContainsEntityReferences, IEquatable<@IfcOrientationExpression>
	{
		#region IIfcOrientationExpression explicit implementation
		IIfcDirection IIfcOrientationExpression.LateralAxisDirection { 
 
 
			get { return @LateralAxisDirection; } 
			set { LateralAxisDirection = value as IfcDirection;}
		}	
		IIfcDirection IIfcOrientationExpression.VerticalAxisDirection { 
 
 
			get { return @VerticalAxisDirection; } 
			set { VerticalAxisDirection = value as IfcDirection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrientationExpression(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _lateralAxisDirection;
		private IfcDirection _verticalAxisDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcDirection @LateralAxisDirection 
		{ 
			get 
			{
				if(_activated) return _lateralAxisDirection;
				Activate();
				return _lateralAxisDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lateralAxisDirection = v, _lateralAxisDirection, value,  "LateralAxisDirection", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDirection @VerticalAxisDirection 
		{ 
			get 
			{
				if(_activated) return _verticalAxisDirection;
				Activate();
				return _verticalAxisDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _verticalAxisDirection = v, _verticalAxisDirection, value,  "VerticalAxisDirection", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_lateralAxisDirection = (IfcDirection)(value.EntityVal);
					return;
				case 1: 
					_verticalAxisDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOrientationExpression other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@LateralAxisDirection != null)
					yield return @LateralAxisDirection;
				if (@VerticalAxisDirection != null)
					yield return @VerticalAxisDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}