//------------------------------------------------------------------------------
// <auto-generated>
// Hello
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Net.Sendvia.Models
{
	///<summary>
	///Service details.
	///</summary>
	public partial class Service
	{
		///<summary>
		///Service ID
		///</summary>
		public virtual Guid? Id
		{get;set;}
	
		///<summary>
		///Service name
		///</summary>
		public virtual string Name
		{get;set;}
	
		///<summary>
		///Service transport to use (Road, Rail, Air or Sea)
		///</summary>
		public virtual string Transport
		{get;set;}
	
		///<summary>
		///True if the service offers tracking
		///</summary>
		public virtual bool Tracked
		{get;set;}
	
		///<summary>
		///True if the service is volumetric
		///</summary>
		public virtual bool Volumetric
		{get;set;}
	
		///<summary>
		///True if a label is to be produced for this service
		///</summary>
		public virtual bool PrintLabels
		{get;set;}
	
		///<summary>
		///Description of service
		///</summary>
		public virtual string Description
		{get;set;}
	
		///<summary>
		///Service information
		///</summary>
		public virtual string Information
		{get;set;}
	
		///<summary>
		///Routes availabe for this service
		///</summary>
		public virtual List<Route> Routes
		{get;set;}
	
	}
}