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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOpticalMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOpticalMaterialProperties : IIfcMaterialProperties
	{
		IfcPositiveRatioMeasure? @VisibleTransmittance { get;  set; }
		IfcPositiveRatioMeasure? @SolarTransmittance { get;  set; }
		IfcPositiveRatioMeasure? @ThermalIrTransmittance { get;  set; }
		IfcPositiveRatioMeasure? @ThermalIrEmissivityBack { get;  set; }
		IfcPositiveRatioMeasure? @ThermalIrEmissivityFront { get;  set; }
		IfcPositiveRatioMeasure? @VisibleReflectanceBack { get;  set; }
		IfcPositiveRatioMeasure? @VisibleReflectanceFront { get;  set; }
		IfcPositiveRatioMeasure? @SolarReflectanceFront { get;  set; }
		IfcPositiveRatioMeasure? @SolarReflectanceBack { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcOpticalMaterialProperties", 718)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOpticalMaterialProperties : IfcMaterialProperties, IInstantiableEntity, IIfcOpticalMaterialProperties, IContainsEntityReferences, IEquatable<@IfcOpticalMaterialProperties>
	{
		#region IIfcOpticalMaterialProperties explicit implementation
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.VisibleTransmittance { 
 
			get { return @VisibleTransmittance; } 
			set { VisibleTransmittance = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.SolarTransmittance { 
 
			get { return @SolarTransmittance; } 
			set { SolarTransmittance = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.ThermalIrTransmittance { 
 
			get { return @ThermalIrTransmittance; } 
			set { ThermalIrTransmittance = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.ThermalIrEmissivityBack { 
 
			get { return @ThermalIrEmissivityBack; } 
			set { ThermalIrEmissivityBack = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.ThermalIrEmissivityFront { 
 
			get { return @ThermalIrEmissivityFront; } 
			set { ThermalIrEmissivityFront = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.VisibleReflectanceBack { 
 
			get { return @VisibleReflectanceBack; } 
			set { VisibleReflectanceBack = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.VisibleReflectanceFront { 
 
			get { return @VisibleReflectanceFront; } 
			set { VisibleReflectanceFront = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.SolarReflectanceFront { 
 
			get { return @SolarReflectanceFront; } 
			set { SolarReflectanceFront = value;}
		}	
		IfcPositiveRatioMeasure? IIfcOpticalMaterialProperties.SolarReflectanceBack { 
 
			get { return @SolarReflectanceBack; } 
			set { SolarReflectanceBack = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOpticalMaterialProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveRatioMeasure? _visibleTransmittance;
		private IfcPositiveRatioMeasure? _solarTransmittance;
		private IfcPositiveRatioMeasure? _thermalIrTransmittance;
		private IfcPositiveRatioMeasure? _thermalIrEmissivityBack;
		private IfcPositiveRatioMeasure? _thermalIrEmissivityFront;
		private IfcPositiveRatioMeasure? _visibleReflectanceBack;
		private IfcPositiveRatioMeasure? _visibleReflectanceFront;
		private IfcPositiveRatioMeasure? _solarReflectanceFront;
		private IfcPositiveRatioMeasure? _solarReflectanceBack;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcPositiveRatioMeasure? @VisibleTransmittance 
		{ 
			get 
			{
				if(_activated) return _visibleTransmittance;
				Activate();
				return _visibleTransmittance;
			} 
			set
			{
				SetValue( v =>  _visibleTransmittance = v, _visibleTransmittance, value,  "VisibleTransmittance", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcPositiveRatioMeasure? @SolarTransmittance 
		{ 
			get 
			{
				if(_activated) return _solarTransmittance;
				Activate();
				return _solarTransmittance;
			} 
			set
			{
				SetValue( v =>  _solarTransmittance = v, _solarTransmittance, value,  "SolarTransmittance", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveRatioMeasure? @ThermalIrTransmittance 
		{ 
			get 
			{
				if(_activated) return _thermalIrTransmittance;
				Activate();
				return _thermalIrTransmittance;
			} 
			set
			{
				SetValue( v =>  _thermalIrTransmittance = v, _thermalIrTransmittance, value,  "ThermalIrTransmittance", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveRatioMeasure? @ThermalIrEmissivityBack 
		{ 
			get 
			{
				if(_activated) return _thermalIrEmissivityBack;
				Activate();
				return _thermalIrEmissivityBack;
			} 
			set
			{
				SetValue( v =>  _thermalIrEmissivityBack = v, _thermalIrEmissivityBack, value,  "ThermalIrEmissivityBack", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveRatioMeasure? @ThermalIrEmissivityFront 
		{ 
			get 
			{
				if(_activated) return _thermalIrEmissivityFront;
				Activate();
				return _thermalIrEmissivityFront;
			} 
			set
			{
				SetValue( v =>  _thermalIrEmissivityFront = v, _thermalIrEmissivityFront, value,  "ThermalIrEmissivityFront", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPositiveRatioMeasure? @VisibleReflectanceBack 
		{ 
			get 
			{
				if(_activated) return _visibleReflectanceBack;
				Activate();
				return _visibleReflectanceBack;
			} 
			set
			{
				SetValue( v =>  _visibleReflectanceBack = v, _visibleReflectanceBack, value,  "VisibleReflectanceBack", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveRatioMeasure? @VisibleReflectanceFront 
		{ 
			get 
			{
				if(_activated) return _visibleReflectanceFront;
				Activate();
				return _visibleReflectanceFront;
			} 
			set
			{
				SetValue( v =>  _visibleReflectanceFront = v, _visibleReflectanceFront, value,  "VisibleReflectanceFront", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcPositiveRatioMeasure? @SolarReflectanceFront 
		{ 
			get 
			{
				if(_activated) return _solarReflectanceFront;
				Activate();
				return _solarReflectanceFront;
			} 
			set
			{
				SetValue( v =>  _solarReflectanceFront = v, _solarReflectanceFront, value,  "SolarReflectanceFront", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcPositiveRatioMeasure? @SolarReflectanceBack 
		{ 
			get 
			{
				if(_activated) return _solarReflectanceBack;
				Activate();
				return _solarReflectanceBack;
			} 
			set
			{
				SetValue( v =>  _solarReflectanceBack = v, _solarReflectanceBack, value,  "SolarReflectanceBack", 10);
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
					_visibleTransmittance = value.RealVal;
					return;
				case 2: 
					_solarTransmittance = value.RealVal;
					return;
				case 3: 
					_thermalIrTransmittance = value.RealVal;
					return;
				case 4: 
					_thermalIrEmissivityBack = value.RealVal;
					return;
				case 5: 
					_thermalIrEmissivityFront = value.RealVal;
					return;
				case 6: 
					_visibleReflectanceBack = value.RealVal;
					return;
				case 7: 
					_visibleReflectanceFront = value.RealVal;
					return;
				case 8: 
					_solarReflectanceFront = value.RealVal;
					return;
				case 9: 
					_solarReflectanceBack = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOpticalMaterialProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}