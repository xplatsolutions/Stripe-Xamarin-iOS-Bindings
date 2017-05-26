using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace StripeBindings
{

[Native]
public enum STPShippingType : uint
{
	Shipping,
	Delivery
}

[Native]
public enum STPShippingStatus : uint
{
	Valid,
	Invalid
}

[Native]
public enum STPPaymentStatus : uint
{
	Success,
	Error,
	UserCancellation
}

[Native]
public enum STPFilePurpose : int
{
	IdentityDocument,
	DisputeEvidence,
	Unknown
}

[Native]
public enum STPBillingAddressFields : uint
{
	None,
	Zip,
	Full
}

[Native]
public enum STPPaymentMethodType : uint
{
	None = 0,
	ApplePay = 1 << 0,
	All = ApplePay
}

static class CFunctions
{
	// extern void linkSTPAPIClientApplePayCategory ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void linkSTPAPIClientApplePayCategory ();

	// extern void linkUINavigationBarThemeCategory ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern void linkUINavigationBarThemeCategory ();
}

[Native]
public enum STPBankAccountHolderType : int
{
	Individual,
	Company
}

[Native]
public enum STPBankAccountStatus : int
{
	New,
	Validated,
	Verified,
	Errored
}

[Native]
public enum STPCardBrand : int
{
	Visa,
	Amex,
	MasterCard,
	Discover,
	Jcb,
	DinersClub,
	Unknown
}

[Native]
public enum STPCardFundingType : int
{
	Debit,
	Credit,
	Prepaid,
	Other
}

[Native]
public enum STPCardValidationState : int
{
	Valid,
	Invalid,
	Incomplete
}

[Native]
public enum STPRedirectContextState : uint
{
	NotStarted,
	InProgress,
	Cancelled,
	Completed
}

[Native]
public enum STPSourceCard3DSecureStatus : int
{
	Required,
	Optional,
	NotSupported,
	Unknown
}

[Native]
public enum STPSourceRedirectStatus : int
{
	Pending,
	Succeeded,
	Failed,
	Unknown
}

[Native]
public enum STPSourceVerificationStatus : int
{
	Pending,
	Succeeded,
	Failed,
	Unknown
}

[Native]
public enum STPSourceFlow : int
{
	None,
	Redirect,
	CodeVerification,
	Receiver,
	Unknown
}

[Native]
public enum STPSourceUsage : int
{
	Reusable,
	SingleUse,
	Unknown
}

[Native]
public enum STPSourceStatus : int
{
	Pending,
	Chargeable,
	Consumed,
	Canceled,
	Failed,
	Unknown
}

[Native]
public enum STPSourceType : int
{
	Bancontact,
	Bitcoin,
	Card,
	Giropay,
	Ideal,
	SEPADebit,
	Sofort,
	ThreeDSecure,
	Unknown
}

[Native]
public enum STPErrorCode : int
{
	ConnectionError = 40,
	InvalidRequestError = 50,
	APIError = 60,
	CardError = 70,
	CancellationError = 80,
	CheckoutUnknownError = 5000,
	CheckoutTooManyAttemptsError = 5001
}

}