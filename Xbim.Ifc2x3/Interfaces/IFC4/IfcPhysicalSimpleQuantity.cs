// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.QuantityResource
{
	public partial class @IfcPhysicalSimpleQuantity : IIfcPhysicalSimpleQuantity
	{

		[CrossSchemaAttribute(typeof(IIfcPhysicalSimpleQuantity), 3)]
		IIfcNamedUnit IIfcPhysicalSimpleQuantity.Unit 
		{ 
			get
			{
				return Unit;
			} 
			set
			{
				Unit = value as MeasureResource.IfcNamedUnit;
				
			}
		}
	//## Custom code
	//##
	}
}