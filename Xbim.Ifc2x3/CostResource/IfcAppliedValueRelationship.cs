// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.CostResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAppliedValueRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAppliedValueRelationship : IPersistEntity
	{
		IIfcAppliedValue @ComponentOfTotal { get;  set; }
		IItemSet<IIfcAppliedValue> @Components { get; }
		IfcArithmeticOperatorEnum @ArithmeticOperator { get;  set; }
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.CostResource
{
	[ExpressType("IfcAppliedValueRelationship", 691)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAppliedValueRelationship : PersistEntity, IInstantiableEntity, IIfcAppliedValueRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcAppliedValueRelationship>
	{
		#region IIfcAppliedValueRelationship explicit implementation
		IIfcAppliedValue IIfcAppliedValueRelationship.ComponentOfTotal { 
 
 
			get { return @ComponentOfTotal; } 
			set { ComponentOfTotal = value as IfcAppliedValue;}
		}	
		IItemSet<IIfcAppliedValue> IIfcAppliedValueRelationship.Components { 
			get { return new Common.Collections.ProxyItemSet<IfcAppliedValue, IIfcAppliedValue>( @Components); } 
		}	
		IfcArithmeticOperatorEnum IIfcAppliedValueRelationship.ArithmeticOperator { 
 
			get { return @ArithmeticOperator; } 
			set { ArithmeticOperator = value;}
		}	
		IfcLabel? IIfcAppliedValueRelationship.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcAppliedValueRelationship.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAppliedValueRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_components = new ItemSet<IfcAppliedValue>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcAppliedValue _componentOfTotal;
		private readonly ItemSet<IfcAppliedValue> _components;
		private IfcArithmeticOperatorEnum _arithmeticOperator;
		private IfcLabel? _name;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcAppliedValue @ComponentOfTotal 
		{ 
			get 
			{
				if(_activated) return _componentOfTotal;
				Activate();
				return _componentOfTotal;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _componentOfTotal = v, _componentOfTotal, value,  "ComponentOfTotal", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcAppliedValue> @Components 
		{ 
			get 
			{
				if(_activated) return _components;
				Activate();
				return _components;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 3)]
		public IfcArithmeticOperatorEnum @ArithmeticOperator 
		{ 
			get 
			{
				if(_activated) return _arithmeticOperator;
				Activate();
				return _arithmeticOperator;
			} 
			set
			{
				SetValue( v =>  _arithmeticOperator = v, _arithmeticOperator, value,  "ArithmeticOperator", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_componentOfTotal = (IfcAppliedValue)(value.EntityVal);
					return;
				case 1: 
					_components.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 2: 
                    _arithmeticOperator = (IfcArithmeticOperatorEnum) System.Enum.Parse(typeof (IfcArithmeticOperatorEnum), value.EnumVal, true);
					return;
				case 3: 
					_name = value.StringVal;
					return;
				case 4: 
					_description = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAppliedValueRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ComponentOfTotal != null)
					yield return @ComponentOfTotal;
				foreach(var entity in @Components)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ComponentOfTotal != null)
					yield return @ComponentOfTotal;
				foreach(var entity in @Components)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}