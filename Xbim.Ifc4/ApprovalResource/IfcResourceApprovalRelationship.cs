// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ApprovalResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcResourceApprovalRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcResourceApprovalRelationship : IIfcResourceLevelRelationship
	{
		IItemSet<IIfcResourceObjectSelect> @RelatedResourceObjects { get; }
		IIfcApproval @RelatingApproval { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ApprovalResource
{
	[ExpressType("IfcResourceApprovalRelationship", 1256)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceApprovalRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcResourceApprovalRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcResourceApprovalRelationship>
	{
		#region IIfcResourceApprovalRelationship explicit implementation
		IItemSet<IIfcResourceObjectSelect> IIfcResourceApprovalRelationship.RelatedResourceObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcResourceObjectSelect, IIfcResourceObjectSelect>( @RelatedResourceObjects); } 
		}	
		IIfcApproval IIfcResourceApprovalRelationship.RelatingApproval { 
 
 
			get { return @RelatingApproval; } 
			set { RelatingApproval = value as IfcApproval;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceApprovalRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		private IfcApproval _relatingApproval;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcResourceObjectSelect> @RelatedResourceObjects 
		{ 
			get 
			{
				if(_activated) return _relatedResourceObjects;
				Activate();
				return _relatedResourceObjects;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(_activated) return _relatingApproval;
				Activate();
				return _relatingApproval;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_relatedResourceObjects.InternalAdd((IfcResourceObjectSelect)value.EntityVal);
					return;
				case 3: 
					_relatingApproval = (IfcApproval)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcResourceApprovalRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @RelatedResourceObjects)
					yield return entity;
				if (@RelatingApproval != null)
					yield return @RelatingApproval;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedResourceObjects)
					yield return entity;
				if (@RelatingApproval != null)
					yield return @RelatingApproval;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}