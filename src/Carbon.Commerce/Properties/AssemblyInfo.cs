using System.Reflection;

[assembly: AssemblyTitle("Carbon.Commerce")]
[assembly: AssemblyProduct("Carbon")]
[assembly: AssemblyCopyright("© 2004-2013 Jason Nelson")]

[assembly: AssemblyVersion("0.1.1")]

/*
 0.1.0 (2013-01-20)
 -----------------------------------------------------
   CreditCardTransaction
 - Added BatchId
 
 0.0.9 (2012-11-01)
 -----------------------------------------------------
 - Update Carbon.Core to 4.5.3
 
 0.0.9 (2012-08-17)
 -----------------------------------------------------
 - Removed BillingPeriod (Replaced with TimeUnit)
 
   IPaymentProcessor 
 - Changed methods to Async (BREAKING)
 - Changed SupportsPaymentMethod to Accepts
   
 0.0.8 (2012-07-30)
 -----------------------------------------------------
 Carbon.Core 4.0.10
 
 0.0.7 (2012-07-23)
 -----------------------------------------------------
 Carbon.Core 4.0.9
 Cadmium -> Carbon
 
 0.0.6 (2011-04-19)
 -----------------------------------------------------
 - Removed UnitType
 - Removed Carbon.Commerce.Helpers Namespace
 
 CreditCardHelper
 - Added IsTestNumber(string number)

 BillingCycle
 - Removed BillingPeriod 
 - Removed BillingFrequency
 - CalculateNextBillingDate is implemented in Interval
 
 IAccount
 - Removed Balance
 
 0.0.5 (2011-08-01)
 -----------------------------------------------------
 - Removed CreditCardTransactionStatus 
 - Renamed TransactionType to PaymentAction
 - Changed SalesDocument.Id from Int32 to String
 - Removed Failure Transaction State
 
 CreditCardTransaction
 - Added Success (bool)

 0.0.4 (2011-04-05)
 -----------------------------------------------------
 - IMonentaryTransaction: Renamed TransasctionId to ReferenceNumber 
 
 BillingCycle
 - Implemented IRange<DateTime>
 
 0.0.3 (2011-01-05)
 -----------------------------------------------------
 - Removed Currency. Added ICurrency
 - Renamed ILineItem to ISalesLine
 
 0.0.2 (2011-01-04)
 -----------------------------------------------------
 :: Shipping
 - Added IPackage & IShippingMethod interfaces
 - Removed Carbon.Commerce.ShippingInfo
 - Refactored ShippingService

 0.0.1 (2010-12-11)
 -----------------------------------------------------
 - Moved Paypal into it's own library
 - Removed System.XML, System.XML.Linq, and System.Web depedencies 
*/