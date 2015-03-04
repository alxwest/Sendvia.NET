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
	///Receipt details.
	///</summary>
	public partial class Receipt
	{
		///<summary>
		///Receipt ID
		///</summary>
		public virtual Guid? Id
		{get;set;}
	
		///<summary>
		///Booking ID
		///</summary>
		public virtual Guid? BookingId
		{get;set;}
	
		///<summary>
		///Currency in ISO 4217 Code N
		///</summary>
		public virtual int Currency
		{get;set;}
	
		///<summary>
		///Payment URL
		///</summary>
		public virtual string PaymentUrl
		{get;set;}
	
		///<summary>
		///Date the receipt was paid
		///</summary>
		public virtual DateTime? Paid
		{get;set;}
	
		///<summary>
		///Items in receipt
		///</summary>
		public virtual List<ReceiptItem> ReceiptItems
		{get;set;}
	
	}
}