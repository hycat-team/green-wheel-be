using Application.Dtos.DriverLicense.Response;
using Domain.Entities;

namespace Application.Abstractions
{
    public interface IDriverLicenseService
    {
        Task<DriverLicenseRes?> ProcessDriverLicenseAsync(Guid userId,
            string frontImageUrl, string frontPublicId, string backImageUrl, string backPublicId);

        Task<DriverLicense?> AddAsync(DriverLicense license);

        Task<DriverLicense?> UpdateAsync(DriverLicense license);

        Task<bool> DeleteAsync(Guid userId, string publicId);

        Task<DriverLicenseRes?> GetByUserIdAsync(Guid userId);

        Task<DriverLicense?> GetAsync(Guid id);

        Task<DriverLicense?> GetByLicenseNumberAsync(string licenseNumber);
        Task<string> VerifyDocumentTypeAsync(string imageUrl);
    }
}