//------------------------------------------------------------------------------
// <auto-generated>
// Hello
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Net.Sendvia.Models
{
	public partial class QuoteShipment
	{
		public virtual Guid? ShipmentId
		{get;set;}
	
		public virtual decimal Cost
		{get;set;}
	
		public virtual decimal Surcharge
		{get;set;}
	
		public virtual DateTime? EarliestCollection
		{get;set;}
	
		public virtual Service Service
		{get;set;}
	
		public virtual Carrier Carrier
		{get;set;}
	
		public virtual bool Vat
		{get;set;}
	
	}
}