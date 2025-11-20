using Application.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.UnitOfWorks
{
    public interface IModelImageUow : IUnitOfwork
    {
        IModelImageRepository ModelImageRepository { get; }
        IVehicleModelRepository VehicleModelRepository { get; }

        //Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        //Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    }
}