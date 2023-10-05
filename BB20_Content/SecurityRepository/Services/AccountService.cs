using BB20_Content.SecurityModels;

namespace BB20_Content.SecurityRepository.Services;

public class AccountService
{
    private readonly BB20_SecurityGateWayContext _context;

    public AccountService(BB20_SecurityGateWayContext context)
    {
        _context = context;
    }

    public Account GetById(int id)
    {
        return _context.Accounts.Where(a => a.Id == id).FirstOrDefault();
    }
}
