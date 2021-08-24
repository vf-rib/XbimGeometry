// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
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
    /// Readonly interface for IfcOffsetCurve3D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOffsetCurve3D : IIfcOffsetCurve
	{
		IfcLengthMeasure @Distance { get;  set; }
		IfcLogical @SelfIntersect { get;  set; }
		IIfcDirection @RefDirection { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcOffsetCurve3D", 67)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOffsetCurve3D : IfcOffsetCurve, IInstantiableEntity, IIfcOffsetCurve3D, IContainsEntityReferences, IEquatable<@IfcOffsetCurve3D>
	{
		#region IIfcOffsetCurve3D explicit implementation
		IfcLengthMeasure IIfcOffsetCurve3D.Distance { 
 
			get { return @Distance; } 
			set { Distance = value;}
		}	
		IfcLogical IIfcOffsetCurve3D.SelfIntersect { 
 
			get { return @SelfIntersect; } 
			set { SelfIntersect = value;}
		}	
		IIfcDirection IIfcOffsetCurve3D.RefDirection { 
 
 
			get { return @RefDirection; } 
			set { RefDirection = value as IfcDirection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOffsetCurve3D(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _distance;
		private IfcLogical _selfIntersect;
		private IfcDirection _refDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLengthMeasure @Distance 
		{ 
			get 
			{
				if(_activated) return _distance;
				Activate();
				return _distance;
			} 
			set
			{
				SetValue( v =>  _distance = v, _distance, value,  "Distance", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLogical @SelfIntersect 
		{ 
			get 
			{
				if(_activated) return _selfIntersect;
				Activate();
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcDirection @RefDirection 
		{ 
			get 
			{
				if(_activated) return _refDirection;
				Activate();
				return _refDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _refDirection = v, _refDirection, value,  "RefDirection", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_distance = value.RealVal;
					return;
				case 2: 
					_selfIntersect = value.BooleanVal;
					return;
				case 3: 
					_refDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOffsetCurve3D other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisCurve != null)
					yield return @BasisCurve;
				if (@RefDirection != null)
					yield return @RefDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}