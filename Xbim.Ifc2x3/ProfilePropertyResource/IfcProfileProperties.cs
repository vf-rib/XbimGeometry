// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProfileProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProfileProperties : IPersistEntity
	{
		IfcLabel? @ProfileName { get;  set; }
		IIfcProfileDef @ProfileDefinition { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcProfileProperties", 649)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcProfileProperties : PersistEntity, IIfcProfileProperties, IEquatable<@IfcProfileProperties>
	{
		#region IIfcProfileProperties explicit implementation
		IfcLabel? IIfcProfileProperties.ProfileName { 
 
			get { return @ProfileName; } 
			set { ProfileName = value;}
		}	
		IIfcProfileDef IIfcProfileProperties.ProfileDefinition { 
 
 
			get { return @ProfileDefinition; } 
			set { ProfileDefinition = value as IfcProfileDef;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProfileProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _profileName;
		private IfcProfileDef _profileDefinition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @ProfileName 
		{ 
			get 
			{
				if(_activated) return _profileName;
				Activate();
				return _profileName;
			} 
			set
			{
				SetValue( v =>  _profileName = v, _profileName, value,  "ProfileName", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcProfileDef @ProfileDefinition 
		{ 
			get 
			{
				if(_activated) return _profileDefinition;
				Activate();
				return _profileDefinition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _profileDefinition = v, _profileDefinition, value,  "ProfileDefinition", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_profileName = value.StringVal;
					return;
				case 1: 
					_profileDefinition = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProfileProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}