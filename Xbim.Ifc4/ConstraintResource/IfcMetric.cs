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
using Xbim.Ifc4.ConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMetric
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMetric : IIfcConstraint
	{
		IfcBenchmarkEnum @Benchmark { get;  set; }
		IfcLabel? @ValueSource { get;  set; }
		IIfcMetricValueSelect @DataValue { get;  set; }
		IIfcReference @ReferencePath { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ConstraintResource
{
	[ExpressType("IfcMetric", 80)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMetric : IfcConstraint, IInstantiableEntity, IIfcMetric, IContainsEntityReferences, IEquatable<@IfcMetric>
	{
		#region IIfcMetric explicit implementation
		IfcBenchmarkEnum IIfcMetric.Benchmark { 
 
			get { return @Benchmark; } 
			set { Benchmark = value;}
		}	
		IfcLabel? IIfcMetric.ValueSource { 
 
			get { return @ValueSource; } 
			set { ValueSource = value;}
		}	
		IIfcMetricValueSelect IIfcMetric.DataValue { 
 
 
			get { return @DataValue; } 
			set { DataValue = value as IfcMetricValueSelect;}
		}	
		IIfcReference IIfcMetric.ReferencePath { 
 
 
			get { return @ReferencePath; } 
			set { ReferencePath = value as IfcReference;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMetric(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcBenchmarkEnum _benchmark;
		private IfcLabel? _valueSource;
		private IfcMetricValueSelect _dataValue;
		private IfcReference _referencePath;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 10)]
		public IfcBenchmarkEnum @Benchmark 
		{ 
			get 
			{
				if(_activated) return _benchmark;
				Activate();
				return _benchmark;
			} 
			set
			{
				SetValue( v =>  _benchmark = v, _benchmark, value,  "Benchmark", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcLabel? @ValueSource 
		{ 
			get 
			{
				if(_activated) return _valueSource;
				Activate();
				return _valueSource;
			} 
			set
			{
				SetValue( v =>  _valueSource = v, _valueSource, value,  "ValueSource", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcMetricValueSelect @DataValue 
		{ 
			get 
			{
				if(_activated) return _dataValue;
				Activate();
				return _dataValue;
			} 
			set
			{
				var entity = value as IPersistEntity;
				if (entity != null && !(ReferenceEquals(Model, entity.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _dataValue = v, _dataValue, value,  "DataValue", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 13)]
		public IfcReference @ReferencePath 
		{ 
			get 
			{
				if(_activated) return _referencePath;
				Activate();
				return _referencePath;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referencePath = v, _referencePath, value,  "ReferencePath", 11);
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
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
                    _benchmark = (IfcBenchmarkEnum) System.Enum.Parse(typeof (IfcBenchmarkEnum), value.EnumVal, true);
					return;
				case 8: 
					_valueSource = value.StringVal;
					return;
				case 9: 
					_dataValue = (IfcMetricValueSelect)(value.EntityVal);
					return;
				case 10: 
					_referencePath = (IfcReference)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMetric other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@CreatingActor != null)
					yield return @CreatingActor;
				if (@ReferencePath != null)
					yield return @ReferencePath;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}