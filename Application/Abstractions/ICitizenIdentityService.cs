using Application.Dtos.CitizenIdentity.Response;
using Domain.Entities;

namespace Application.Abstractions
{
    public interface ICitizenIdentityService
    {
        Task<CitizenIdentityRes?> ProcessCitizenIdentityAsync(Guid userId,
            string frontImageUrl, string frontPublicId, string backImageUrl, string backPublicId);

        Task<CitizenIdentity> AddAsync(CitizenIdentity identity);

        Task<bool> RemoveAsync(Guid userId, string publicId);

        Task<CitizenIdentity?> UpdateAsync(CitizenIdentity identity);

        Task<CitizenIdentity?> GetByIdAsync(Guid id);

        Task<CitizenIdentityRes?> GetByUserId(Guid userId);

        Task<CitizenIdentity?> GetByIdentityNumberAsync(string identityNumber);
        Task<string> VerifyDocumentTypeAsync(string imageUrl);
    }
}