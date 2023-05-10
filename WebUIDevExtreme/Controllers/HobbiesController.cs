using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class HobbiesController : BaseController<Hobbies>
    {
        public HobbiesController(IUnitOfWork<Hobbies> context) : base(context)
        {
        }

    }
}
