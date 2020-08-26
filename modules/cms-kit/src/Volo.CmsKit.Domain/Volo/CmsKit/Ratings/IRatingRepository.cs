﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp.Domain.Repositories;

namespace Volo.CmsKit.Ratings
{
    public interface IRatingRepository : IBasicRepository<Rating, Guid>
    {
        Task<List<Rating>> GetListAsync(
            [NotNull] string entityType,
            [NotNull] string entityId,
            CancellationToken cancellationToken = default
        );

        Task<Rating> GetCurrentUserRatingAsync(
            [NotNull] string entityType,
            [NotNull] string entityId,
            Guid userId,
            CancellationToken cancellationToken = default
        );
    }
}