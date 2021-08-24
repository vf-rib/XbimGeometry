// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCompositeCurveSegment
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCompositeCurveSegment : IIfcGeometricRepresentationItem
	{
		IfcTransitionCode @Transition { get;  set; }
		IfcBoolean @SameSense { get;  set; }
		IIfcCurve @ParentCurve { get;  set; }
		IEnumerable<IIfcCompositeCurve> @UsingCurves {  get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCompositeCurveSegment", 460)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurveSegment : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcCompositeCurveSegment, IContainsEntityReferences, IEquatable<@IfcCompositeCurveSegment>
	{
		#region IIfcCompositeCurveSegment explicit implementation
		IfcTransitionCode IIfcCompositeCurveSegment.Transition { 
 
			get { return @Transition; } 
			set { Transition = value;}
		}	
		IfcBoolean IIfcCompositeCurveSegment.SameSense { 
 
			get { return @SameSense; } 
			set { SameSense = value;}
		}	
		IIfcCurve IIfcCompositeCurveSegment.ParentCurve { 
 
 
			get { return @ParentCurve; } 
			set { ParentCurve = value as IfcCurve;}
		}	
		 
		IEnumerable<IIfcCompositeCurve> IIfcCompositeCurveSegment.UsingCurves {  get { return @UsingCurves; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurveSegment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTransitionCode _transition;
		private IfcBoolean _sameSense;
		private IfcCurve _parentCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 3)]
		public IfcTransitionCode @Transition 
		{ 
			get 
			{
				if(_activated) return _transition;
				Activate();
				return _transition;
			} 
			set
			{
				SetValue( v =>  _transition = v, _transition, value,  "Transition", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcBoolean @SameSense 
		{ 
			get 
			{
				if(_activated) return _sameSense;
				Activate();
				return _sameSense;
			} 
			set
			{
				SetValue( v =>  _sameSense = v, _sameSense, value,  "SameSense", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcCurve @ParentCurve 
		{ 
			get 
			{
				if(_activated) return _parentCurve;
				Activate();
				return _parentCurve;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _parentCurve = v, _parentCurve, value,  "ParentCurve", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                return ParentCurve.Dim;
				//##
			}
		}

		#endregion

		#region Inverse attributes
		[InverseProperty("Segments")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IEnumerable<IfcCompositeCurve> @UsingCurves 
		{ 
			get 
			{
				return Model.Instances.Where<IfcCompositeCurve>(e => e.Segments != null &&  e.Segments.Contains(this), "Segments", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _transition = (IfcTransitionCode) System.Enum.Parse(typeof (IfcTransitionCode), value.EnumVal, true);
					return;
				case 1: 
					_sameSense = value.BooleanVal;
					return;
				case 2: 
					_parentCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeCurveSegment other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ParentCurve != null)
					yield return @ParentCurve;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}