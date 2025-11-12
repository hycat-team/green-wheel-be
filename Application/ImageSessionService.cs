using Application.Abstractions;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ImageSessionService : IImageSessionService
    {
        private readonly IMemoryCache _cache;

        public ImageSessionService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void StartSession(Guid userId, string frontId, string backId)
        {
            _cache.Set(userId, (frontId, backId), TimeSpan.FromMinutes(5));
        }

        public (string front, string back)? GetImageIds(Guid userId)
        {
            return _cache.TryGetValue<(string, string)>(userId, out var ids) ? ids : null;
        }

        public bool IsSessionActive(Guid userId)
        {
            return _cache.TryGetValue(userId, out _);
        }

        public void ExtendSession(Guid userId)
        {
            if (_cache.TryGetValue<(string front, string back)>(userId, out var ids))
                _cache.Set(userId, ids, TimeSpan.FromMinutes(5)); // gia hạn thêm 5 phút
        }
    }
}
