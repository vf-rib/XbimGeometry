// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsStructuralActivity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsStructuralActivity : IIfcRelConnects
	{
		IIfcStructuralActivityAssignmentSelect @RelatingElement { get;  set; }
		IIfcStructuralActivity @RelatedStructuralActivity { get;  set; }
	
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IfcRelConnectsStructuralActivity", 211)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsStructuralActivity : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsStructuralActivity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsStructuralActivity>
	{
		#region IIfcRelConnectsStructuralActivity explicit implementation
		IIfcStructuralActivityAssignmentSelect IIfcRelConnectsStructuralActivity.RelatingElement { 
 
 
			get { return @RelatingElement; } 
			set { RelatingElement = value as IfcStructuralActivityAssignmentSelect;}
		}	
		IIfcStructuralActivity IIfcRelConnectsStructuralActivity.RelatedStructuralActivity { 
 
 
			get { return @RelatedStructuralActivity; } 
			set { RelatedStructuralActivity = value as IfcStructuralActivity;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsStructuralActivity(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcStructuralActivityAssignmentSelect _relatingElement;
		private IfcStructuralActivity _relatedStructuralActivity;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcStructuralActivityAssignmentSelect @RelatingElement 
		{ 
			get 
			{
				if(_activated) return _relatingElement;
				Activate();
				return _relatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcStructuralActivity @RelatedStructuralActivity 
		{ 
			get 
			{
				if(_activated) return _relatedStructuralActivity;
				Activate();
				return _relatedStructuralActivity;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedStructuralActivity = v, _relatedStructuralActivity, value,  "RelatedStructuralActivity", 6);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingElement = (IfcStructuralActivityAssignmentSelect)(value.EntityVal);
					return;
				case 5: 
					_relatedStructuralActivity = (IfcStructuralActivity)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsStructuralActivity other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedStructuralActivity != null)
					yield return @RelatedStructuralActivity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedStructuralActivity != null)
					yield return @RelatedStructuralActivity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}