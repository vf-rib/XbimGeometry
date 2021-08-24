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
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelReferencedInSpatialStructure
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelReferencedInSpatialStructure : IIfcRelConnects
	{
		IItemSet<IIfcProduct> @RelatedElements { get; }
		IIfcSpatialElement @RelatingStructure { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelReferencedInSpatialStructure", 455)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelReferencedInSpatialStructure : IfcRelConnects, IInstantiableEntity, IIfcRelReferencedInSpatialStructure, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelReferencedInSpatialStructure>
	{
		#region IIfcRelReferencedInSpatialStructure explicit implementation
		IItemSet<IIfcProduct> IIfcRelReferencedInSpatialStructure.RelatedElements { 
			get { return new Common.Collections.ProxyItemSet<IfcProduct, IIfcProduct>( @RelatedElements); } 
		}	
		IIfcSpatialElement IIfcRelReferencedInSpatialStructure.RelatingStructure { 
 
 
			get { return @RelatingStructure; } 
			set { RelatingStructure = value as IfcSpatialElement;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelReferencedInSpatialStructure(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedElements = new ItemSet<IfcProduct>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcProduct> _relatedElements;
		private IfcSpatialElement _relatingStructure;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IItemSet<IfcProduct> @RelatedElements 
		{ 
			get 
			{
				if(_activated) return _relatedElements;
				Activate();
				return _relatedElements;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcSpatialElement @RelatingStructure 
		{ 
			get 
			{
				if(_activated) return _relatingStructure;
				Activate();
				return _relatingStructure;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingStructure = v, _relatingStructure, value,  "RelatingStructure", 6);
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
					_relatedElements.InternalAdd((IfcProduct)value.EntityVal);
					return;
				case 5: 
					_relatingStructure = (IfcSpatialElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelReferencedInSpatialStructure other)
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
				foreach(var entity in @RelatedElements)
					yield return entity;
				if (@RelatingStructure != null)
					yield return @RelatingStructure;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedElements)
					yield return entity;
				if (@RelatingStructure != null)
					yield return @RelatingStructure;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}