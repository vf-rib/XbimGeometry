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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcLine : IIfcLine
	{

		[CrossSchemaAttribute(typeof(IIfcLine), 1)]
		IIfcCartesianPoint IIfcLine.Pnt 
		{ 
			get
			{
				return Pnt;
			} 
			set
			{
				Pnt = value as IfcCartesianPoint;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLine), 2)]
		IIfcVector IIfcLine.Dir 
		{ 
			get
			{
				return Dir;
			} 
			set
			{
				Dir = value as IfcVector;
				
			}
		}
	//## Custom code
	//##
	}
}