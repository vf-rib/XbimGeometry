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
    /// Readonly interface for IfcMechanicalSteelMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMechanicalSteelMaterialProperties : IIfcMechanicalMaterialProperties
	{
		IfcPressureMeasure? @YieldStress { get;  set; }
		IfcPressureMeasure? @UltimateStress { get;  set; }
		IfcPositiveRatioMeasure? @UltimateStrain { get;  set; }
		IfcModulusOfElasticityMeasure? @HardeningModule { get;  set; }
		IfcPressureMeasure? @ProportionalStress { get;  set; }
		IfcPositiveRatioMeasure? @PlasticStrain { get;  set; }
		IItemSet<IIfcRelaxation> @Relaxations { get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcMechanicalSteelMaterialProperties", 510)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalSteelMaterialProperties : IfcMechanicalMaterialProperties, IInstantiableEntity, IIfcMechanicalSteelMaterialProperties, IContainsEntityReferences, IEquatable<@IfcMechanicalSteelMaterialProperties>
	{
		#region IIfcMechanicalSteelMaterialProperties explicit implementation
		IfcPressureMeasure? IIfcMechanicalSteelMaterialProperties.YieldStress { 
 
			get { return @YieldStress; } 
			set { YieldStress = value;}
		}	
		IfcPressureMeasure? IIfcMechanicalSteelMaterialProperties.UltimateStress { 
 
			get { return @UltimateStress; } 
			set { UltimateStress = value;}
		}	
		IfcPositiveRatioMeasure? IIfcMechanicalSteelMaterialProperties.UltimateStrain { 
 
			get { return @UltimateStrain; } 
			set { UltimateStrain = value;}
		}	
		IfcModulusOfElasticityMeasure? IIfcMechanicalSteelMaterialProperties.HardeningModule { 
 
			get { return @HardeningModule; } 
			set { HardeningModule = value;}
		}	
		IfcPressureMeasure? IIfcMechanicalSteelMaterialProperties.ProportionalStress { 
 
			get { return @ProportionalStress; } 
			set { ProportionalStress = value;}
		}	
		IfcPositiveRatioMeasure? IIfcMechanicalSteelMaterialProperties.PlasticStrain { 
 
			get { return @PlasticStrain; } 
			set { PlasticStrain = value;}
		}	
		IItemSet<IIfcRelaxation> IIfcMechanicalSteelMaterialProperties.Relaxations { 
			get { return new Common.Collections.ProxyItemSet<IfcRelaxation, IIfcRelaxation>( @Relaxations); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalSteelMaterialProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relaxations = new OptionalItemSet<IfcRelaxation>( this, 0,  13);
		}

		#region Explicit attribute fields
		private IfcPressureMeasure? _yieldStress;
		private IfcPressureMeasure? _ultimateStress;
		private IfcPositiveRatioMeasure? _ultimateStrain;
		private IfcModulusOfElasticityMeasure? _hardeningModule;
		private IfcPressureMeasure? _proportionalStress;
		private IfcPositiveRatioMeasure? _plasticStrain;
		private readonly OptionalItemSet<IfcRelaxation> _relaxations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPressureMeasure? @YieldStress 
		{ 
			get 
			{
				if(_activated) return _yieldStress;
				Activate();
				return _yieldStress;
			} 
			set
			{
				SetValue( v =>  _yieldStress = v, _yieldStress, value,  "YieldStress", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPressureMeasure? @UltimateStress 
		{ 
			get 
			{
				if(_activated) return _ultimateStress;
				Activate();
				return _ultimateStress;
			} 
			set
			{
				SetValue( v =>  _ultimateStress = v, _ultimateStress, value,  "UltimateStress", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcPositiveRatioMeasure? @UltimateStrain 
		{ 
			get 
			{
				if(_activated) return _ultimateStrain;
				Activate();
				return _ultimateStrain;
			} 
			set
			{
				SetValue( v =>  _ultimateStrain = v, _ultimateStrain, value,  "UltimateStrain", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcModulusOfElasticityMeasure? @HardeningModule 
		{ 
			get 
			{
				if(_activated) return _hardeningModule;
				Activate();
				return _hardeningModule;
			} 
			set
			{
				SetValue( v =>  _hardeningModule = v, _hardeningModule, value,  "HardeningModule", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcPressureMeasure? @ProportionalStress 
		{ 
			get 
			{
				if(_activated) return _proportionalStress;
				Activate();
				return _proportionalStress;
			} 
			set
			{
				SetValue( v =>  _proportionalStress = v, _proportionalStress, value,  "ProportionalStress", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcPositiveRatioMeasure? @PlasticStrain 
		{ 
			get 
			{
				if(_activated) return _plasticStrain;
				Activate();
				return _plasticStrain;
			} 
			set
			{
				SetValue( v =>  _plasticStrain = v, _plasticStrain, value,  "PlasticStrain", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 13)]
		public IOptionalItemSet<IfcRelaxation> @Relaxations 
		{ 
			get 
			{
				if(_activated) return _relaxations;
				Activate();
				return _relaxations;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_yieldStress = value.RealVal;
					return;
				case 7: 
					_ultimateStress = value.RealVal;
					return;
				case 8: 
					_ultimateStrain = value.RealVal;
					return;
				case 9: 
					_hardeningModule = value.RealVal;
					return;
				case 10: 
					_proportionalStress = value.RealVal;
					return;
				case 11: 
					_plasticStrain = value.RealVal;
					return;
				case 12: 
					_relaxations.InternalAdd((IfcRelaxation)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMechanicalSteelMaterialProperties other)
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
				foreach(var entity in @Relaxations)
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