using ASPProject.Application.UseCases.Commands;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Commands
{
  public class EfRemoveItemsFromUsersCart : IRemoveItemsFromUsersCart
  {
    private readonly ProjekatContext _context;

    public EfRemoveItemsFromUsersCart(ProjekatContext context)
    {
      _context = context;
    }

    public int Id => 28;

    public string Name => "Remove items from users cart";

    public void Execute(int request)
    {
      var items = _context.Carts.Where(x => x.UserId == request).ToList();
      _context.Carts.RemoveRange(items);
      _context.SaveChanges();
    }
  }
}
