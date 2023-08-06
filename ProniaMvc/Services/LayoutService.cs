using Microsoft.EntityFrameworkCore;
using ProniaMvc.DataAccess;

namespace ProniaMvc.Services;

public class LayoutService
{
    readonly ProniaDbContext _context;
    public LayoutService(ProniaDbContext context)
    {
        _context = context;
    }
    public async Task<Dictionary<string, string>> GetSettings()
        => await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
}
 