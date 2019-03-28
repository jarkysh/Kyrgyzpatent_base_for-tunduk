using Microsoft.EntityFrameworkCore;
using Nmpt.Contract;
using Nmpt.Domain;
using System.Linq;
using X.PagedList;

namespace Nmpt.Service
{
    public class NmtpService : INmtpService
    {
        private readonly AppDbContext _dbContext;

        public NmtpService(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public SearchNmtpResponse SearchNmtpItems(SearchNmtpRequest request)
        {
            var query = from item in _dbContext.NmtpItems
                        select item;

            if (!string.IsNullOrEmpty(request.InNumberN))
                query = query.Where(item => EF.Functions.Like(item.InNumberN, $"%{request.InNumberN}%"));
            if (!string.IsNullOrEmpty(request.K11n))
                query = query.Where(item => EF.Functions.Like(item.K11n, $"%{request.K11n}%"));
            if (!string.IsNullOrEmpty(request.K15n))
                query = query.Where(item => EF.Functions.Like(item.K15n, $"%{request.K15n}%"));
            if (!string.IsNullOrEmpty(request.K18n))
                query = query.Where(item => EF.Functions.Like(item.K18n, $"%{request.K18n}%"));
            if (!string.IsNullOrEmpty(request.K21n))
                query = query.Where(item => EF.Functions.Like(item.K21n, $"%{request.K21n}%"));
            if (!string.IsNullOrEmpty(request.K22n))
                query = query.Where(item => EF.Functions.Like(item.K22n, $"%{request.K22n}%"));
            if (!string.IsNullOrEmpty(request.K46n))
                query = query.Where(item => EF.Functions.Like(item.K46n, $"%{request.K46n}%"));
            if (!string.IsNullOrEmpty(request.K54n))
                query = query.Where(item => EF.Functions.Like(item.K54n, $"%{request.K54n}%"));
            if (!string.IsNullOrEmpty(request.VidTovaraN))
                query = query.Where(item => EF.Functions.Like(item.VidTovaraN, $"%{request.VidTovaraN}%"));
            if (!string.IsNullOrEmpty(request.K71n))
                query = query.Where(item => EF.Functions.Like(item.K71n, $"%{request.K71n}%"));
            if (!string.IsNullOrEmpty(request.K73n))
                query = query.Where(item => EF.Functions.Like(item.K73n, $"%{request.K73n}%"));
            if (!string.IsNullOrEmpty(request.K57n))
                query = query.Where(item => EF.Functions.Like(item.K57n, $"%{request.K57n}%"));
            if (!string.IsNullOrEmpty(request.K98n))
                query = query.Where(item => EF.Functions.Like(item.K98n, $"%{request.K98n}%"));
            if (request.StatusNmpt.HasValue)
                query = query.Where(item => item.StatusNmpt == request.StatusNmpt.Value);

            var pagedQuery = query.OrderBy(item => item.IdNmtp).ToPagedList(request.Page, 200);

            return new SearchNmtpResponse()
            {
                Items = pagedQuery.ToArray(),
                PagesCount = pagedQuery.PageCount
            };
        }
    }
}
