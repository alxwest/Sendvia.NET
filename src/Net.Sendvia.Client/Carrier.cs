//------------------------------------------------------------------------------
// <auto-generated>
// Hello
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Net.Sendvia.Models
{
	public partial class Carrier
	{
		public virtual Guid? Id
		{get;set;}
	
		public virtual string Name
		{get;set;}
	
		public virtual bool Private
		{get;set;}
	
		public virtual bool Editable
		{get;set;}
	
		public virtual List<Service> Services
		{get;set;}
	
	}
}