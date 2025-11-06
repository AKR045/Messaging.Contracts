using System;

namespace Infrastructure.Messaging.HarasMessaging.Vendor.Response;

public sealed record VendorDTO
(
    Guid Id,
    string RegistrationNumber,
    string CompanyNameEn,
    string CompanyNameAr
    );
