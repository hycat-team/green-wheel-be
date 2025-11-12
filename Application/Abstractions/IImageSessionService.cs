using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IImageSessionService
    {
        void StartSession(Guid userId, string frontId, string backId);
        (string front, string back)? GetImageIds(Guid userId);
        bool IsSessionActive(Guid userId);
        void ExtendSession(Guid userId);
    }
}
